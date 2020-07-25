using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingTableScript : MonoBehaviour {
	
	public KMSelectable[] CraftingPlace;
	public KMSelectable Stick;
	public KMSelectable Wood;
	public KMSelectable Cobblestone;
	public KMSelectable Iron;
	public KMSelectable Gold;
	public KMSelectable Diamond;
	public KMSelectable Reset;
	public GameObject MCTool;
	public Sprite[] MCTools;
	public KMAudio KMAudio;
	public GameObject[] Place;
	public Material StickMesh;
	public Material WoodMesh;
	public Material CobblestoneMesh;
	public Material IronMesh;
	public Material GoldMesh;
	public Material DiamondMesh;
	public Material DefaultMesh;
	
	private Material selected;
	
	int tool;
	int clicked;
	
	public MeshRenderer square0;
	public MeshRenderer square1;
	public MeshRenderer square2;
	public MeshRenderer square3;
	public MeshRenderer square4;
	public MeshRenderer square5;
	public MeshRenderer square6;
	public MeshRenderer square7;
	public MeshRenderer square8;

	void Start ()
	{
		tool = Random.Range(0, 37);
		MCTool.GetComponent<SpriteRenderer>().sprite = MCTools[tool];
		selected = StickMesh;
	}
	
	void Awake()
    {
        GetComponent<KMNeedyModule>().OnNeedyActivation += OnNeedyActivation;
        GetComponent<KMNeedyModule>().OnTimerExpired += OnTimerExpired;
		Stick.OnInteract += StickFunction;
		Wood.OnInteract += WoodFunction;
		Cobblestone.OnInteract += CobblestoneFunction;
		Iron.OnInteract += IronFunction;
		Gold.OnInteract += GoldFunction;
		Diamond.OnInteract += DiamondFunction;
		Reset.OnInteract = FailClicked;
		for(int i=0; i<CraftingPlace.Length; i++)
		{
		int j=i;
		CraftingPlace[i].OnInteract = delegate()
		{
        return FailClick(j);
		};
		}
    }
	
	protected void OnNeedyActivation()
    {
		Reset.OnInteract = ResetButtonFunction;
		tool = Random.Range(0, 37);
		MCTool.GetComponent<SpriteRenderer>().sprite = MCTools[tool];
		for(int i=0; i<CraftingPlace.Length; i++)
		{
		int j=i;
		CraftingPlace[i].OnInteract = delegate()
		{
        return Crafting(j);
		};
		}
    }

    protected void OnTimerExpired()
    {
		Debug.Log("tool " + tool);
		Debug.Log("place0 " + square0.sharedMaterial);
		Debug.Log("place1 " + square1.sharedMaterial);
		Debug.Log("place2 " + square2.sharedMaterial);
		Debug.Log("place3 " + square3.sharedMaterial);
		Debug.Log("place4 " + square4.sharedMaterial);
		Debug.Log("place5 " + square5.sharedMaterial);
		Debug.Log("place6 " + square6.sharedMaterial);
		Debug.Log("place7 " + square7.sharedMaterial);
		Debug.Log("place8 " + square8.sharedMaterial);
		
		if (tool == 0)
		{
		Debug.Log("Craft me a wooden axe");
		if (square0.sharedMaterial == WoodMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == WoodMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == WoodMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == WoodMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 1)
		{
		Debug.Log("Craft me a wooden hoe");
		if (square0.sharedMaterial == WoodMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == WoodMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 2)
		{
		Debug.Log("Craft me a wooden pickaxe");
		if (square0.sharedMaterial == WoodMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == WoodMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 3)
		{
		Debug.Log("Craft me a wooden shovel");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 4)
		{
		Debug.Log("Craft me a wooden sword");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == WoodMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == WoodMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 5)
		{
		Debug.Log("Craft me a stone axe");
		if (square0.sharedMaterial == CobblestoneMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == CobblestoneMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == CobblestoneMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == CobblestoneMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 6)
		{
		Debug.Log("Craft me a stone hoe");
		if (square0.sharedMaterial == CobblestoneMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == CobblestoneMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 7)
		{
		Debug.Log("Craft me a stone pickaxe");
		if (square0.sharedMaterial == CobblestoneMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == CobblestoneMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 8)
		{
		Debug.Log("Craft me a stone shovel");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 9)
		{
		Debug.Log("Craft me a stone sword");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == CobblestoneMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == CobblestoneMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 10)
		{
		Debug.Log("Craft me a iron axe");
		if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == IronMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == IronMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == IronMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 11)
		{
		Debug.Log("Craft me a iron hoe");
		if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == IronMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 12)
		{
		Debug.Log("Craft me a iron pickaxe");
		if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == IronMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 13)
		{
		Debug.Log("Craft me a iron shovel");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 14)
		{
		Debug.Log("Craft me a iron sword");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == IronMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 15)
		{
		Debug.Log("Craft me a golden axe");
		if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == GoldMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == GoldMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == GoldMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 16)
		{
		Debug.Log("Craft me a golden hoe");
		if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == GoldMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 17)
		{
		Debug.Log("Craft me a golden pickaxe");
		if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == GoldMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 18)
		{
		Debug.Log("Craft me a golden shovel");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 19)
		{
		Debug.Log("Craft me a golden sword");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == GoldMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 20)
		{
		Debug.Log("Craft me a diamond axe");
		if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DiamondMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DiamondMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 21)
		{
		Debug.Log("Craft me a diamond hoe");
		if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DiamondMesh &&
			square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 22)
		{
		Debug.Log("Craft me a diamond pickaxe");
		if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DiamondMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 23)
		{
		Debug.Log("Craft me a diamond shovel");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == StickMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 24)
		{
		Debug.Log("Craft me a diamond sword");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DefaultMesh && square4.sharedMaterial == DiamondMesh && square5.sharedMaterial == DefaultMesh &&
		square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == StickMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 25)
		{
		Debug.Log("Craft me a iron helmet");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == IronMesh && square4.sharedMaterial == IronMesh && square5.sharedMaterial == IronMesh &&
		square6.sharedMaterial == IronMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == IronMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == IronMesh &&
			square3.sharedMaterial == IronMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == IronMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 26)
		{
		Debug.Log("Craft me a iron chestplate");
		if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == IronMesh &&
		square3.sharedMaterial == IronMesh && square4.sharedMaterial == IronMesh && square5.sharedMaterial == IronMesh &&
		square6.sharedMaterial == IronMesh && square7.sharedMaterial == IronMesh && square8.sharedMaterial == IronMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 27)
		{
		Debug.Log("Craft me a iron leggings");
		if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == IronMesh && square2.sharedMaterial == IronMesh &&
		square3.sharedMaterial == IronMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == IronMesh &&
		square6.sharedMaterial == IronMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == IronMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 28)
		{
		Debug.Log("Craft me a iron boots");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == IronMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == IronMesh &&
		square6.sharedMaterial == IronMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == IronMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == IronMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == IronMesh &&
			square3.sharedMaterial == IronMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == IronMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 29)
		{
		Debug.Log("Craft me a golden helmet");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == GoldMesh && square4.sharedMaterial == GoldMesh && square5.sharedMaterial == GoldMesh &&
		square6.sharedMaterial == GoldMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == GoldMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == GoldMesh &&
			square3.sharedMaterial == GoldMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == GoldMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 30)
		{
		Debug.Log("Craft me a golden chestplate");
		if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == GoldMesh &&
		square3.sharedMaterial == GoldMesh && square4.sharedMaterial == GoldMesh && square5.sharedMaterial == GoldMesh &&
		square6.sharedMaterial == GoldMesh && square7.sharedMaterial == GoldMesh && square8.sharedMaterial == GoldMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 31)
		{
		Debug.Log("Craft me a golden leggings");
		if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == GoldMesh && square2.sharedMaterial == GoldMesh &&
		square3.sharedMaterial == GoldMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == GoldMesh &&
		square6.sharedMaterial == GoldMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == GoldMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 32)
		{
		Debug.Log("Craft me a golden boots");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == GoldMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == GoldMesh &&
		square6.sharedMaterial == GoldMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == GoldMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == GoldMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == GoldMesh &&
			square3.sharedMaterial == GoldMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == GoldMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 33)
		{
		Debug.Log("Craft me a diamond helmet");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == DiamondMesh && square5.sharedMaterial == DiamondMesh &&
		square6.sharedMaterial == DiamondMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DiamondMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DiamondMesh &&
			square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == DiamondMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 34)
		{
		Debug.Log("Craft me a diamond chestplate");
		if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DiamondMesh &&
		square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == DiamondMesh && square5.sharedMaterial == DiamondMesh &&
		square6.sharedMaterial == DiamondMesh && square7.sharedMaterial == DiamondMesh && square8.sharedMaterial == DiamondMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 35)
		{
		Debug.Log("Craft me a diamond leggings");
		if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DiamondMesh && square2.sharedMaterial == DiamondMesh &&
		square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == DiamondMesh &&
		square6.sharedMaterial == DiamondMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DiamondMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
		else if (tool == 36)
		{
		Debug.Log("Craft me a diamond boots");
		if (square0.sharedMaterial == DefaultMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DefaultMesh &&
		square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == DiamondMesh &&
		square6.sharedMaterial == DiamondMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DiamondMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
				
			}
			else if (square0.sharedMaterial == DiamondMesh && square1.sharedMaterial == DefaultMesh && square2.sharedMaterial == DiamondMesh &&
			square3.sharedMaterial == DiamondMesh && square4.sharedMaterial == DefaultMesh && square5.sharedMaterial == DiamondMesh &&
			square6.sharedMaterial == DefaultMesh && square7.sharedMaterial == DefaultMesh && square8.sharedMaterial == DefaultMesh)
			{
				GetComponent<KMNeedyModule>().OnPass();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
				
			}
			else
			{
				Reset.OnInteract = FailClicked;
				GetComponent<KMNeedyModule>().OnStrike();
				for(int i=0; i<CraftingPlace.Length; i++)
				{
				int j=i;
				CraftingPlace[i].OnInteract = delegate()
				{
				return FailClick(j);
				};
				}
				Reset.OnInteract = FailClicked;
				ResetFunction();
			}
		}
    }
	
	protected bool StickFunction()
    {
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Stick.transform);
		Stick.AddInteractionPunch();
		selected = StickMesh;
		return false;
    }
	
	protected bool WoodFunction()
    {
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Wood.transform);
		Wood.AddInteractionPunch();
		selected = WoodMesh;
        return false;
    }
	
	protected bool CobblestoneFunction()
    {
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Cobblestone.transform);
		Cobblestone.AddInteractionPunch();
		selected = CobblestoneMesh;
        return false;
    }
	
	protected bool IronFunction()
    {
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Iron.transform);
		Iron.AddInteractionPunch();
		selected = IronMesh;
        return false;
    }
	
	protected bool GoldFunction()
    {
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Gold.transform);
		Gold.AddInteractionPunch();
		selected = GoldMesh;
        return false;
    }
	
	protected bool DiamondFunction()
    {
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Diamond.transform);
		Diamond.AddInteractionPunch();
		selected = DiamondMesh;
        return false;
    }
	
	protected bool ResetFunction()
    {
		Place[0].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[1].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[2].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[3].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[4].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[5].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[6].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[7].GetComponent<MeshRenderer>().material = DefaultMesh;
		Place[8].GetComponent<MeshRenderer>().material = DefaultMesh;
		return false;
    }
	
	protected bool ResetButtonFunction()
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Reset.transform);
		Reset.AddInteractionPunch();
		ResetFunction();
		return false;
	}
	
	protected bool Crafting(int clicked)
	{
		KMAudio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Reset.transform);
		Reset.AddInteractionPunch();
		Place[clicked].GetComponent<MeshRenderer>().material = selected;
		return false;
	}
	
	protected bool FailClick(int clicked)
	{
		return false;
	}
	
	protected bool FailClicked()
	{
		return false;
	}
}
