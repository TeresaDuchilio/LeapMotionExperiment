using UnityEngine;
using System.Collections;
using Leap;

public class FingerPosition : MonoBehaviour {

	Controller controller;
	Vector3 position;
	Vector3 rotation;

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
			position = Hand.Fingers[1].TipPosition.ToUnityScaled()*20;
			rotation = Hand.Fingers[1].Direction.ToUnity();
			//Debug.Log(Hand.Fingers[1].TipPosition.ToUnityScaled());
			this.transform.position = position;
			this.transform.forward = rotation;

		}

	}
}
