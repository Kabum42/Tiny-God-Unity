using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi.SavedGame;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public static class GlobalData {
	
	public static bool started = false;

	public static float CAPA1_WIDTH_SCREEN = 20f;

	public static float connectionStatus = 0f;
	private static float defaultSaveCooldown = 20f;
	public static float saveCooldown = defaultSaveCooldown;
	public static ISavedGameMetadata thisGame;

	private static double timeThisSession = 0f;

	public static SaveState thisState; 
	

	
	public static void Start() {

		started = true;
		thisState = new SaveState ();

	}
	
	public static void Update() {

		if (connectionStatus == 5) {

			thisState.timePlayed += Time.deltaTime;
			
			saveCooldown -= Time.deltaTime;

			if (saveCooldown <= 0f) {

				TimeSpan timeSpan = TimeSpan.FromSeconds(thisState.timePlayed);

				byte[] myByteArray = SaveState.ToByteArray(thisState);
				
				SaveGame(thisGame, myByteArray, timeSpan);
				saveCooldown = defaultSaveCooldown;
				
			}

		}




	}

	public static void OpenSavedGame(string filename) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
		                                                    ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
	}
	
	public static void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game) {
		if (status == SavedGameRequestStatus.Success) {
			// handle reading or writing of saved game.
			connectionStatus = 3;
			thisGame = game;
			LoadGameData(thisGame);
		} else {
			// handle error
			connectionStatus = -2;
		}
	}
	
	public static void LoadGameData (ISavedGameMetadata game) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		savedGameClient.ReadBinaryData(game, OnSavedGameDataRead);
	}
	
	public static void OnSavedGameDataRead (SavedGameRequestStatus status, byte[] data) {
		if (status == SavedGameRequestStatus.Success) {
			// handle processing the byte array data
			connectionStatus = 4;
			thisState = SaveState.FromByteArray(data);
		} else {
			// handle error
			connectionStatus = -3;
		}
	}
	
	public static void SaveGame (ISavedGameMetadata game, byte[] savedData, TimeSpan totalPlaytime) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		
		SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder();
		builder = builder
			.WithUpdatedPlayedTime(totalPlaytime)
				.WithUpdatedDescription("Saved game at " + DateTime.Now.ToString());
		SavedGameMetadataUpdate updatedMetadata = builder.Build();
		savedGameClient.CommitUpdate(game, updatedMetadata, savedData, OnSavedGameWritten);
	}
	
	public static void OnSavedGameWritten (SavedGameRequestStatus status, ISavedGameMetadata game) {
		if (status == SavedGameRequestStatus.Success) {
			// handle reading or writing of saved game.
		} else {
			// handle error
		}
	}

	public static String FormattedNumber(double d) {

		String result = "";
		String finalWord = "";

		int iterations = 0;
		
		while (d > 1000) {
			iterations++;
			d = d / 1000;
		}

		if (iterations == 1) {
			finalWord = "K";
		} else if (iterations == 2) {
			finalWord = "million";
		} else if (iterations == 3) {
			finalWord = "billion";
		} else if (iterations == 4) {
			finalWord = "trillion";
		} else if (iterations == 5) {
			finalWord = "quadrillion";
		} else if (iterations == 6) {
			finalWord = "quintillion";
		} else if (iterations == 7) {
			finalWord = "sextillion";
		} else if (iterations == 8) {
			finalWord = "septillion";
		} else if (iterations == 9) {
			finalWord = "octillion";
		} else if (iterations == 10) {
			finalWord = "nonillion";
		} else if (iterations > 10) {
			finalWord = "10^"+ (iterations*3);
		}

		result = d.ToString ("F3") + " " + finalWord;

		return result;

	}
	

	[Serializable]
	public class SaveState
	{
		// public members are serialized automatically
		// for private members use [SerializeField] attribute
		public double timePlayed = 0f;
		public double love = 0f;
		public double totalLove = 0f;
		public double clicks = 0f;
		public List<int> producers = new List<int>();
		public int language = 0;
		
		
		public SaveState()
		{
			// NOTHING TO SEE HERE
		}
		
		public static SaveState FromByteArray(Byte[] array)
		{
			
			if(array == null || array.Length == 0)
			{
				GlobalData.connectionStatus = 5;
				return null; 
			}
			
			using(var stream = new System.IO.MemoryStream(array))
			{
				try{
					BinaryFormatter formatter = new BinaryFormatter();
					SaveState bundle = (SaveState)formatter.Deserialize(stream);
					GlobalData.connectionStatus = 5;
					return bundle;
				} catch(Exception e)
				{
					GlobalData.connectionStatus = -4;
					//Debug.LogError("Error when reading stream: "+ e.Message);
				}
			}
			return null;
		}
		
		public static byte[] ToByteArray(SaveState bundle)
		{
			BinaryFormatter formatter = new BinaryFormatter();
			using(var stream = new System.IO.MemoryStream())
			{
				formatter.Serialize(stream, bundle);
				return stream.ToArray();
			}
		}
	}
	
}
