using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.GetComponent<Transform> ().eulerAngles = this.GetComponent<Transform> ().eulerAngles + new Vector3(0f, 1f, 0f);
	
	}
}
