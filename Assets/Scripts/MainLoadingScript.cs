using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi.SavedGame;
using System;

public class MainLoadingScript : MonoBehaviour {

	private int loadProgress = 0;
	private AsyncOperation async;
	public GameObject progress;
	public GameObject status;
	private GameObject scene1;

	// Use this for initialization
	void Start () {

		if (!GlobalData.started) { GlobalData.Start(); }

		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
		// enables saving game progress.
		.EnableSavedGames()
		.Build();
		
		PlayGamesPlatform.InitializeInstance(config);
		// Activate the Google Play Games platform
		PlayGamesPlatform.Activate();

		// authenticate user:
		Social.localUser.Authenticate (success => {
			if (success) {
				GlobalData.connectionStatus = 1;
			}
			else
				GlobalData.connectionStatus = -1;
		});

		StartCoroutine (LoadScreen ());

	}

	IEnumerator LoadScreen() {

		//async = Application.LoadLevelAsync ("Game");
		async = Application.LoadLevelAdditiveAsync ("Game");

		while (!async.isDone) {

			loadProgress = (int)(async.progress*100);
			progress.GetComponent<TextMesh>().text = loadProgress + "%";

			yield return null;

		}

		scene1 = GameObject.Find ("Scene1");
		scene1.SetActive (false);
		loadProgress = 100;

		progress.GetComponent<TextMesh>().text = loadProgress + "%";

	}

	void Update () {

		status.GetComponent<TextMesh>().text = ""+GlobalData.connectionStatus;

		if ((Social.localUser.authenticated || PlayGamesPlatform.Instance.IsAuthenticated()) && GlobalData.connectionStatus == 0) {
			GlobalData.connectionStatus = 1;
		}

		if (GlobalData.connectionStatus == 1) {
			GlobalData.OpenSavedGame("TinyGod");
			GlobalData.connectionStatus = 2;
		}


		if ((GlobalData.connectionStatus <= -1 || GlobalData.connectionStatus == 5) && loadProgress == 100) {

			if (GlobalData.connectionStatus <= -1) {
				GlobalData.thisState.love = GlobalData.connectionStatus;
			}

			scene1.SetActive (true);
			//GameObject.Find ("Scene0").SetActive (false);
			GameObject.Destroy(GameObject.Find ("Scene0"));

		}


	}


}
