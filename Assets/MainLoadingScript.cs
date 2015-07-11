using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainLoadingScript : MonoBehaviour {

	private AsyncOperation async;
	private GameObject progress;

	// Use this for initialization
	void Start () {

		progress = GameObject.Find ("Progress");
		async = Application.LoadLevelAsync ("Game");

	}
	
	// Update is called once per frame
	void Update () {
	
		if (!async.isDone) {
			progress.GetComponent<Text>().text = async.progress*100 + "%";
		}

	}
}
