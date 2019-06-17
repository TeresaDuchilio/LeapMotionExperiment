using UnityEngine;
using System.Collections;

public class PlaySoundOnCollision : MonoBehaviour {

	public AudioSource audio;

	GameObject Links;
	GameObject Rechts;
	int collisions;
	
	void Update(){
		Links = GameObject.FindGameObjectWithTag ("Left");
		Rechts = GameObject.FindGameObjectWithTag ("Right");
		if (!Rechts && !Links) {
			collisions = 0;
		}
		if (collisions <= 0) {
			audio.mute = true;
			//Debug.Log (collisions);
			collisions=0;
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		collisions++;
		audio.mute = false;
		//Debug.Log("collision");
	}
	
	void OnTriggerExit (Collider col)
	{
		collisions--;
		if (collisions <= 0) {
			audio.mute = true;
		}
		
	}
}
