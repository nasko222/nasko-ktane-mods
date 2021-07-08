using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;
using System.Text.RegularExpressions;
using System;

public class AntichamberModule : MonoBehaviour
{

	public KMBombInfo BombInfo;
	public KMBombModule BombModule;
	public KMSelectable GunButton;
	public KMSelectable ArrowLeft;
	public KMSelectable ArrowRight;
	public KMSelectable Submit;
	public KMAudio KMAudio;
	public TextMesh RoomLabel;
	public GameObject Gun;
	public Sprite[] guns;
	public string[] rooms;

	private bool AntichamberUnicornP1
	{
		get
		{
			return this.BombInfo.GetSerialNumber().Any(x => new[] { '1' }.Contains(x));
		}
	}

	private bool AntichamberUnicornP2
	{
		get
		{
			return this.BombInfo.GetSerialNumber().Any(x => new[] { '3' }.Contains(x));
		}
	}

	private int counter = 0;
	private IEnumerable<string> duplicates;

	int gun = 0;
	int roomindex = 0;
	int determine = 0;

	int solved;
	int unsolved;
	int allmodules;

	int batteries;
	int holders;
	int lastDigit;
	int strikes;

	int vanillaports;
	int moddedports;

	int PortParallel;
	int PortSerial;
	int PortDVI;
	int PortStereoRCA;
	int PortRJ45;
	int PortPS2;

	int ModdedPortCompositeVideo;
	int ModdedPortComponentVideo;
	int ModdedPortUSB;
	int ModdedPortHDMI;
	int ModdedPortVGA;
	int ModdedPortAC;
	int ModdedPortPCMCIA;

	int module3dmaze;
	int module3dtunnels;
	int maze;
	int mousemaze;
	int morsemaze;

	int password;
	int extended;
	int binarypuzzle;
	int symbolic;

	int doubleoh;
	int cursedoh;

	private int AdjustNumber(int value, int adjustWith)
	{
		if (value <= 0)
		{
			while (value <= 0)
			{
				value += adjustWith;
			}
		}
		else if (value > adjustWith)
		{
			while (value > adjustWith)
			{
				value -= adjustWith;
			}
		}

		return value;
	}

	void Start()
	{
		gun = UnityEngine.Random.Range(0, 4);
		roomindex = UnityEngine.Random.Range(0, 13);
		GunButton.OnInteract += GunButtonCode;
		ArrowLeft.OnInteract += LeftButtonCode;
		ArrowRight.OnInteract += RightButtonCode;
		Submit.OnInteract += SubmitEvent;
		Gun.GetComponent<SpriteRenderer>().sprite = guns[gun];
		RoomLabel.text = rooms[roomindex];
		lastDigit = BombInfo.GetSerialNumberNumbers().Last();
		duplicates = BombInfo.GetModuleNames().
		GroupBy(x => x).
		Where(group => group.Count() > 1).
		Select(group => group.Key);

		//Count Vanilla Ports
		PortParallel = BombInfo.GetPortCount(Port.Parallel);
		PortSerial = BombInfo.GetPortCount(Port.Serial);
		PortDVI = BombInfo.GetPortCount(Port.DVI);
		PortStereoRCA = BombInfo.GetPortCount(Port.StereoRCA);
		PortRJ45 = BombInfo.GetPortCount(Port.RJ45);
		PortPS2 = BombInfo.GetPortCount(Port.PS2);

		vanillaports = PortParallel + PortSerial + PortDVI + PortStereoRCA + PortRJ45 + PortPS2;

		//Count Modded Ports
		ModdedPortCompositeVideo = BombInfo.GetPortCount(Port.CompositeVideo);
		ModdedPortComponentVideo = BombInfo.GetPortCount(Port.ComponentVideo);
		ModdedPortUSB = BombInfo.GetPortCount(Port.USB);
		ModdedPortHDMI = BombInfo.GetPortCount(Port.HDMI);
		ModdedPortVGA = BombInfo.GetPortCount(Port.VGA);
		ModdedPortAC = BombInfo.GetPortCount(Port.AC);
		ModdedPortPCMCIA = BombInfo.GetPortCount(Port.PCMCIA);

		moddedports = ModdedPortCompositeVideo + ModdedPortComponentVideo + ModdedPortUSB + ModdedPortHDMI + ModdedPortVGA + ModdedPortAC + ModdedPortPCMCIA;

		holders = BombInfo.GetBatteryHolderCount();
		batteries = BombInfo.GetBatteryCount();

		determine = (vanillaports - moddedports) * (batteries + holders);
		determine = this.AdjustNumber(determine, 4);

		//Debug Output Log
		Debug.Log("AntichamberGun = " + determine);
		Debug.Log("SelectedGun = " + (gun + 1));
		Debug.Log("UnicornP1 = " + AntichamberUnicornP1);
		Debug.Log("UnicornP2 = " + AntichamberUnicornP2);
	}

