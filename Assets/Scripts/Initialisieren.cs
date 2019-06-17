using UnityEngine;
using System.Collections;

public class Initialisieren : MonoBehaviour {


	//public string akustisch;
	//public string visuell;
	GameObject[] Visuell;
	GameObject[] Akustisch;
	int typ;
	int anzahl;

	void Disable(GameObject[] Target, int anzahl){
		for(int i=0; i < anzahl; i++){
			Target[i].SetActive(false);
		}
	}
	
	void Start () {

		typ = PlayerPrefs.GetInt ("Typ");

		Akustisch = GameObject.FindGameObjectsWithTag ("Akustisch");
		anzahl = Akustisch.GetLength(0);

		if (typ == 1) {
			Disable(Akustisch,anzahl);
		} 

		else if (typ == 2) {
			Disable(Akustisch,anzahl);
		} 


	}

	void Update(){
		Visuell = GameObject.FindGameObjectsWithTag ("Visuell");
		anzahl = Visuell.GetLength (0);

		if (anzahl != 0) {//disable Visuell (nicht in Start wegen Eigenschaften von LeapMotion)
			if (typ == 1) {
				Disable (Visuell, anzahl);
			} 
		else if (typ == 3) {
			Disable(Visuell,anzahl);
		   }
		}
	}
}
