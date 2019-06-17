using UnityEngine;
using System.Collections;
using Leap;

public class RotateObject : MonoBehaviour {

	GameObject Object;
	Controller controller;
	Vector3 velocity;
	Vector3 change;
	int count;

	// Use this for initialization
	void Start () {
		controller = new Controller();
	}
	
	// Update is called once per frame
	void Update () {
		Object = GameObject.FindGameObjectWithTag ("Object");

		Frame frame = controller.Frame();
		HandList hands = frame.Hands;
		Hand Hand = hands[0];

		if (Hand.IsValid) {

			count = 0;

			for(int i=0; i<=4; i++){
				if (Hand.Fingers[i].IsExtended)
					count++;
			}
			//Debug.Log(count);

			if (count >= 3){
				velocity = Hand.PalmVelocity.ToUnity();
				velocity *= 0.05f;
				change = new Vector3(velocity.y,velocity.x*-1,0f);
				Object.transform.Rotate(change, relativeTo:Space.World);
			}
		}
	}
}
