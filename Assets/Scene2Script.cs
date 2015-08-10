using UnityEngine;
using System.Collections;

public class Scene2Script : MonoBehaviour {

	public GameObject scene1;
	public GameObject sceneReward;

	// Use this for initialization
	void Start () {
	
		scene1 = GameObject.Find ("Scene1");
		sceneReward = GameObject.Find ("Scene1/Main Camera").GetComponent<MainScript>().sceneReward;

		if (scene1 != null) {
			scene1.SetActive (false);
		}

		if (sceneReward != null) {
			sceneReward.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {

		GlobalData.Update ();
	
	}
}
