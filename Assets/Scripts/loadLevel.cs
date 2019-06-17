using UnityEngine;
using System.Collections;


public class loadLevel : MonoBehaviour {
	

	public void changeLevel(string level){
		Application.LoadLevel (level);
	}

	public void Auswahl(int auswahl){
		PlayerPrefs.SetInt ("Typ", auswahl);
		//Debug.Log(PlayerPrefs.GetInt("Typ"));
	}
}
