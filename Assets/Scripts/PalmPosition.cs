using UnityEngine;
using System.Collections;
using Leap;

public class PalmPosition : MonoBehaviour {
	
	Controller controller;
	Vector3 position;
	Vector3 handPosition;
	
	// Use this for initialization
	void Start () {
		controller = new Controller();
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame();
		HandList hands = frame.Hands;
		Hand Hand = hands[0];
		if (Hand.IsValid) {
			handPosition = Hand.PalmPosition.ToUnityScaled()*20; 
			position = new Vector3(handPosition.x, handPosition.y, handPosition.z - 2);
			//rotation = Hand.Fingers[1].Direction.ToUnity();
			//Debug.Log(Hand.Fingers[1].TipPosition.ToUnityScaled());
			this.transform.position = position;
			this.transform.forward = new Vector3(0,0,1);
			
		}
		
	}
}
