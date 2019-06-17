using UnityEngine;
using System.Collections;
using Leap;

public class ShowBezeichnung : MonoBehaviour {

	public GameObject Bezeichner;
	GameObject Links;
	GameObject Rechts;
	Controller controller;
	bool pointing;
	
	void Start(){
		Bezeichner.GetComponent<Canvas> ().enabled = false;
		controller = new Controller();
	}


	void Update(){

		Frame frame = controller.Frame();
		HandList hands = frame.Hands;
		Hand Hand = hands[0];
		
		if (Hand.IsValid) {
			
			int extended = 0;
			
			for (int i=0; i<=4; i++) {
				if (Hand.Fingers [i].IsExtended)
					extended++;
			}

			if(extended <=3)
				pointing = true;
			else
				pointing = false;

		} 
	}


	void OnTriggerEnter(Collider col)
	{
		//Debug.Log (col.name);
		if (pointing && col.name == "bone3") {
			Bezeichner.GetComponent<Canvas> ().enabled = true;
		}

	}
	
	void OnTriggerExit (Collider col)
	{
		if (col.name == "bone3") {
			Bezeichner.GetComponent<Canvas> ().enabled = false;
		}
		
	}
	
}
