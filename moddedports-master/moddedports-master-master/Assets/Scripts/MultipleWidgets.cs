using System;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Random = UnityEngine.Random;

public class MultipleWidgets : MonoBehaviour
{
    #region public variables
    public GameObject[] Batteries;
    public GameObject[] BatteryHolders;
    public Transform[] AACells;
    public GameObject Ports;
    

    public GameObject HDMIPort;
    public GameObject USBPort;
    public GameObject ComponentVideoPort;
    public GameObject CompositeVideoPort;

    public GameObject ACPort;
    public GameObject PCMCIAPort;
    public GameObject VGAPort;

    public GameObject ACPortFiller;
    public GameObject USBPortFiller;
    public GameObject CompositeVideoPortFiller;
    public GameObject ComponentVideoPortFiller;
    public GameObject HDMIPortFiller;

    public GameObject MultipleWidgetTopHalf;

    public KMBombInfo Info;
    public AudioClip Notify;
	public KMRuleSeedable RuleSeed;
    #endregion

    #region private variables
    private readonly int _currentSettingsVersion = 4;
    private class ModSettings
    {
        public int SettingsVersion = 0;
        public bool EnableExtendedPorts = true;
        public string HowToUse0 = "Don't touch.";
        public bool DebugModeForceAllPortsInCurrentSet = false;
        public string HowToUse1 = "This forces the port plates to have every type possible in the given set.";
        public bool DebugModeForceAllPossiblePorts = false;
        public string HowToUse2 = "This Forces every port from the first port plate sets to spwan. (This overrides DebugModeForceAllPortsInCurrentSet)";
    }

    private static ModSettings _modSettings;

    private List<List<PortType>> _portGroups;
    private Dictionary<PortType, GameObject> _portLookup;
    private Dictionary<PortType, GameObject> _portFiller;
    private string[] _portGroupNames;


    private bool _ports = false;
    private PortType _presentPorts = (PortType) 0;
    private List<string> _portList = null;

    private static int _widgetCounter = 1;
    private int _widgetID;
    #endregion

    private void DebugLog(string log, params object[] args)
    {
        var logData = string.Format(log, args);
        Debug.LogFormat("[MultipleWidgets #{0}] {1}",_widgetID,logData);
    }

    private string GetModSettingsPath(bool directory)
    {
        string ModSettingsDirectory = Path.Combine(Application.persistentDataPath, "Modsettings");
        return directory ? ModSettingsDirectory : Path.Combine(ModSettingsDirectory, "ModdedPorts-debug.txt");
    }

    private void WriteSettings()
    {
        DebugLog("Writing Settings File");
        try
        {
            if (!Directory.Exists(GetModSettingsPath(true)))
            {
                Directory.CreateDirectory(GetModSettingsPath(true));
            }

            _modSettings.SettingsVersion = _currentSettingsVersion;
            string settings = JsonConvert.SerializeObject(_modSettings, Formatting.Indented);
            File.WriteAllText(GetModSettingsPath(false), settings);
            DebugLog("New settings = {0}", settings);
        }
        catch (Exception ex)
        {
            DebugLog("Failed to Create settings file due to Exception:\n{0}\nStack Trace:\n{1}", ex.Message, ex.StackTrace);
        }
    }

    private void LoadSettings()
    {
        string ModSettingsDirectory = Path.Combine(Application.persistentDataPath, "Modsettings");
        string ModSettings = Path.Combine(ModSettingsDirectory, "ModdedPorts-debug.txt");

        try
        {
            if (File.Exists(ModSettings))
            {
                string settings = File.ReadAllText(ModSettings);
                _modSettings = JsonConvert.DeserializeObject<ModSettings>(settings);

                if (_modSettings.SettingsVersion != _currentSettingsVersion)
                    WriteSettings();
            }
            else
            {
                _modSettings = new ModSettings();
                WriteSettings();
            }
        }
        catch (Exception ex)
        {
            DebugLog("Settings not loaded due to Exception:\n{0}\nStack Trace:\n{1}\nLoading default settings instead.",
                ex.Message, ex.StackTrace);
            _modSettings = new ModSettings();
            WriteSettings();
        }
    }

    void Awake()
    {
        _widgetID = _widgetCounter;
        _widgetCounter++;

        LoadSettings();

        Ports.SetActive(false);
        MultipleWidgetTopHalf.SetActive(true);

        foreach (var battery in Batteries)
            battery.SetActive(false);

        foreach (var holder in BatteryHolders)
            holder.SetActive(false);

        string[] widgetTypes = { "Ports", "Ports", "Ports", "Ports" };
        var widgetSet = new List<int> { 0, 1, 2, 3 };

        for (var i = 0; i < 2; i++)
        {
            var widget = widgetSet[Random.Range(0, widgetSet.Count)];
            widgetSet.Remove(widget);
            DebugLog("Widget #{0} = {1}", i + 1, widgetTypes[widget]);
            switch (widget)
            {
                case 0:
                    _ports = true;
                    SetPorts();
                    break;
                case 1:
                    _ports = true;
                    SetPorts();
                    break;
                case 2:
                    _ports = true;
                    SetPorts();
                    break;
                default:
                    _ports = true;
                    SetPorts();
                    break;
            }
        }
        GetComponent<KMWidget>().OnQueryRequest += GetQueryResponse;
        GetComponent<KMWidget>().OnWidgetActivate += OnActivate;
    }

