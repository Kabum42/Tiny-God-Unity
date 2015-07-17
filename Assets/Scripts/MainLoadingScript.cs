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
	private GameObject scene1;
	private float connectionStatus = 0;

	// Use this for initialization
	void Start () {

		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
		// enables saving game progress.
		.EnableSavedGames()
		// registers a callback to handle game invitations received while the game is not running.
		//.WithInvitationDelegate(<callback method>)
		// registers a callback for turn based match notifications received while the
		// game is not running.
		//.WithMatchDelegate(<callback method>)
		.Build();
		
		PlayGamesPlatform.InitializeInstance(config);
		// recommended for debugging:
		PlayGamesPlatform.DebugLogEnabled = true;
		// Activate the Google Play Games platform
		PlayGamesPlatform.Activate();

		// authenticate user:
		Social.localUser.Authenticate (success => {
			if (success) {
				connectionStatus = 10;
			}
			else
				connectionStatus = -20;
		});


		if (!GlobalData.started) { GlobalData.Start(); }

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

		if (connectionStatus != 0 && loadProgress == 100) {

			GlobalData.love = connectionStatus;

			scene1.SetActive (true);
			GameObject.Find ("Scene0").SetActive (false);

		}


	}

	void OpenSavedGame(string filename) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
		                                                    ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
	}

	public void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game) {
		if (status == SavedGameRequestStatus.Success) {
			// handle reading or writing of saved game.
		} else {
			// handle error
		}
	}

	void SaveGame (ISavedGameMetadata game, byte[] savedData, TimeSpan totalPlaytime) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		
		SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder();
		builder = builder
			.WithUpdatedPlayedTime(totalPlaytime)
				.WithUpdatedDescription("Saved game at " + DateTime.Now.ToString());
		SavedGameMetadataUpdate updatedMetadata = builder.Build();
		savedGameClient.CommitUpdate(game, updatedMetadata, savedData, OnSavedGameWritten);
	}
	
	public void OnSavedGameWritten (SavedGameRequestStatus status, ISavedGameMetadata game) {
		if (status == SavedGameRequestStatus.Success) {
			// handle reading or writing of saved game.
		} else {
			// handle error
		}
	}

	void LoadGameData (ISavedGameMetadata game) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		savedGameClient.ReadBinaryData(game, OnSavedGameDataRead);
	}
	
	public void OnSavedGameDataRead (SavedGameRequestStatus status, byte[] data) {
		if (status == SavedGameRequestStatus.Success) {
			// handle processing the byte array data
		} else {
			// handle error
		}
	}


}
