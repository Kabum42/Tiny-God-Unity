using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainLoadingScript : MonoBehaviour {

	private int loadProgress = 0;
	private AsyncOperation async;
	public GameObject progress;

	// Use this for initialization
	void Start () {

		StartCoroutine (LoadScreen ());

	}

	IEnumerator LoadScreen() {

		async = Application.LoadLevelAsync ("Game");

		while (!async.isDone) {

			loadProgress = (int)(async.progress*100);
			progress.GetComponent<TextMesh>().text = loadProgress + "%";

			yield return null;

		}



	}


}
