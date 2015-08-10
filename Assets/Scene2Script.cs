using UnityEngine;
using System.Collections;

public class Scene2Script : MonoBehaviour {

	public GameObject scene1;

	// Use this for initialization
	void Start () {
	
		scene1 = GameObject.Find ("Scene1");
		if (scene1 != null) {
			scene1.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {

		GlobalData.Update ();
	
	}
}
