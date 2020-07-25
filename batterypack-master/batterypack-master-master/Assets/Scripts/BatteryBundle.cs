using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

public class BatteryBundle : MonoBehaviour
{	
	//only debug purposes
	public KMBombInfo BombInfo { get { return this.BombInfo; } }

	//query key is used for the (queryKey == WIDGET_QUERY_KEY), while widget key is used for response adding
	//both can be found in KMBombExtensions.cs
	private string widgetKey = "numbatteries";
    private string WIDGET_QUERY_KEY = "batteries";
	
	//this is manipulated in Unity, depending how many batteries are in the holder.
	public int batteriesInTheHolder;
	
    void Awake()
    {
		//Connects with the query response
        GetComponent<KMWidget>().OnQueryRequest += GetQueryResponse;
    }
	
	void Start()
	{
		/*
		//only debug purposes
		//note that if there is one battery in holder, it will always be count as D battery, otherwise (if more) it gets count as AA battery.
		Debug.Log("allBatteries: " + BombInfo.GetBatteryCount());
		Debug.Log("zeroBatteries: " + BombInfo.GetBatteryCount(0));
		Debug.Log("oneBatteries: " + BombInfo.GetBatteryCount(1));
		Debug.Log("twoBatteries: " + BombInfo.GetBatteryCount(2));
		Debug.Log("threeBatteries: " + BombInfo.GetBatteryCount(3));
		Debug.Log("fourBatteries: " + BombInfo.GetBatteryCount(4));
		
		//only debug purposes
		//every battery widget are counted as holder, thats why the idea of glued batteries in the bomb is now obsolete.
		Debug.Log("allBatteryHolders: " + BombInfo.GetBatteryHolderCount());
		Debug.Log("zeroBatteryHolders: " + BombInfo.GetBatteryHolderCount(0));
		Debug.Log("oneBatteryHolders: " + BombInfo.GetBatteryHolderCount(1));
		Debug.Log("twoBatteryHolders: " + BombInfo.GetBatteryHolderCount(2));
		Debug.Log("threeBatteryHolders: " + BombInfo.GetBatteryHolderCount(3));
		Debug.Log("fourBatterryHolders: " + BombInfo.GetBatteryHolderCount(4));
		*/
	}

    public string GetQueryResponse(string queryKey, string queryInfo)
    {
		//checks when the game requests for the key we have.
        if (queryKey == WIDGET_QUERY_KEY)
        {
			//dictonary needs string widget key and then custom data that we send, in our case battery count.
            Dictionary<string, int> response = new Dictionary<string, int>();
            response.Add(widgetKey, batteriesInTheHolder);
			//serializing the response and returning to the game.
            string responseStr = JsonConvert.SerializeObject(response);
            return responseStr;
        }

        return "";
    }
}