    void Update()
    {
        PortUpdate();
    }

    public void LogEdgework(string[] items, string edgeworkname)
    {
        var edgework = "";
        foreach (var response in items)
        {
            if (edgework == "")
                edgework = edgeworkname + " " + response;
            else
                edgework += ", " + response;
        }
        if (edgework != "")
            DebugLog(edgework);
    }

    public void OnActivate()
    {

    }

    public string GetQueryResponse(string queryKey, string queryInfo)
    {
        if (_ports && GetPortQueryResponse(queryKey, queryInfo) != "")
            return GetPortQueryResponse(queryKey, queryInfo);

        //Debugging for seeing what widgets ARE present on each bomb according to KMBombInfo.GetQueryResponse
        if (queryKey.Equals("MultipleWidgetsIDQuery"))
            return JsonConvert.SerializeObject(
                new Dictionary<string, int> {{ "MultipleWidgetsIDQuery", _widgetID}});
        return "";
    }

    #region Ports
    void InitializePortSets()
    {
        _portGroups = new List<List<PortType>>
        {
            new List<PortType> {PortType.HDMI,PortType.USB,PortType.ComponentVideo,PortType.AC,PortType.PCMCIA,PortType.VGA,PortType.CompositeVideo },
            new List<PortType> {PortType.HDMI,PortType.ComponentVideo,PortType.VGA,PortType.CompositeVideo,PortType.AC },
            new List<PortType> {PortType.PCMCIA,PortType.VGA,PortType.USB,PortType.AC }
        };

        _portFiller = new Dictionary<PortType, GameObject>
        {
            {PortType.HDMI, HDMIPortFiller},
            {PortType.USB, USBPortFiller},
            {PortType.ComponentVideo, ComponentVideoPortFiller},
            {PortType.AC, ACPortFiller},
            {PortType.CompositeVideo, CompositeVideoPortFiller},
        };

        _portLookup = new Dictionary<PortType, GameObject>
        {
            {PortType.HDMI, HDMIPort},
            {PortType.USB, USBPort},
            {PortType.ComponentVideo, ComponentVideoPort},
            {PortType.AC, ACPort},
            {PortType.PCMCIA, PCMCIAPort},
            {PortType.VGA, VGAPort},
            {PortType.CompositeVideo, CompositeVideoPort}
        };

        _portGroupNames = new[] { "New Ports","TV/Monitor Ports","Computer Ports"};

        foreach (var port in _portLookup.Keys)
            _portLookup[port].SetActive(false);

        foreach (var portFiller in _portFiller.Keys)
            _portFiller[portFiller].SetActive(true);

    }

    void SetPorts()
    {
        Ports.SetActive(true);
        MultipleWidgetTopHalf.SetActive(false);
        InitializePortSets();
        _portList = new List<string>();

        if (!_modSettings.DebugModeForceAllPossiblePorts)
        {
            var portset = Random.Range(0, _modSettings.EnableExtendedPorts ? _portGroups.Count : 2);
            foreach (var set in _portGroups[portset])
            {
                if (!_modSettings.DebugModeForceAllPortsInCurrentSet && !(Random.value > 0.5f)) continue;
                _presentPorts |= set;
                _portLookup[set].SetActive(true);
                if (_portFiller.ContainsKey(set))
                    _portFiller[set].SetActive(false);
                _portList.Add(set.ToString());
            }

            //DebugLog("Using ports from the following port set: {0}", _portGroupNames[portset]);
            DebugLog("Ports ({0}): {1}", _portGroupNames[portset], _presentPorts.ToString());
        }
        else
        {
            DebugLog("Forcing EVERY possible port.");
            foreach (var port in _portLookup.Keys)
            {
                _presentPorts |= port;
                _portLookup[port].SetActive(true);
                _portList.Add(port.ToString());
                if (_portFiller.ContainsKey(port))
                {
                    _portFiller[port].SetActive(false);
                }
            }
            DebugLog("Ports ({0}): {1}", "Everything", _presentPorts.ToString());
        }
        //Debug.LogFormat("[PortWidget] Randomizing Port Widget: {0}", _presentPorts.ToString());
    }

    public bool IsPortPresent(PortType port)
    {
        return (_presentPorts & port) == port;
    }

    public void PortUpdate()
    {
        if (!_ports) return;

    }

    public string GetPortQueryResponse(string queryKey, string queryInfo)
    {
        if (queryKey == KMBombInfo.QUERYKEY_GET_PORTS)
        {
            var dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("presentPorts", _portList);
            return JsonConvert.SerializeObject(dictionary);
        }
        return "";
    }

    [Flags]
    public enum PortType
    {
        None = 0,

        HDMI = 64,
        USB = 128,
        ComponentVideo = 256,

        AC = 512,
        PCMCIA = 1024,
        VGA = 2048,
        CompositeVideo = 4096,
    }
    #endregion
}

static class Ext
{
    public static Color WithAlpha(this Color color, float alpha) { return new Color(color.r, color.g, color.b, alpha); }

    public static T[] NewArray<T>(params T[] array) { return array; }
}
