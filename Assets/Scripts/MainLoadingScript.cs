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

		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			GlobalData.connectionStatus = -1;
		} else {
			PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
				// enables saving game progress.
				.EnableSavedGames()
					.Build();
			
			PlayGamesPlatform.InitializeInstance(config);
			// Activate the Google Play Games platform
			PlayGamesPlatform.Activate();
			
			// authenticate user:
			AuthenticateLoop ();
		}



		StartCoroutine (LoadScreen ());

	}

	void AuthenticateLoop() {

		Social.localUser.Authenticate (success => {
			if (success) {
				GlobalData.connectionStatus = 1;
			}
			else
				AuthenticateLoop();
		});

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
			GlobalData.OpenSavedGame("TinyGod_3");
			GlobalData.connectionStatus = 2;
		}

		if ((GlobalData.connectionStatus <= -1 || GlobalData.connectionStatus == 5) && loadProgress == 100) {

			/*
			if (GlobalData.connectionStatus <= -1) {
				GlobalData.thisState.love = GlobalData.connectionStatus;
			}
			*/

			scene1.SetActive (true);
			if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
				// NO HACEMOS NADA
			} else {
				Soomla.Store.SoomlaStore.Initialize (new SoomlaAssets());
			}
			//GameObject.Find ("Scene0").SetActive (false);
			GameObject.Destroy(GameObject.Find ("Scene0"));

		}


	}


}
