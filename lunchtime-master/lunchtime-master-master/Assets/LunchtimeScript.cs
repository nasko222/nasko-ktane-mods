using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KModkit;
using System.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System;

public class LunchtimeScript : MonoBehaviour
{
    public KMBombInfo BombInfo;
    public KMBombModule BombModule;
	public KMAudio KMAudio;
	public KMSelectable UpArrow;
	public KMSelectable DownArrow;
	public KMSelectable Submit;
	public Material[] Pictures;
    public MeshRenderer PictureBox;
    public GameObject[] TimerObjs;
	public TextMesh Minutes;
	public TextMesh Seconds;
	public AudioClip TickingSound;
	public TextMesh dollar;
	
	protected bool BossWaitForLunch = false;
	protected bool Exploded = false;

    string[] foodStrings = new string[] { "BBQ", "BLT", "Buffalo Wings", "Burger", "Burritos", "Cheesesteak", "Chili Dog", "Chinese Takeout", "Fettuccine", "Fried Chicken", "Grilled Cheese", "Grilled Fish", "Ham", "Hot Pocket", "Leftovers", "Macaroni And Cheese", "Meatball", "Monte Cristo", "Nutella And Banana", "PB&J", "Pizza", "Ravioli", "Reuben", "Roast Beef", "Salad", "Shish Kebab", "Soup", "Spaghetti", "Tacos", "TV Dinner" };

    int food = 0;
	int mins = 0;
	int secs = 0;
	
	int clicked = 1;

    float origcash = 0.00f;
    float cash = 0.00f;
	float cashafter = 0.00f;
	
	bool moneyChanged = true;
	
	int serialport;
	int stereoport;
	int parallelport;
	int ports;
	int indicators;
	
	int batteries;
	int dbat;
	int aabat;

    bool subtract = false;
	
	bool vegetables = true;
	bool dairy = true;
	bool twovowels = true;
	
	bool sandwiches = false;
	bool plates = false;
	
	bool unicorn = false;
	bool leftovers = false;
	
	bool case1 = false;
	bool case2 = false;
	bool case3 = false;
	
	int correct;
	
	//Logging
    static int moduleIdCounter = 1;
    int moduleId;
	
    private bool ContainsVowel()
    {
        return GetSerial().Any(ch => "AEIOU".Contains(ch));
    }

    string GetSerial()
    {
        List<string> response = BombInfo.QueryWidgets(KMBombInfo.QUERYKEY_GET_SERIAL_NUMBER, null);
        return JsonConvert.DeserializeObject<Dictionary<string, string>>(response[0])["serial"];
    }
	
