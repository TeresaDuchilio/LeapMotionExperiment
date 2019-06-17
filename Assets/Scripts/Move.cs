using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	//private Vector3 targetPos;
	// Use this for initialization
	void Start () {
		//targetPos = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Input.mousePosition;
		pos.z = 11f;
		pos.y = pos.y - 300f;
		transform.position = Camera.main.ScreenToWorldPoint(pos);

	}
}