	void Update()
	{
		counter++;
		if (counter == 30)
		{
			solved = BombInfo.GetSolvedModuleNames().Count;
			allmodules = BombInfo.GetSolvableModuleNames().Count;
			unsolved = allmodules - solved;
			strikes = BombInfo.GetStrikes();

			//Count Solved Modules
			module3dmaze = BombInfo.GetSolvedModuleNames().Count(x => x == "3D Maze");
			module3dtunnels = BombInfo.GetSolvedModuleNames().Count(x => x == "3D Tunnels");
			maze = BombInfo.GetSolvedModuleNames().Count(x => x == "Maze");
			mousemaze = BombInfo.GetSolvedModuleNames().Count(x => x == "Mouse In The Maze");
			morsemaze = BombInfo.GetSolvedModuleNames().Count(x => x == "Morse-A-Maze");

			//Count Unsolved Modules
			password = BombInfo.GetSolvableModuleNames().Count(x => x == "Password") - BombInfo.GetSolvedModuleNames().Count(x => x == "Password");
			extended = BombInfo.GetSolvableModuleNames().Count(x => x == "Extended Password") - BombInfo.GetSolvedModuleNames().Count(x => x == "Extended Password");
			binarypuzzle = BombInfo.GetSolvableModuleNames().Count(x => x == "Binary Puzzle") - BombInfo.GetSolvedModuleNames().Count(x => x == "Binary Puzzle");
			symbolic = BombInfo.GetSolvableModuleNames().Count(x => x == "Symbolic Password") - BombInfo.GetSolvedModuleNames().Count(x => x == "Symbolic Password");

			//Count All Modules
			doubleoh = BombInfo.GetSolvableModuleNames().Count(x => x == "Double-Oh");
			cursedoh = BombInfo.GetSolvableModuleNames().Count(x => x == "Cursed Double-Oh");

			counter = 0;
		}
	}