	void Start ()
	{
		moduleId = moduleIdCounter++;
        cash = UnityEngine.Random.Range(1.00f, 7.00f);
        cash = cash * 100;
        cash = Mathf.Round(cash);
        cash = cash / 100;
        origcash = cash;
        food = UnityEngine.Random.Range(0, 30);
        batteries = BombInfo.GetBatteryCount();
        parallelport = BombInfo.GetPortCount(Port.Parallel);
        if (batteries > 4) { cash = cash + 0.61f; }
        else if (BombInfo.IsIndicatorOn("FRK") && parallelport == 0) { cash = cash + 0.43f; }
        else if (BombInfo.IsIndicatorPresent("FRQ") && BombInfo.IsIndicatorPresent("CAR")) { subtract = true; cash = cash - 1.00f; }
        else if (BombInfo.CountUniquePorts() > 2) { cash = cash + 0.18f; }
        else if (ContainsVowel()) { cash = cash + 0.37f; }
        else { moneyChanged = false; }

        dbat = BombInfo.GetBatteryCount(Battery.AA);
        aabat = BombInfo.GetBatteryCount(Battery.D);
        if (dbat > aabat) { sandwiches = true; }
        else if (aabat > dbat) { plates = true; }
        else if (aabat == dbat) { sandwiches = true; plates = true; }

        ports = BombInfo.GetPortCount();
        indicators = BombInfo.GetIndicators().Count();
        if (BombInfo.IsIndicatorOn("SND") || BombInfo.IsIndicatorOn("CLR") || BombInfo.IsIndicatorOff("MSA") || BombInfo.IsIndicatorOff("BOB")) { vegetables = false; }
        else if (ports + indicators >= 5) { dairy = false; }
        else if (cash > 6 && batteries < 2) { twovowels = false; }

        serialport = BombInfo.GetPortCount(Port.Serial);
        stereoport = BombInfo.GetPortCount(Port.StereoRCA);
        if (serialport == 1 && stereoport == 1 && ports == 2 && BombInfo.IsIndicatorOn("BOB")) { unicorn = true; }
        else if (cash < 1.24f) { leftovers = true; }
        else if (vegetables && !moneyChanged) { case1 = true; }
        else if (!vegetables && moneyChanged) { case2 = true; }
        else { case3 = true; }

        cashafter = cash;

        if (cash >= 6.41f && plates) { correct = 2; cashafter = cash - 6.41f; }
        else if (cash >= 5.82f && twovowels) { correct = 9; cashafter = cash - 5.82f; }
        else if (cash >= 5.33f && sandwiches && twovowels && dairy) { correct = 16; cashafter = cash - 5.33f; }
        else if (cash >= 5.22f && plates && dairy) { correct = 8; cashafter = cash - 5.22f; }
        else if (cash >= 5.18f && plates) { correct = 0; cashafter = cash - 5.18f; }
        else if (cash >= 4.71f && sandwiches && twovowels) { correct = 23; cashafter = cash - 4.71f; }
        else if (cash >= 4.67f && plates && twovowels) { correct = 26; cashafter = cash - 4.67f; }
        else if (cash >= 4.58f && sandwiches && vegetables) { correct = 1; cashafter = cash - 4.58f; }
        else if (cash >= 4.31f && plates) { correct = 27; cashafter = cash - 4.31f; }
        else if (cash >= 4.04f && sandwiches && twovowels && vegetables && dairy) { correct = 5; cashafter = cash - 4.04f; }
        else if (cash >= 3.76f && twovowels) { correct = 21; cashafter = cash - 3.76f; }
        else if (cash >= 3.62f && sandwiches && dairy) { correct = 18; cashafter = cash - 3.62f; }
        else if (cash >= 3.44f && sandwiches && twovowels && vegetables && dairy) { correct = 22; cashafter = cash - 3.44f; }
        else if (cash >= 3.43f && vegetables) { correct = 25; cashafter = cash - 3.43f; }
        else if (cash >= 3.41f && plates && dairy) { correct = 4; cashafter = cash - 3.41f; }
        else if (cash >= 3.39f && sandwiches && dairy) { correct = 12; cashafter = cash - 3.39f; }
        else if (cash >= 3.21f && plates && vegetables && dairy) { correct = 20; cashafter = cash - 3.21f; }
        else if (cash >= 2.96f && sandwiches && dairy) { correct = 17; cashafter = cash - 2.96f; }
        else if (cash >= 2.94f && vegetables) { correct = 29; cashafter = cash - 2.94f; }
        else if (cash >= 2.82f && twovowels && dairy) { correct = 15; cashafter = cash - 2.82f; }
        else if (cash >= 2.75f && twovowels && vegetables) { correct = 7; cashafter = cash - 2.75f; }
        else if (cash >= 2.55f && dairy) { correct = 13; cashafter = cash - 2.55f; }
        else if (cash >= 2.19f && sandwiches) { correct = 19; cashafter = cash - 2.19f; }
        else if (cash >= 2.05f && sandwiches && twovowels && dairy) { correct = 10; cashafter = cash - 2.05f; }
        else if (cash >= 2.04f && plates && vegetables) { correct = 28; cashafter = cash - 2.04f; }
        else if (cash >= 1.91f && sandwiches && vegetables && dairy) { correct = 3; cashafter = cash - 1.91f; }
        else if (cash >= 1.81f && plates) { correct = 9; cashafter = cash - 1.81f; }
        else if (cash >= 1.69f && plates && vegetables) { correct = 24; cashafter = cash - 1.69f; }
        else if (cash >= 1.24f) { correct = 6; cashafter = cash - 1.24f; }
        else { correct = 14; }

        cashafter = cashafter * 100;
        cashafter = Mathf.Round(cashafter);

        if (unicorn)
        {
            Debug.LogFormat("[Lunchtime #{0}] Oh would you look at that, Bob did the shopping for you!", moduleId);
            Debug.LogFormat("[Lunchtime #{0}] Press submit 3 times to solve the module", moduleId);
        }
        else
        {
            Debug.LogFormat("[Lunchtime #{0}] The amount of money given to you was {1}", moduleId, origcash.ToString("C"));
            if (subtract)
            {
                Debug.LogFormat("[Lunchtime #{0}] Oh no! You were robbed of a dollar while checking for spare change!", moduleId);
                Debug.LogFormat("[Lunchtime #{0}] The total budget is {1} - $1.00 = {2}", moduleId, origcash.ToString("C"), cash.ToString("C"));
            }
            else
            {
                Debug.LogFormat("[Lunchtime #{0}] The amount of spare change you have is {1}", moduleId, (cash - origcash).ToString("C"));
                Debug.LogFormat("[Lunchtime #{0}] The total budget is {1} + {2} = {3}", moduleId, origcash.ToString("C"), (cash - origcash).ToString("C"), cash.ToString("C"));
            }
            if (sandwiches && !plates)
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss is okay with any sandwich or other food, but not any entree plates", moduleId);
            }
            else if (!sandwiches && plates)
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss is okay with any entree plate or other food, but not any sandwiches", moduleId);
            }
            else if (sandwiches && plates)
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss is okay with any sandwich, entree plate, or other food", moduleId);
            }
            if (!vegetables)
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss does not like vegetables", moduleId);
            }
            else if (!dairy)
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss is allergic to dairy", moduleId);
            }
            else if (!twovowels)
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss does not like foods with two vowels in a row", moduleId);
            }
            else
            {
                Debug.LogFormat("[Lunchtime #{0}] Your boss is okay with vegetables, is not allergic to dairy, and is okay with foods with two vowels in a row", moduleId);
            }
            Debug.LogFormat("[Lunchtime #{0}] The food that best fits your bosses needs and is the highest-priced that can be bought with your budget is {1}", moduleId, foodStrings[correct]);
            if (case1)
            {
                Debug.LogFormat("[Lunchtime #{0}] The food must be delivered when the tens and ones seconds places of the module's timer add up to a prime number", moduleId);
            }
            else if (case2)
            {
                Debug.LogFormat("[Lunchtime #{0}] The food must be delivered when the ones digit of the module's timer is 0", moduleId);
            }
            else if (case3)
            {
                Debug.LogFormat("[Lunchtime #{0}] The food must be delivered when the ones digit of the module's timer is {1}", moduleId, cashafter % 10);
            }
        }
        GetComponent<KMBombModule>().OnActivate += ActivateModule;
	}
	
	void ActivateModule()
	{
		UpArrow.OnInteract += UpFunc;
		DownArrow.OnInteract += DownFunc;
		Submit.OnInteract += SubmitFunction;
		BossWaitForLunch = true;
        for (int i = 0; i < 3; i++)
            TimerObjs[i].SetActive(true);
		StartCoroutine(loop());
		PictureBox.GetComponent<MeshRenderer>().material = Pictures[food];
        mins = UnityEngine.Random.Range(8, 13);
        secs = UnityEngine.Random.Range(24, 49);
        if (secs == 0) {Seconds.text = "00";}
		else if (secs == 1) {Seconds.text = "01";}
		else if (secs == 2) {Seconds.text = "02";}
		else if (secs == 3) {Seconds.text = "03";}
		else if (secs == 4) {Seconds.text = "04";}
		else if (secs == 5) {Seconds.text = "05";}
		else if (secs == 6) {Seconds.text = "06";}
		else if (secs == 7) {Seconds.text = "07";}
		else if (secs == 8) {Seconds.text = "08";}
		else if (secs == 9) {Seconds.text = "09";}
		else { Seconds.text = secs.ToString(); }
		if (mins == 0) {Minutes.text = "00";}
		else if (mins == 1) {Minutes.text = "01";}
		else if (mins == 2) {Minutes.text = "02";}
		else if (mins == 3) {Minutes.text = "03";}
		else if (mins == 4) {Minutes.text = "04";}
		else if (mins == 5) {Minutes.text = "05";}			
		else if (mins == 6) {Minutes.text = "06";}
		else if (mins == 7) {Minutes.text = "07";}					
		else if (mins == 8) {Minutes.text = "08";}
		else if (mins == 9) {Minutes.text = "09";}
		else { Minutes.text = mins.ToString(); }
		dollar.text = origcash.ToString() + "$";
		if (dollar.text == "1$") {dollar.text = "1.00$";}
		if (dollar.text == "1.1$") {dollar.text = "1.10$";}
		if (dollar.text == "1.2$") {dollar.text = "1.20$";}
		if (dollar.text == "1.3$") {dollar.text = "1.30$";}
		if (dollar.text == "1.4$") {dollar.text = "1.40$";}
		if (dollar.text == "1.5$") {dollar.text = "1.50$";}
		if (dollar.text == "1.6$") {dollar.text = "1.60$";}
		if (dollar.text == "1.7$") {dollar.text = "1.70$";}
		if (dollar.text == "1.8$") {dollar.text = "1.80$";}
		if (dollar.text == "1.9$") {dollar.text = "1.90$";}
		if (dollar.text == "2$") {dollar.text = "2.00$";}
		if (dollar.text == "2.1$") {dollar.text = "2.10$";}
		if (dollar.text == "2.2$") {dollar.text = "2.20$";}
		if (dollar.text == "2.3$") {dollar.text = "2.30$";}
		if (dollar.text == "2.4$") {dollar.text = "2.40$";}
		if (dollar.text == "2.5$") {dollar.text = "2.50$";}
		if (dollar.text == "2.6$") {dollar.text = "2.60$";}
		if (dollar.text == "2.7$") {dollar.text = "2.70$";}
		if (dollar.text == "2.8$") {dollar.text = "2.80$";}
		if (dollar.text == "2.9$") {dollar.text = "2.90$";}
		if (dollar.text == "3$") {dollar.text = "3.00$";}
		if (dollar.text == "3.1$") {dollar.text = "3.10$";}
		if (dollar.text == "3.2$") {dollar.text = "3.20$";}
		if (dollar.text == "3.3$") {dollar.text = "3.30$";}
		if (dollar.text == "3.4$") {dollar.text = "3.40$";}
		if (dollar.text == "3.5$") {dollar.text = "3.50$";}
		if (dollar.text == "3.6$") {dollar.text = "3.60$";}
		if (dollar.text == "3.7$") {dollar.text = "3.70$";}
		if (dollar.text == "3.8$") {dollar.text = "3.80$";}
		if (dollar.text == "3.9$") {dollar.text = "3.90$";}
		if (dollar.text == "4$") {dollar.text = "4.00$";}
		if (dollar.text == "4.1$") {dollar.text = "4.10$";}
		if (dollar.text == "4.2$") {dollar.text = "4.20$";}
		if (dollar.text == "4.3$") {dollar.text = "4.30$";}
		if (dollar.text == "4.4$") {dollar.text = "4.40$";}
		if (dollar.text == "4.5$") {dollar.text = "4.50$";}
		if (dollar.text == "4.6$") {dollar.text = "4.60$";}
		if (dollar.text == "4.7$") {dollar.text = "4.70$";}
		if (dollar.text == "4.8$") {dollar.text = "4.80$";}
		if (dollar.text == "4.9$") {dollar.text = "4.90$";}
		if (dollar.text == "5$") {dollar.text = "5.00$";}
		if (dollar.text == "5.1$") {dollar.text = "5.10$";}
		if (dollar.text == "5.2$") {dollar.text = "5.20$";}
		if (dollar.text == "5.3$") {dollar.text = "5.30$";}
		if (dollar.text == "5.4$") {dollar.text = "5.40$";}
		if (dollar.text == "5.5$") {dollar.text = "5.50$";}
		if (dollar.text == "5.6$") {dollar.text = "5.60$";}
		if (dollar.text == "5.7$") {dollar.text = "5.70$";}
		if (dollar.text == "5.8$") {dollar.text = "5.80$";}
		if (dollar.text == "5.9$") {dollar.text = "5.90$";}
		if (dollar.text == "6$") {dollar.text = "6.00$";}
		if (dollar.text == "6.1$") {dollar.text = "6.10$";}
		if (dollar.text == "6.2$") {dollar.text = "6.20$";}
		if (dollar.text == "6.3$") {dollar.text = "6.30$";}
		if (dollar.text == "6.4$") {dollar.text = "6.40$";}
		if (dollar.text == "6.5$") {dollar.text = "6.50$";}
		if (dollar.text == "6.6$") {dollar.text = "6.60$";}
		if (dollar.text == "6.7$") {dollar.text = "6.70$";}
		if (dollar.text == "6.8$") {dollar.text = "6.80$";}
		if (dollar.text == "6.9$") {dollar.text = "6.90$";}
		if (dollar.text == "7$") {dollar.text = "7.00$";}
    }
	
	private IEnumerator loop()
	{
		while (BossWaitForLunch)
		{
			secs--;
			if (secs < 0) {secs = 59; mins--;}
			
			if (secs == 0) {Seconds.text = "00";}
			else if (secs == 1) {Seconds.text = "01";}
			else if (secs == 2) {Seconds.text = "02";}
			else if (secs == 3) {Seconds.text = "03";}
			else if (secs == 4) {Seconds.text = "04";}
			else if (secs == 5) {Seconds.text = "05";}
			else if (secs == 6) {Seconds.text = "06";}
			else if (secs == 7) {Seconds.text = "07";}
			else if (secs == 8) {Seconds.text = "08";}
			else if (secs == 9) {Seconds.text = "09";}
			else { Seconds.text = secs.ToString(); }
			
			if (mins == 0) {Minutes.text = "00";}
			else if (mins == 1) {Minutes.text = "01";}
			else if (mins == 2) {Minutes.text = "02";}
			else if (mins == 3) {Minutes.text = "03";}
			else if (mins == 4) {Minutes.text = "04";}
			else if (mins == 5) {Minutes.text = "05";}			
			else if (mins == 6) {Minutes.text = "06";}
			else if (mins == 7) {Minutes.text = "07";}					
			else if (mins == 8) {Minutes.text = "08";}
			else if (mins == 9) {Minutes.text = "09";}
			else { Minutes.text = mins.ToString(); }
			KMAudio.PlaySoundAtTransform(TickingSound.name, transform);
			if (mins == 0 && secs == 0) { if (!TwitchPlaysActive) Exploded = true; Debug.LogFormat("[Lunchtime #{0}] You took too long to deliver the food, your boss isn't gonna be happy about this...", moduleId); StartCoroutine(bomba()); if (!TwitchPlaysActive) BossWaitForLunch = false; }
			yield return new WaitForSeconds(1.0f);
		}
	}
	
	private IEnumerator bomba()
	{
        if (TwitchPlaysActive)
        {
            BombModule.HandleStrike();
            mins = UnityEngine.Random.Range(8, 13);
            secs = UnityEngine.Random.Range(24, 49);
        }
        else
        {
            while (Exploded)
            {
                BombModule.HandleStrike();
                yield return new WaitForSeconds(0.5f);
            }
        }
	}
	
	protected bool UpFunc()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, UpArrow.transform);
		UpArrow.AddInteractionPunch();
		food++;
		if (food > 29) food = 0;
		PictureBox.GetComponent<MeshRenderer>().material = Pictures[food];
		return false;
	}
	
	protected bool DownFunc()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, DownArrow.transform);
		DownArrow.AddInteractionPunch();
		food--;
		if (food < 0) food = 29;
		PictureBox.GetComponent<MeshRenderer>().material = Pictures[food];
		return false;
	}
	
	protected bool SubmitFunction()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Submit.transform);
		Submit.AddInteractionPunch();

		if (unicorn)
		{
			if (clicked == 3){Solved();}
			clicked++;
            Debug.LogFormat("[Lunchtime #{0}] Pressed the submit button", moduleId);
        }
		else if (leftovers && food == correct)
		{
            Debug.LogFormat("[Lunchtime #{0}] A delivery of '{1}' was sent to your boss at '{2}:{3}'!", moduleId, foodStrings[food], Minutes.text, Seconds.text);
            if (secs == 0 || secs == 6 || secs == 12 || secs == 18 || secs == 24 || secs == 30 || secs == 36 || secs == 42 || secs == 48 || secs == 54)
			{
                Debug.LogFormat("[Lunchtime #{0}] The food delivered and the time it was sent were correct! Module solved!", moduleId);
                Solved();
			}
			else
			{
                Debug.LogFormat("[Lunchtime #{0}] The food delivered was correct but the time it was sent was incorrect! Strike!", moduleId);
                Striked();
			}
		}
		else if (food == correct)
		{
            Debug.LogFormat("[Lunchtime #{0}] A delivery of '{1}' was sent to your boss at '{2}:{3}'!", moduleId, foodStrings[food], Minutes.text, Seconds.text);
            if (case1)
			{
				int i = secs % 10;
				int j = secs / 10;
				if (i + j == 2 || i + j == 3 || i + j == 5 || i + j == 7 || i + j == 11 || i + j == 13 || i + j == 17)
				{
                    Debug.LogFormat("[Lunchtime #{0}] The food delivered and the time it was sent were correct! Module solved!", moduleId);
                    Solved();
				}
				else
				{
                    Debug.LogFormat("[Lunchtime #{0}] The food delivered was correct but the time it was sent was incorrect! Strike!", moduleId);
                    Striked();
				}
			}
			else if (case2)
			{
				int i = secs % 10;
				if (i == 0)
				{
                    Debug.LogFormat("[Lunchtime #{0}] The food delivered and the time it was sent were correct! Module solved!", moduleId);
                    Solved();
				}
				else
				{
                    Debug.LogFormat("[Lunchtime #{0}] The food delivered was correct but the time it was sent was incorrect! Strike!", moduleId);
                    Striked();
				}
			}
			else if (case3)
			{
				float f = cashafter % 10;
				int i = secs % 10;
				if (i == f)
				{
                    Debug.LogFormat("[Lunchtime #{0}] The food delivered and the time it was sent were correct! Module solved!", moduleId);
                    Solved();
				}
				else
				{
                    Debug.LogFormat("[Lunchtime #{0}] The food delivered was correct but the time it was sent was incorrect! Strike!", moduleId);
                    Striked();
				}
			}
		}
		else
		{
            Debug.LogFormat("[Lunchtime #{0}] A delivery of '{1}' was sent to your boss at '{2}:{3}'!", moduleId, foodStrings[food], Minutes.text, Seconds.text);
            Debug.LogFormat("[Lunchtime #{0}] The food delivered was incorrect! Strike!", moduleId);
            Striked();
		}
		return false;
	}
	
	protected bool Solved()
	{
        BombModule.HandlePass();
		UpArrow.OnInteract = Nothingness;
		DownArrow.OnInteract = Nothingness;
		BossWaitForLunch = false;
		Submit.OnInteract = Nothingness;
		return false;
	}
	
	protected bool Striked()
	{
        BombModule.HandleStrike();
		return false;
	}
	
	protected bool Nothingness()
	{
		return false;
	}

    //twitch plays
    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"!{0} buy <food> [Buys the specified meal] | !{0} deliver (at ##) [Presses the deliver button (optionally when the ten's and one's place in the module's timer is '##')] | Multiple times may be included in the deliver command, for ex. '!{0} deliver at 07 40 23' | On Twitch Plays instead of exploding the bomb if the timer runs out this module will strike once and then reset the timer";
    private bool TwitchZenMode;
    private bool TwitchPlaysActive;
    #pragma warning restore 414
    IEnumerator ProcessTwitchCommand(string command)
    {
        if (Regex.IsMatch(command, @"^\s*deliver\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant) || Regex.IsMatch(command, @"^\s*submit\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
        {
            yield return null;
            Submit.OnInteract();
            yield break;
        }
        string[] parameters = command.Split(' ');
        if (Regex.IsMatch(parameters[0], @"^\s*buy\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
        {
            yield return null;
            if (parameters.Length >= 5)
            {
                yield return "sendtochaterror Too many parameters!";
            }
            else if (parameters.Length >= 2 && parameters.Length <= 4)
            {
                string[] foodTP = new string[] { "BBQ", "BLT", "BUFFALOWINGS", "BURGER", "BURRITOS", "CHEESESTEAK", "CHILIDOG", "CHINESETAKEOUT", "FETTUCCINE", "FRIEDCHICKEN", "GRILLEDCHEESE", "GRILLEDFISH", "HAM", "HOTPOCKET", "LEFTOVERS", "MACARONIANDCHEESE", "MEATBALL", "MONTECRISTO", "NUTELLAANDBANANA", "PB&J", "PIZZA", "RAVIOLI", "REUBEN", "ROASTBEEF", "SALAD", "SHISHKEBAB", "SOUP", "SPAGHETTI", "TACOS", "TVDINNER" };
                string foodstr = "";
                for (int i = 1; i < parameters.Length; i++)
                {
                    foodstr += parameters[i].ToUpper();
                }
                if (!foodTP.Contains(foodstr))
                {
                    yield return "sendtochaterror The specified food '" + command.Substring(4) + "' is invalid!";
                    yield break;
                }
                int gotoind = Array.IndexOf(foodTP, foodstr);
                int dir1 = food;
                int dir2 = food;
                int ct1 = 0;
                int ct2 = 0;
                while (dir1 != gotoind)
                {
                    dir1++;
                    ct1++;
                    if (dir1 > 29)
                        dir1 = 0;
                }
                while (dir2 != gotoind)
                {
                    dir2--;
                    ct2++;
                    if (dir2 < 0)
                        dir2 = 29;
                }
                if (ct1 < ct2)
                {
                    for (int i = 0; i < ct1; i++)
                    {
                        UpArrow.OnInteract();
                        yield return new WaitForSeconds(0.1f);
                    }
                }
                else if (ct2 < ct1)
                {
                    for (int i = 0; i < ct2; i++)
                    {
                        DownArrow.OnInteract();
                        yield return new WaitForSeconds(0.1f);
                    }
                }
                else
                {
                    if (UnityEngine.Random.Range(0, 2) == 0)
                    {
                        for (int i = 0; i < ct1; i++)
                        {
                            UpArrow.OnInteract();
                            yield return new WaitForSeconds(0.1f);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < ct2; i++)
                        {
                            DownArrow.OnInteract();
                            yield return new WaitForSeconds(0.1f);
                        }
                    }
                }
            }
            else if (parameters.Length == 1)
            {
                yield return "sendtochaterror Please specify which food to buy!";
            }
            yield break;
        }
        if (Regex.IsMatch(parameters[0], @"^\s*deliver\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant) || Regex.IsMatch(parameters[0], @"^\s*submit\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
        {
            yield return null;
            if (parameters.Length >= 3)
            {
                if (parameters[1].EqualsIgnoreCase("at"))
                {
                    //Code from Press X
                    bool waitingMusic = true;
                    bool minutes;

                    string[] times = new string[parameters.Length - 2];
                    for (int i = 0; i < parameters.Length - 2; i++)
                    {
                        times[i] = parameters[i+2];
                    }
                        
                    List<int> result = new List<int>();

                    if (!times.Any())
                    {
                        minutes = false;
                        for (int i = 0; i < 60; i++)
                        {
                            result.Add(i);
                        }
                    }
                    else
                    {
                        minutes = times.Any(x => x.Contains(":"));
                        foreach (string time in times)
                        {
                            int daysInt = 0, hoursInt = 0, minutesInt = 0, secondsInt;
                            string[] split = time.Split(':');
                            if ((split.Length == 1 && int.TryParse(split[0], out secondsInt)) ||
                                (split.Length == 2 && int.TryParse(split[0], out minutesInt) && int.TryParse(split[1], out secondsInt)) ||
                                (split.Length == 3 && int.TryParse(split[0], out hoursInt) && int.TryParse(split[1], out minutesInt) && int.TryParse(split[2], out secondsInt)) ||
                                (split.Length == 4 && int.TryParse(split[0], out daysInt) && int.TryParse(split[1], out hoursInt) && int.TryParse(split[2], out minutesInt) && int.TryParse(split[3], out secondsInt)))
                                result.Add((daysInt * 86400) + (hoursInt * 3600) + (minutesInt * 60) + secondsInt);
                            else
                            {
                                yield return string.Format("sendtochaterror Badly formatted time {0}. Time should either be in seconds (53) or in full time (1:23:45)", time);
                                yield break;
                            }
                        }
                        minutes |= result.Any(x => x >= 60);
                    }
                    yield return null;
                    yield return null;
                    int target = mins * 60 + secs;

                    if (!minutes)
                    {
                        target %= 60;
                        result = result.Select(x => x % 60).Distinct().ToList();
                    }

                    for (int i = result.Count - 1; i >= 0; i--)
                    {
                        int r = result[i];
                        if (!minutes && !TwitchZenMode)
                        {
                            waitingMusic &= ((target + (r > target ? 60 : 0)) - r) > 15;
                        }
                        else if (!minutes)
                        {
                            waitingMusic &= ((r + (r < target ? 60 : 0)) - target) > 15;
                        }
                        else if (!TwitchZenMode)
                        {
                            if (r > target)
                            {
                                result.RemoveAt(i);
                                continue;
                            }
                            waitingMusic &= (target - r) > 15;
                        }
                        else
                        {
                            if (r < target)
                            {
                                result.RemoveAt(i);
                                continue;
                            }
                            waitingMusic &= (r - target) > 15;
                        }
                    }

                    if (!result.Any())
                    {
                        yield return "sendtochaterror Delivery was NOT made because all of your specified times have gone by already.";
                        yield break;
                    }

                    if (waitingMusic)
                        yield return "waiting music";

                    while (!result.Contains(target))
                    {
                        yield return "trycancel The delivery was not made due to a request to cancel";
                        target = (mins * 60 + secs);
                        if (!minutes) target %= 60;
                    }
                    yield return "end waiting music";
                    Submit.OnInteract();
                    yield return new WaitForSeconds(0.1f);
                }
                else
                {
                    yield return "sendtochaterror The specified parameter '" + parameters[1] + "' is invalid! Expected 'at'!";
                }
            }
            else if (parameters.Length == 2)
            {
                if (parameters[1].EqualsIgnoreCase("at"))
                {
                    yield return "sendtochaterror Please include a time or times to deliver at!";
                }
                else
                {
                    yield return "sendtochaterror The specified parameter '" + parameters[1] + "' is invalid! Expected 'at'!";
                }
            }
            yield break;
        }
    }

    IEnumerator TwitchHandleForcedSolve()
    {
        while (!BossWaitForLunch) { yield return new WaitForSeconds(0.1f); }
        if (unicorn)
        {
            int start = clicked;
            for (int i = start; i < 3; i++)
            {
                Submit.OnInteract();
                yield return new WaitForSeconds(0.1f);
            }
        }
        else
        {
            yield return ProcessTwitchCommand("buy " + foodStrings[correct]);
            if (leftovers && food == correct)
            {
                yield return ProcessTwitchCommand("deliver at 00 06 12 18 24 30 36 42 48 54");
            }
            else if (food == correct)
            {
                if (case1)
                {
                    yield return ProcessTwitchCommand("deliver at 02 03 05 07 11 12 14 16 20 21 23 25 29 30 32 34 38 41 43 47 49 50 52 56 58");
                }
                else if (case2)
                {
                    yield return ProcessTwitchCommand("deliver at 00 10 20 30 40 50");
                }
                else if (case3)
                {
                    float f = cashafter % 10;
                    yield return ProcessTwitchCommand("deliver at 0" + f + " 1" + f + " 2" + f + " 3" + f + " 4" + f + " 5" + f + "");
                }
            }
        }
    }
}
