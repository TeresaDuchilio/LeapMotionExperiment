using UnityEngine;
using System.Collections;

public class ShowOnCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<MeshRenderer> ().enabled = false;
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Object") {
			this.gameObject.GetComponent<MeshRenderer> ().enabled = true;
			//Debug.Log ("collision");
		}
	}
	
	void OnTriggerExit (Collider col)
	{
		if (col.tag == "Object") {
			this.gameObject.GetComponent<MeshRenderer> ().enabled = false;
		}
	}
}
