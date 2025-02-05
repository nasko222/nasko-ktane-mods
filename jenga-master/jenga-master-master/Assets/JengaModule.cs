using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class JengaModule : MonoBehaviour
{
    public AudioClip JengaClick;
    public KMAudio Audio;
    public KMBombModule BombModule;
    public KMSelectable[] JengaPiece;
    public GameObject[] JengaSticker1;
    public GameObject[] JengaSticker2;
    public GameObject[] TheJengaPiece;
    public Sprite[] Characters;
    public int correct = 0;
    private static int moduleIdCounter = 1;
    private int moduleId;
    public List<KMSelectable> correctPieces;
    private bool animating;
    private readonly string TwitchHelpMessage = "!{0} side <pos> [Views the specified side of the tower] | !{0} pullout <row> <pos> (<row> <pos>)... [Pullout the specified piece(s)] | Valid side positions are front(f), bottom(b), back(ba), top(t), left(l), and right(r) | Valid rows are 1-10 with 1 being topmost, positions of pieces depend on which side of the tower they are on";
    public GameObject JengaPiecesObject;

    void Awake()
    {
	    JengaPiecesObject = transform.GetChild(0).gameObject;
	    
        AssignRandomSprites(JengaSticker1, 0, 10);
        AssignRandomSprites(JengaSticker2, 10, 20);
        
        for (int i = 0; i < JengaPiece.Length; i++)
        {
            int index = i; // Avoid closure issues
            JengaPiece[i].OnInteract += () => JengaCombinations(index);
        }

        CountCorrectPieces();
    }

    protected bool AssignRandomSprites(GameObject[] stickers, int start, int end)
    {
	    foreach (var t in stickers) t.GetComponent<SpriteRenderer>().sprite = Characters[Random.Range(start, end)];
	    return false;
    }

    protected bool CountCorrectPieces()
    {
        Debug.LogFormat("[Jenga #{0}] Rows of pieces are referenced in this log where row 1 is the topmost row and row 10 is bottommost", moduleId);
        int num = 0;
        int[,] validPairs = {
            { 0, 10 }, { 3, 10 }, { 5, 10 }, { 6, 10 }, { 8, 10 }, { 0, 11 }, { 1, 11 }, { 4, 11 }, { 5, 11 },
            { 6, 11 }, { 8, 11 }, { 3, 12 }, { 7, 12 }, { 8, 12 }, { 9, 12 }, { 0, 13 }, { 1, 13 }, { 2, 13 },
            { 5, 13 }, { 6, 13 }, { 8, 13 }, { 0, 14 }, { 4, 14 }, { 7, 14 }, { 2, 15 }, { 6, 15 }, { 7, 15 },
            { 8, 15 }, { 0, 16 }, { 1, 16 }, { 2, 16 }, { 3, 16 }, { 5, 16 }, { 7, 16 }, { 9, 16 }, { 4, 17 },
            { 9, 17 }, { 0, 18 }, { 2, 18 }, { 5, 18 }, { 6, 18 }, { 7, 18 }, { 9, 18 }, { 0, 19 }, { 3, 19 },
            { 5, 19 }, { 6, 19 }, { 7, 19 }, { 8, 19 }, { 9, 19 }
        };

        for (int i = 0; i < JengaPiece.Length; i++)
        {
            Sprite sprite1 = JengaSticker1[i].GetComponent<SpriteRenderer>().sprite;
            Sprite sprite2 = JengaSticker2[i].GetComponent<SpriteRenderer>().sprite;

            for (int j = 0; j < validPairs.GetLength(0); j++)
            {
                if (sprite1 == Characters[validPairs[j, 0]] && sprite2 == Characters[validPairs[j, 1]])
                {
                    correct++;
                    break;
                }
            }
            
            string[] pieceDescriptions =
            {
	            "Row 10 Front/Bottom Side Piece",
	            "Row 10 Back/Top Side Piece",
	            "Row 9 Left Side Piece",
	            "Row 9 Right Side Piece",
	            "Row 8 Front/Bottom Side Piece",
	            "Row 8 Back/Top Side Piece",
	            "Row 7 Left Side Piece",
	            "Row 7 Right Side Piece",
	            "Row 6 Front/Bottom Side Piece",
	            "Row 6 Back/Top Side Piece",
	            "Row 5 Left Side Piece",
	            "Row 5 Right Side Piece",
	            "Row 4 Front/Bottom Side Piece",
	            "Row 4 Back/Top Side Piece",
	            "Row 3 Left Side Piece",
	            "Row 3 Right Side Piece",
	            "Row 2 Front/Bottom Side Piece",
	            "Row 2 Back/Top Side Piece",
	            "Row 1 Left Side Piece",
	            "Row 1 Right Side Piece"
            };

            string action;
            if (correct > num)
            {
	            correctPieces.Add(JengaPiece[i]);
	            num = correct;
	            action = "Pullout";
            }
            else action = "Do Not Pullout";
            Debug.LogFormat("[Jenga #{0}] {1}: {2}", moduleId, pieceDescriptions[i], action);

        }
        return false;
    }

    protected bool JengaCombinations(int index)
    {
        Sprite sprite1 = JengaSticker1[index].GetComponent<SpriteRenderer>().sprite;
        Sprite sprite2 = JengaSticker2[index].GetComponent<SpriteRenderer>().sprite;

        int[,] correctPairs = { { 0, 10 }, { 3, 10 }, { 5, 10 }, { 6, 10 }, { 8, 10 }, { 0, 11 }, { 1, 11 },
            { 4, 11 }, { 5, 11 }, { 6, 11 }, { 8, 11 }, { 3, 12 }, { 7, 12 }, { 8, 12 }, { 9, 12 }, { 0, 13 },
            { 1, 13 }, { 2, 13 }, { 5, 13 }, { 6, 13 }, { 8, 13 }, { 0, 14 }, { 4, 14 }, { 7, 14 }, { 2, 15 },
            { 6, 15 }, { 7, 15 }, { 8, 15 }, { 0, 16 }, { 1, 16 }, { 2, 16 }, { 3, 16 }, { 5, 16 }, { 7, 16 },
            { 9, 16 }, { 4, 17 }, { 9, 17 }, { 0, 18 }, { 2, 18 }, { 5, 18 }, { 6, 18 }, { 7, 18 }, { 9, 18 },
            { 0, 19 }, { 3, 19 }, { 5, 19 }, { 6, 19 }, { 7, 19 }, { 8, 19 }, { 9, 19 }
        };

        int[,] failPairs = { { 1, 10 }, { 2, 10 }, { 4, 10 }, { 7, 10 }, { 9, 10 }, { 2, 11 }, { 3, 11 }, { 7, 11 },
            { 9, 11 }, { 0, 12 }, { 1, 12 }, { 2, 12 }, { 4, 12 }, { 5, 12 }, { 6, 12 }, { 0, 13 }, { 3, 13 },
            { 4, 13 }, { 7, 13 }, { 9, 13 }, { 1, 14 }, { 2, 14 }, { 3, 14 }, { 5, 14 }, { 6, 14 }, { 8, 14 },
            { 9, 14 }
        };

        for (int i = 0; i < correctPairs.GetLength(0); i++)
        {
            if (sprite1 == Characters[correctPairs[i, 0]] && sprite2 == Characters[correctPairs[i, 1]])
            {
                correct--;
                break;
            }
        }

        for (int i = 0; i < failPairs.GetLength(0); i++)
        {
            if (sprite1 == Characters[failPairs[i, 0]] && sprite2 == Characters[failPairs[i, 1]])
            {
                ModuleFail();
                return false;
            }
        }


        TheJengaPiece[index].SetActive(false);
        Audio.PlaySoundAtTransform(JengaClick.name, transform);
        if (correct <= 0) ModuleCompleted();
        return false;
    }

    protected bool ModuleFail()
    {
        BombModule.HandleStrike();
        return false;
    }

    protected bool ModuleCompleted()
    {
        BombModule.HandlePass();
        return false;
    }
    
    private bool prmsAreValid(string[] prms)
    {
	    string[] array = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
	    string[] array2 = {
		    "back", "ba", "front", "f", "bottom", "b", "top", "t", "right", "r",
		    "left", "l"
	    };
	    for (int i = 1; i < prms.Length; i += 2)
	    {
		    if (!array.Contains(prms[i]))
		    {
			    return false;
		    }
		    int num = 0;
		    int.TryParse(prms[i], out num);
		    if (num % 2 == 1)
		    {
			    if (prms[i + 1].EqualsIgnoreCase(array2[0]) || prms[i + 1].EqualsIgnoreCase(array2[1]) || prms[i + 1].EqualsIgnoreCase(array2[2]) || prms[i + 1].EqualsIgnoreCase(array2[3]) || prms[i + 1].EqualsIgnoreCase(array2[4]) || prms[i + 1].EqualsIgnoreCase(array2[5]) || prms[i + 1].EqualsIgnoreCase(array2[6]) || prms[i + 1].EqualsIgnoreCase(array2[7]))
			    {
				    return false;
			    }
		    }
		    else if (num % 2 == 0 && (prms[i + 1].EqualsIgnoreCase(array2[8]) || prms[i + 1].EqualsIgnoreCase(array2[9]) || prms[i + 1].EqualsIgnoreCase(array2[10]) || prms[i + 1].EqualsIgnoreCase(array2[11])))
		    {
			    return false;
		    }
	    }
	    return true;
    }

	private IEnumerator ProcessTwitchCommand(string command)
	{
		string[] parameters = command.Split(' ');
		if (Regex.IsMatch(parameters[0], "^\\s*side\\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			if (animating)
			{
				yield return "sendtochaterror Cannot view another side while a side is being viewed!";
				yield break;
			}
        
			if (parameters.Length == 2)
			{
				Dictionary<string, IEnumerator> sideRotations = new Dictionary<string, IEnumerator>
				{
					{ "front", RotateSide1() }, { "f", RotateSide1() },
					{ "bottom", RotateSide1() }, { "b", RotateSide1() },
					{ "back", RotateSide2() }, { "ba", RotateSide2() },
					{ "top", RotateSide2() }, { "t", RotateSide2() },
					{ "right", RotateSide3() }, { "r", RotateSide3() },
					{ "left", RotateSide4() }, { "l", RotateSide4() }
				};
            
				IEnumerator rotation;
				if (sideRotations.TryGetValue(parameters[1].ToLower(), out rotation))
				{
					yield return null;
					animating = true;
					StartCoroutine(rotation);
					while (animating)
					{
						yield return "trycancel";
					}
				}
			}
			yield break;
		}
    
		if (!Regex.IsMatch(parameters[0], "^\\s*pullout\\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)) yield break;
    
		if (animating)
		{
			yield return "sendtochaterror Cannot interact with pieces while a side is being viewed!";
			yield break;
		}
    
		if (parameters.Length >= 3 && parameters.Length % 2 == 1 && prmsAreValid(parameters))
		{
			yield return null;
			Dictionary<string, int> pieceMap = new Dictionary<string, int>
			{
				{ "1l", 18 }, { "1r", 19 }, { "2ba", 17 }, { "2t", 17 }, { "2f", 16 }, { "2b", 16 },
				{ "3l", 14 }, { "3r", 15 }, { "4ba", 13 }, { "4t", 13 }, { "4f", 12 }, { "4b", 12 },
				{ "5l", 10 }, { "5r", 11 }, { "6ba", 9 }, { "6t", 9 }, { "6f", 8 }, { "6b", 8 },
				{ "7l", 6 }, { "7r", 7 }, { "8ba", 5 }, { "8t", 5 }, { "8f", 4 }, { "8b", 4 },
				{ "9l", 2 }, { "9r", 3 }, { "10ba", 1 }, { "10t", 1 }, { "10f", 0 }, { "10b", 0 }
			};
        
			for (int i = 1; i < parameters.Length; i += 2)
			{
				string key = parameters[i] + parameters[i + 1][0].ToString().ToLower();
				int pieceIndex;
				if (pieceMap.TryGetValue(key, out pieceIndex))
				{
					JengaPiece[pieceIndex].OnInteract.Invoke();
					yield return new WaitForSeconds(0.2f);
				}
			}
		}
	}
	private IEnumerator TwitchHandleForcedSolve()
	{
		for (int i = 0; i < this.correctPieces.Count<KMSelectable>(); i++)
		{
			this.correctPieces.ElementAt(i).OnInteract.Invoke();
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}
	private IEnumerator RotateSide1()
	{
		for (int movement = 0; movement != 50; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * 0.001f;
		}
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		yield return new WaitForSeconds(4f);
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(-0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int movement = 0; movement != 50; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * -0.001f;
		}
		this.animating = false;
		yield break;
	}
	private IEnumerator RotateSide2()
	{
		for (int movement = 0; movement != 62; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * 0.001f;
		}
		for (int rotation = 0; rotation != 360; rotation++)
		{
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0f, 0.5f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		yield return new WaitForSeconds(4f);
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(-0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int rotation = 0; rotation != 360; rotation++)
		{
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0f, -0.5f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int movement = 0; movement != 62; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * -0.001f;
		}
		this.animating = false;
		yield break;
	}
	private IEnumerator RotateSide3()
	{
		for (int movement = 0; movement != 62; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * 0.001f;
		}
		for (int rotation = 0; rotation != 180; rotation++)
		{
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0f, 0.5f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		yield return new WaitForSeconds(4f);
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(-0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int rotation = 0; rotation != 180; rotation++)
		{
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0f, -0.5f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int movement = 0; movement != 62; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * -0.001f;
		}
		this.animating = false;
		yield break;
	}
	private IEnumerator RotateSide4()
	{
		for (int movement = 0; movement != 62; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * 0.001f;
		}
		for (int rotation = 0; rotation != 180; rotation++)
		{
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0f, -0.5f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		yield return new WaitForSeconds(4f);
		for (int rotation = 0; rotation != 100; rotation++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(-0.5f, 0f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int rotation = 0; rotation != 180; rotation++)
		{
			this.JengaPiecesObject.transform.localRotation = Quaternion.Euler(0f, 0.5f, 0f) * this.JengaPiecesObject.transform.localRotation;
		}
		for (int movement = 0; movement != 62; movement++)
		{
			yield return new WaitForSeconds(0.01f);
			this.JengaPiecesObject.transform.localPosition = this.JengaPiecesObject.transform.localPosition + Vector3.back * -0.001f;
		}
		this.animating = false;
		yield break;
	}
}
