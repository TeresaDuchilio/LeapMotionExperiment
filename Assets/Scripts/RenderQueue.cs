using UnityEngine;
using System.Collections;


public class RenderQueue : MonoBehaviour {
	public int zahl;
	Renderer rend;

	void Start() {
		rend = this.gameObject.GetComponent<Renderer>();
		rend.material.renderQueue += zahl;
		Debug.Log (this.gameObject.name);
		Debug.Log (rend.material.renderQueue);
	}
	

}
