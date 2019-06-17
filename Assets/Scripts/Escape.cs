using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour {

	public GameObject Menu;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Cancel")){
			Menu.SetActive(true);
		}
	}

	public void Ja(string level){
		this.GetComponent<loadLevel>().changeLevel (level);
	}

	public void Nein(){
		Menu.SetActive (false);
	}
}