	protected bool GunButtonCode()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, GunButton.transform);
		GunButton.AddInteractionPunch();
		gun++;
		if (gun >= 4) gun = 0;
		Gun.GetComponent<SpriteRenderer>().sprite = guns[gun];
		return false;
	}

	protected bool LeftButtonCode()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, ArrowLeft.transform);
		ArrowLeft.AddInteractionPunch();
		roomindex--;
		if (roomindex < 0) roomindex = 12;
		RoomLabel.text = rooms[roomindex];
		return false;
	}

	protected bool RightButtonCode()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, ArrowRight.transform);
		ArrowRight.AddInteractionPunch();
		roomindex++;
		if (roomindex > 12) roomindex = 0;
		RoomLabel.text = rooms[roomindex];
		return false;
	}

	protected bool SubmitEvent()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Submit.transform);
		Submit.AddInteractionPunch();
		if (!AntichamberUnicornP1 || !AntichamberUnicornP2)
		{
			if ((gun + 1) == determine)
			{
				if (solved >= 3)
				{
					if (roomindex == 0)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (lastDigit >= 8)
				{
					if (roomindex == 10)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (module3dmaze >= 1 || module3dtunnels >= 1 || maze >= 1 || mousemaze >= 1 || morsemaze >= 1)
				{
					if (roomindex == 6)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (strikes > 0)
				{
					if (roomindex == 3)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (password >= 1 || symbolic >= 1 || extended >= 1 || binarypuzzle >= 1)
				{
					if (roomindex == 1)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (solved == 0)
				{
					if (roomindex == 9)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (doubleoh >= 1 || cursedoh >= 1)
				{
					if (roomindex == 11)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (duplicates.Any())
				{
					if (roomindex == 2)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else
				{
					if (roomindex == 12)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
			}
			else
			{
				ModuleFail();
				return false;
			}
		}
		else
		{
			if ((gun + 1) == determine)
			{
				if (determine == 1)
				{
					if (roomindex == 8)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (determine == 2)
				{
					if (roomindex == 7)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (determine == 3)
				{
					if (roomindex == 5)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else if (determine == 4)
				{
					if (roomindex == 4)
					{
						ModuleCompleted();
						return false;
					}
					else
					{
						ModuleFail();
						return false;
					}
				}
				else
				{
					ModuleFail();
					return false;
				}
			}
			ModuleFail();
			return false;
		}
	}

	protected bool FailHandlePassGun()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, GunButton.transform);
		GunButton.AddInteractionPunch();
		return false;
	}

	protected bool FailHandlePassLeft()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, ArrowLeft.transform);
		ArrowLeft.AddInteractionPunch();
		return false;
	}

	protected bool FailHandlePassRight()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, ArrowRight.transform);
		ArrowRight.AddInteractionPunch();
		return false;
	}

	protected bool FailHandlePassSubmit()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Submit.transform);
		Submit.AddInteractionPunch();
		return false;
	}

	protected bool ModuleCompleted()
	{
		BombModule.HandlePass();
		GunButton.OnInteract = FailHandlePassGun;
		ArrowLeft.OnInteract = FailHandlePassLeft;
		ArrowRight.OnInteract = FailHandlePassRight;
		Submit.OnInteract = FailHandlePassSubmit;
		return false;
	}

	protected bool ModuleFail()
	{
		BombModule.HandleStrike();
		return false;
	}

	//twitch plays
#pragma warning disable 414
	private readonly string TwitchHelpMessage = @"!{0} gun <red/blue/green/yellow> [Selects the specified gun] | !{0} room <room> [Selects the specified room] | !{0} submit [Presses the submit button]";
#pragma warning restore 414
	IEnumerator ProcessTwitchCommand(string command)
	{
		string[] parameters = command.Split(' ');
		if (Regex.IsMatch(parameters[0], @"^\s*submit\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			yield return null;
			Submit.OnInteract();
			yield break;
		}
		if (Regex.IsMatch(parameters[0], @"^\s*gun\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			if (parameters.Length == 2)
			{
				string[] gunTypes = { "blue", "green", "yellow", "red" };
				if (gunTypes.Contains(parameters[1].ToLower()))
				{
					yield return null;
					while (gun != Array.IndexOf(gunTypes, parameters[1].ToLower()))
					{
						GunButton.OnInteract();
						yield return new WaitForSeconds(0.1f);
					}
				}
			}
			yield break;
		}
		if (Regex.IsMatch(parameters[0], @"^\s*room\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			if (parameters.Length >= 2)
			{
				string room = "";
				for (int i = 1; i < parameters.Length; i++)
				{
					room += parameters[i].ToLower() + " ";
				}
				room = room.Trim();
				if (rooms.Select(s => s.ToLower()).ToArray().Contains(room))
				{
					yield return null;
					int gotoind = Array.IndexOf(rooms.Select(s => s.ToLower()).ToArray(), room);
					int curind = roomindex;
					int ct1 = 0, ct2 = 0;
					while (curind != gotoind)
					{
						curind++;
						ct1++;
						if (curind > 12)
							curind = 0;
					}
					curind = roomindex;
					while (curind != gotoind)
					{
						curind--;
						ct2++;
						if (curind < 0)
							curind = 12;
					}
					if (ct1 < ct2)
					{
						for (int i = 0; i < ct1; i++)
						{
							ArrowRight.OnInteract();
							yield return new WaitForSeconds(0.1f);
						}
					}
					else
					{
						for (int i = 0; i < ct2; i++)
						{
							ArrowLeft.OnInteract();
							yield return new WaitForSeconds(0.1f);
						}
					}
				}
			}
			yield break;
		}
	}
}