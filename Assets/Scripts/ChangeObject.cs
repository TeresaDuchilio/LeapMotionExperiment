using UnityEngine;
using System.Collections;

public class ChangeObject : MonoBehaviour {

	public GameObject Beispiel;
	public GameObject Lernphase;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Submit")){
			//Debug.Log("gedückt");
			if(Beispiel.activeSelf == true){
				Beispiel.SetActive(false);
				Lernphase.SetActive(true);
			}
			else{
				Lernphase.SetActive(false);
				Beispiel.SetActive(true);
			}
		}
	}
}
