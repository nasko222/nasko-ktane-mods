using System.Collections;
using System.Collections.Generic;
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
	
	void Awake ()
	{
		for (int i = 0; i < JengaSticker1.Length; i++)
		{
			JengaSticker1[i].GetComponent<SpriteRenderer>().sprite = Characters[Random.Range(0, 10)];
		}
		
		for (int i = 0; i < JengaSticker2.Length; i++)
		{
			JengaSticker2[i].GetComponent<SpriteRenderer>().sprite = Characters[Random.Range(10, 20)];
		}
		JengaPiece[0].OnInteract += JengaCombinations0;
		JengaPiece[1].OnInteract += JengaCombinations1;
		JengaPiece[2].OnInteract += JengaCombinations2;
		JengaPiece[3].OnInteract += JengaCombinations3;
		JengaPiece[4].OnInteract += JengaCombinations4;
		JengaPiece[5].OnInteract += JengaCombinations5;
		JengaPiece[6].OnInteract += JengaCombinations6;
		JengaPiece[7].OnInteract += JengaCombinations7;
		JengaPiece[8].OnInteract += JengaCombinations8;
		JengaPiece[9].OnInteract += JengaCombinations9;
		JengaPiece[10].OnInteract += JengaCombinations10;
		JengaPiece[11].OnInteract += JengaCombinations11;
		JengaPiece[12].OnInteract += JengaCombinations12;
		JengaPiece[13].OnInteract += JengaCombinations13;
		JengaPiece[14].OnInteract += JengaCombinations14;
		JengaPiece[15].OnInteract += JengaCombinations15;
		JengaPiece[16].OnInteract += JengaCombinations16;
		JengaPiece[17].OnInteract += JengaCombinations17;
		JengaPiece[18].OnInteract += JengaCombinations18;
		JengaPiece[19].OnInteract += JengaCombinations19;
		
		for (int i = 0; i < JengaPiece.Length; i++)
		{
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		if (JengaSticker1[i].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[i].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct++;}
		}
		
		Debug.Log(correct + " correct pieces");
	}
	
	protected bool JengaCombinations0()
	{
		if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[0].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[0].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[0].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations1()
	{
		if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[1].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[1].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[1].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations2()
	{
		if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[2].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[2].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[2].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
		protected bool JengaCombinations3()
	{
		if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[3].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[3].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[3].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations4()
	{
		if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[4].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[4].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[4].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations5()
	{
		if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[5].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[5].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[5].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
		protected bool JengaCombinations6()
	{
		if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[6].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[6].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[6].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations7()
	{
		if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[7].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[7].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[7].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations8()
	{
		if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[8].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[8].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[8].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
		protected bool JengaCombinations9()
	{
		if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[9].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[9].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[9].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations10()
	{
		if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[10].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[10].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[10].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations11()
	{
		if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[11].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[11].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[11].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
		protected bool JengaCombinations12()
	{
		if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[12].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[12].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[12].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations13()
	{
		if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[13].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[13].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[13].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations14()
	{
		if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[14].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[14].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[14].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
		protected bool JengaCombinations15()
	{
		if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[15].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[15].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[15].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations16()
	{
		if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[16].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[16].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[16].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations17()
	{
		if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[17].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[17].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[17].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
		protected bool JengaCombinations18()
	{
		if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[18].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[18].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[18].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
		return false;
	}
	
	protected bool JengaCombinations19()
	{
		if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[10]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[11]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[12]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[13]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[14]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[15]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[16]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[17]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[18]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[0] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[1] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[2] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[3] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[4] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {ModuleFail();}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[5] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[6] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[7] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[8] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		else if (JengaSticker1[19].GetComponent<SpriteRenderer>().sprite == Characters[9] && JengaSticker2[19].GetComponent<SpriteRenderer>().sprite == Characters[19]) {correct--;}
		TheJengaPiece[19].SetActive(false);
		Audio.PlaySoundAtTransform(JengaClick.name, transform);
		if (correct <= 0){ModuleCompleted();}
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
		JengaPiece[0].OnInteract = Nothing;
		JengaPiece[1].OnInteract = Nothing;
		JengaPiece[2].OnInteract = Nothing;
		JengaPiece[3].OnInteract = Nothing;
		JengaPiece[4].OnInteract = Nothing;
		JengaPiece[5].OnInteract = Nothing;
		JengaPiece[6].OnInteract = Nothing;
		JengaPiece[7].OnInteract = Nothing;
		JengaPiece[8].OnInteract = Nothing;
		JengaPiece[9].OnInteract = Nothing;
		JengaPiece[10].OnInteract = Nothing;
		JengaPiece[11].OnInteract = Nothing;
		JengaPiece[12].OnInteract = Nothing;
		JengaPiece[13].OnInteract = Nothing;
		JengaPiece[14].OnInteract = Nothing;
		JengaPiece[15].OnInteract = Nothing;
		JengaPiece[16].OnInteract = Nothing;
		JengaPiece[17].OnInteract = Nothing;
		JengaPiece[18].OnInteract = Nothing;
		JengaPiece[19].OnInteract = Nothing;
		return false;
	}
	
	protected bool Nothing(){return false;}
}
