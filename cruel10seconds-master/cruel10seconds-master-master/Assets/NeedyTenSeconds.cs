using System;
using System.Collections;
using UnityEngine;

	
public class NeedyTenSeconds : MonoBehaviour
{	

    public KMAudio Audio;

	public int num1;
	public int num2;
	public int num3;
	public int num4;
	public int num5;
	public int num6;
	
	public KMSelectable Counters1;
	public KMSelectable Counters2;
	public KMSelectable Counters3;
	public KMSelectable Counters4;
	public KMSelectable Counters5;
	public KMSelectable Counters6;
	
	public TextMesh Counter1;
	public TextMesh Counter2;
	public TextMesh Counter3;
	public TextMesh Counter4;
	public TextMesh Counter5;
	public TextMesh Counter6;
	
	protected bool isNeedyActivated = false;
	
    void Awake()
    {
        GetComponent<KMNeedyModule>().OnNeedyActivation += OnNeedyActivation;
        GetComponent<KMNeedyModule>().OnNeedyDeactivation += OnNeedyDeactivation;
        GetComponent<KMNeedyModule>().OnTimerExpired += OnTimerExpired;
    }
	
	void Update ()
		{
	if (num1==0)
	{
		Counters1.OnInteract = FailHandlePress;
	}
	else
	{
		Counters1.OnInteract = HandlePress1;
	}
	if (num2==0)
	{
		Counters2.OnInteract = FailHandlePress;
	}
	else
	{
		Counters2.OnInteract = HandlePress2;
	}
	if (num3==0)
	{
		Counters3.OnInteract = FailHandlePress;
	}
	else
	{
		Counters3.OnInteract = HandlePress3;
	}
	if (num4==0)
	{
		Counters4.OnInteract = FailHandlePress;
	}
	else
	{
		Counters4.OnInteract = HandlePress4;
	}
	if (num5==0)
	{
		Counters5.OnInteract = FailHandlePress;
	}
	else
	{
		Counters5.OnInteract = HandlePress5;
	}
	if (num6==0)
	{
		Counters6.OnInteract = FailHandlePress;
	}
	else
	{
		Counters6.OnInteract = HandlePress6;
	}
		}
	
	protected bool FailHandlePress()
	{
		return false;
	}
	
	protected bool HandlePress1()
	{
		if (num1 < 10)
		{
		num1 = num1 + 1;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		Counters1.AddInteractionPunch();
		Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Counters1.transform);
		}
		return false;
	}
	
	protected bool HandlePress2()
	{
		if (num2 < 10)
		{
		num2 = num2 + 1;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		Counters2.AddInteractionPunch();
		Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Counters2.transform);
		}
		return false;
	}
	
	protected bool HandlePress3()
	{
		if (num3 < 10)
		{
		num3 = num3 + 1;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		Counters3.AddInteractionPunch();
		Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Counters3.transform);
		}
		return false;
	}
	
	protected bool HandlePress4()
	{
		if (num4 < 10)
		{
		num4 = num4 + 1;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		Counters4.AddInteractionPunch();
		Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Counters4.transform);
		}
		return false;
	}
	
	protected bool HandlePress5()
	{
		if (num5 < 10)
		{
		num5 = num5 + 1;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		Counters5.AddInteractionPunch();
		Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Counters5.transform);
		}
		return false;
	}
	
	protected bool HandlePress6()
	{
		if (num6 < 10)
		{
		num6 = num6 + 1;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		Counters6.AddInteractionPunch();
		Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Counters6.transform);
		}
		return false;
	}

    protected void OnNeedyActivation()
    {
		isNeedyActivated = true;
		num1 = 11;
		num2 = 11;
		num3 = 11;
		num4 = 11;
		num5 = 11;
		num6 = 11;
		Counter1.text = num1.ToString();
		Counter2.text = num2.ToString();
		Counter3.text = num3.ToString();
		Counter4.text = num4.ToString();
		Counter5.text = num5.ToString();
		Counter6.text = num6.ToString();
		StartCoroutine(loop());
    }

	private IEnumerator loop()
	{
		while (isNeedyActivated)
		{
			if (num1 <=0)
			{
				Counters1.OnInteract = FailHandlePress;
			}
			else
			{
			num1 = num1 - 1;
			}
			if (num2 <=0)
			{
				Counters2.OnInteract = FailHandlePress;
			}
			else
			{
			num2 = num2 - 1;
			}
			if (num3 <=0)
			{
				Counters3.OnInteract = FailHandlePress;
			}
			else
			{
			num3 = num3 - 1;
			}
			if (num4 <=0)
			{
				Counters4.OnInteract = FailHandlePress;
			}
			else
			{
			num4 = num4 - 1;
			}
			if (num5 <=0)
			{
				Counters5.OnInteract = FailHandlePress;
			}
			else
			{
			num5 = num5 - 1;
			}
			if (num6 <=0)
			{
				Counters6.OnInteract = FailHandlePress;
			}
			else
			{
			num6 = num6 - 1;
			}
			Counter1.text = num1.ToString();
			Counter2.text = num2.ToString();
			Counter3.text = num3.ToString();
			Counter4.text = num4.ToString();
			Counter5.text = num5.ToString();
			Counter6.text = num6.ToString();
			if (num1 == 0 & num2 == 0 & num3 == 0 & num4 == 0 & num5 == 0 & num6 == 0)
			{
			GetComponent<KMNeedyModule>().OnStrike();
            GetComponent<KMNeedyModule>().OnPass();
			isNeedyActivated = false;
			Counter1.text = "0";
			Counter2.text = "0";
			Counter3.text = "0";
			Counter4.text = "0";
			Counter5.text = "0";
			Counter6.text = "0";
			Counters1.OnInteract = FailHandlePress;
			Counters2.OnInteract = FailHandlePress;
			Counters3.OnInteract = FailHandlePress;
			Counters4.OnInteract = FailHandlePress;
			Counters5.OnInteract = FailHandlePress;
			Counters6.OnInteract = FailHandlePress;
			}
			yield return new WaitForSeconds(0.75f);
		}
	}

    protected void OnNeedyDeactivation()
    {
		isNeedyActivated = false;
		Counter1.text = "0";
		Counter2.text = "0";
		Counter3.text = "0";
		Counter4.text = "0";
		Counter5.text = "0";
		Counter6.text = "0";
		num1 = 0;
		num2 = 0;
		num3 = 0;
		num4 = 0;
		num5 = 0;
		num6 = 0;
		Counters1.OnInteract = FailHandlePress;
		Counters2.OnInteract = FailHandlePress;
		Counters3.OnInteract = FailHandlePress;
		Counters4.OnInteract = FailHandlePress;
		Counters5.OnInteract = FailHandlePress;
		Counters6.OnInteract = FailHandlePress;
    }

    protected void OnTimerExpired()
    {
		isNeedyActivated = false;
		Counter1.text = "0";
		Counter2.text = "0";
		Counter3.text = "0";
		Counter4.text = "0";
		Counter5.text = "0";
		Counter6.text = "0";
		num1 = 0;
		num2 = 0;
		num3 = 0;
		num4 = 0;
		num5 = 0;
		num6 = 0;
		Counters1.OnInteract = FailHandlePress;
		Counters2.OnInteract = FailHandlePress;
		Counters3.OnInteract = FailHandlePress;
		Counters4.OnInteract = FailHandlePress;
		Counters5.OnInteract = FailHandlePress;
		Counters6.OnInteract = FailHandlePress;
    }
}