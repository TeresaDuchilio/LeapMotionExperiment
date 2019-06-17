using UnityEngine;
using System.Collections;

public class DontRotateWithParent : MonoBehaviour {
	
	GameObject Parent;

	void Start(){
		Parent = this.gameObject.transform.parent.gameObject;
	}

	void Update()
	{
		transform.localRotation = Quaternion.Inverse (Parent.transform.rotation);
	}
}

