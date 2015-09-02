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
	public static int currentScreen = 0;

	public static float connectionStatus = 0f;
	private static float defaultSaveCooldown = 20f;
	public static float saveCooldown = defaultSaveCooldown;
	public static ISavedGameMetadata thisGame;

	private static double timeThisSession = 0f;

	public static SaveState thisState; 

	public static int currentMiniGame = 1;
	
	public static void Start() {

		started = true;
		thisState = new SaveState ();

		if (!Lang.started) { Lang.Start(); }

	}
	
	public static void Update() {

		thisState.love += getAllLps () * Time.deltaTime;
		thisState.totalLove += getAllLps () * Time.deltaTime;


		if (thisState.minigame_timer < 1f) {
			thisState.minigame_timer += Time.deltaTime / 3f; // El numero es la cantidad de segundos que tarda la barra en llenarse
			if (thisState.minigame_timer > 1f) {
				thisState.minigame_timer = 1f;
			}
		}


		thisState.timeOfDay += Time.deltaTime*(1f/50f); // El segundo numero es lo que tarda el ciclo entero
		if (thisState.timeOfDay > 1f) {
			thisState.timeOfDay -= 1f;
		}

		if (connectionStatus == 5) {

			thisState.timePlayed += Time.deltaTime;
			
			saveCooldown -= Time.deltaTime;

			if (saveCooldown <= 0f) {

				OpenSavedGame2("TinyGod_3");

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
			// try to open again
			OpenSavedGame("TinyGod_3");
			//connectionStatus = -2;
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
			.WithUpdatedPlayedTime (totalPlaytime);
		SavedGameMetadataUpdate updatedMetadata = builder.Build();
		savedGameClient.CommitUpdate(game, updatedMetadata, savedData, OnSavedGameWritten);
	}
	
	public static void OnSavedGameWritten (SavedGameRequestStatus status, ISavedGameMetadata game) {
		if (status == SavedGameRequestStatus.Success) {
			// handle reading or writing of saved game.
		} else {
			// handle error
			thisState.love = -666;
		}
	}

	public static void OpenSavedGame2(string filename) {
		ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
		savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
		                                                    ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened2);
	}
	
	public static void OnSavedGameOpened2(SavedGameRequestStatus status, ISavedGameMetadata game) {
		if (status == SavedGameRequestStatus.Success) {
			// handle reading or writing of saved game.
			thisGame = game;

			TimeSpan timeSpan = TimeSpan.FromSeconds(thisState.timePlayed);
			
			byte[] myByteArray = SaveState.ToByteArray(thisState);
			
			SaveGame(thisGame, myByteArray, timeSpan);

		} else {
			// handle error
			thisState.love = -42;
		}
	}

	public static String FormattedNumber(double d) {

		String result = "";
		String finalWord = "";

		int iterations = 0;
		
		while (d >= 1000) {
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

	public static float getBaseCost(int id) {

		if (id == Lang.SERVANT_NAME) {
			return 15f;
		} else if (id == Lang.HUMAN_NAME) {
			return 100f;
		} else if (id == Lang.PROPHET_NAME) {
			return 500f;
		} else if (id == Lang.TEMPLE_NAME) {
			return 3000f;
		} else if (id == Lang.SHIP_NAME) {
			return 10000f;
		} else if (id == Lang.FACTORY_NAME) {
			return 40000f;
		} else if (id == Lang.LABORATORY_NAME) {
			return 200000f;
		} else if (id == Lang.SHOP_NAME) {
			return 1700000f;
		} else if (id == Lang.SPACESHIP_NAME) {
			return 125000000f;
		}

		return 0f;

	}

	public static float getBaseLps(int id) {
		
		if (id == Lang.SERVANT_NAME) {
			return 0.1f;
		} else if (id == Lang.HUMAN_NAME) {
			return 1f;
		} else if (id == Lang.PROPHET_NAME) {
			return 4f;
		} else if (id == Lang.TEMPLE_NAME) {
			return 10f;
		} else if (id == Lang.SHIP_NAME) {
			return 40f;
		} else if (id == Lang.FACTORY_NAME) {
			return 100f;
		} else if (id == Lang.LABORATORY_NAME) {
			return 400f;
		} else if (id == Lang.SHOP_NAME) {
			return 7000f;
		} else if (id == Lang.SPACESHIP_NAME) {
			return 100000f;
		}
		
		return 0f;
		
	}

	public static double getLps(int id) {
			
		double lps_final = getBaseLps(id);
		
		if (id == Lang.SERVANT_NAME) {
			if (thisState.values[Lang.SERVANT_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SERVANT_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.HUMAN_NAME) {
			if (thisState.values[Lang.HUMAN_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.HUMAN_UPGRADE_10] == 1) { lps_final *= 2; }

			if (thisState.values[Lang.SPECIAL_HUMAN_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPECIAL_HUMAN_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPECIAL_HUMAN_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPECIAL_HUMAN_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPECIAL_HUMAN_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPECIAL_HUMAN_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPECIAL_HUMAN_7] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.PROPHET_NAME) {
			if (thisState.values[Lang.PROPHET_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.PROPHET_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.TEMPLE_NAME) {
			if (thisState.values[Lang.TEMPLE_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.TEMPLE_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.SHIP_NAME) {
			if (thisState.values[Lang.SHIP_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHIP_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.FACTORY_NAME) {
			if (thisState.values[Lang.FACTORY_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.FACTORY_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.LABORATORY_NAME) {
			if (thisState.values[Lang.LABORATORY_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.LABORATORY_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.SHOP_NAME) {
			if (thisState.values[Lang.SHOP_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SHOP_UPGRADE_10] == 1) { lps_final *= 2; }
		}
		else if (id == Lang.SPACESHIP_NAME) {
			if (thisState.values[Lang.SPACESHIP_UPGRADE_1] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_2] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_3] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_4] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_5] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_6] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_7] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_8] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_9] == 1) { lps_final *= 2; }
			if (thisState.values[Lang.SPACESHIP_UPGRADE_10] == 1) { lps_final *= 2; }
		}
			
			return lps_final*thisState.values[id];

	}

	public static double getAllLps() {

		double aux = 0f;
		aux += getLps (Lang.SERVANT_NAME);
		aux += getLps (Lang.HUMAN_NAME);
		aux += getLps (Lang.PROPHET_NAME);
		aux += getLps (Lang.TEMPLE_NAME);
		aux += getLps (Lang.SHIP_NAME);
		aux += getLps (Lang.FACTORY_NAME);
		aux += getLps (Lang.LABORATORY_NAME);
		aux += getLps (Lang.SHOP_NAME);
		aux += getLps (Lang.SPACESHIP_NAME);

		return aux;
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
		public double minigame_timer = 0f;

		public double fragments = 0f;
		public double gems = 0f;
		public double fragment_multiplier = 2f;

		public int[] values = new int[300];

		public int language = 0;
		public float timeOfDay = 0f;
		
		
		public SaveState()
		{
			// Producers
			values[Lang.SERVANT_NAME] = 0;
			values[Lang.HUMAN_NAME] = 0;
			values[Lang.PROPHET_NAME] = 0;
			values[Lang.TEMPLE_NAME] = 0;
			values[Lang.SHIP_NAME] = 0;
			values[Lang.FACTORY_NAME] = 0;
			values[Lang.LABORATORY_NAME] = 0;
			values[Lang.SHOP_NAME] = 0;
			values[Lang.SPACESHIP_NAME] = 0;

			// Servant Upgrades
			values[Lang.SERVANT_UPGRADE_1] = 0;
			values[Lang.SERVANT_UPGRADE_2] = 0;
			values[Lang.SERVANT_UPGRADE_3] = 0;
			values[Lang.SERVANT_UPGRADE_4] = 0;
			values[Lang.SERVANT_UPGRADE_5] = 0;
			values[Lang.SERVANT_UPGRADE_6] = 0;
			values[Lang.SERVANT_UPGRADE_7] = 0;
			values[Lang.SERVANT_UPGRADE_8] = 0;
			values[Lang.SERVANT_UPGRADE_9] = 0;
			values[Lang.SERVANT_UPGRADE_10] = 0;

			// Human Upgrades
			values[Lang.HUMAN_UPGRADE_1] = 0;
			values[Lang.HUMAN_UPGRADE_2] = 0;
			values[Lang.HUMAN_UPGRADE_3] = 0;
			values[Lang.HUMAN_UPGRADE_4] = 0;
			values[Lang.HUMAN_UPGRADE_5] = 0;
			values[Lang.HUMAN_UPGRADE_6] = 0;
			values[Lang.HUMAN_UPGRADE_7] = 0;
			values[Lang.HUMAN_UPGRADE_8] = 0;
			values[Lang.HUMAN_UPGRADE_9] = 0;
			values[Lang.HUMAN_UPGRADE_10] = 0;

			// Special Human Upgrades
			values[Lang.SPECIAL_HUMAN_1] = 0;
			values[Lang.SPECIAL_HUMAN_2] = 0;
			values[Lang.SPECIAL_HUMAN_3] = 0;
			values[Lang.SPECIAL_HUMAN_4] = 0;
			values[Lang.SPECIAL_HUMAN_5] = 0;
			values[Lang.SPECIAL_HUMAN_6] = 0;
			values[Lang.SPECIAL_HUMAN_7] = 0;
			values[Lang.SPECIAL_HUMAN_8] = 0;
			values[Lang.SPECIAL_HUMAN_9] = 0;
			values[Lang.SPECIAL_HUMAN_10] = 0;

			// Prophet Upgrades
			values[Lang.PROPHET_UPGRADE_1] = 0;
			values[Lang.PROPHET_UPGRADE_2] = 0;
			values[Lang.PROPHET_UPGRADE_3] = 0;
			values[Lang.PROPHET_UPGRADE_4] = 0;
			values[Lang.PROPHET_UPGRADE_5] = 0;
			values[Lang.PROPHET_UPGRADE_6] = 0;
			values[Lang.PROPHET_UPGRADE_7] = 0;
			values[Lang.PROPHET_UPGRADE_8] = 0;
			values[Lang.PROPHET_UPGRADE_9] = 0;
			values[Lang.PROPHET_UPGRADE_10] = 0;

			// Temple Upgrades
			values[Lang.TEMPLE_UPGRADE_1] = 0;
			values[Lang.TEMPLE_UPGRADE_2] = 0;
			values[Lang.TEMPLE_UPGRADE_3] = 0;
			values[Lang.TEMPLE_UPGRADE_4] = 0;
			values[Lang.TEMPLE_UPGRADE_5] = 0;
			values[Lang.TEMPLE_UPGRADE_6] = 0;
			values[Lang.TEMPLE_UPGRADE_7] = 0;
			values[Lang.TEMPLE_UPGRADE_8] = 0;
			values[Lang.TEMPLE_UPGRADE_9] = 0;
			values[Lang.TEMPLE_UPGRADE_10] = 0;

			// Ship Upgrades
			values[Lang.SHIP_UPGRADE_1] = 0;
			values[Lang.SHIP_UPGRADE_2] = 0;
			values[Lang.SHIP_UPGRADE_3] = 0;
			values[Lang.SHIP_UPGRADE_4] = 0;
			values[Lang.SHIP_UPGRADE_5] = 0;
			values[Lang.SHIP_UPGRADE_6] = 0;
			values[Lang.SHIP_UPGRADE_7] = 0;
			values[Lang.SHIP_UPGRADE_8] = 0;
			values[Lang.SHIP_UPGRADE_9] = 0;
			values[Lang.SHIP_UPGRADE_10] = 0;

			// Factory Upgrades
			values[Lang.FACTORY_UPGRADE_1] = 0;
			values[Lang.FACTORY_UPGRADE_2] = 0;
			values[Lang.FACTORY_UPGRADE_3] = 0;
			values[Lang.FACTORY_UPGRADE_4] = 0;
			values[Lang.FACTORY_UPGRADE_5] = 0;
			values[Lang.FACTORY_UPGRADE_6] = 0;
			values[Lang.FACTORY_UPGRADE_7] = 0;
			values[Lang.FACTORY_UPGRADE_8] = 0;
			values[Lang.FACTORY_UPGRADE_9] = 0;
			values[Lang.FACTORY_UPGRADE_10] = 0;

			// Laboratory Upgrades
			values[Lang.LABORATORY_UPGRADE_1] = 0;
			values[Lang.LABORATORY_UPGRADE_2] = 0;
			values[Lang.LABORATORY_UPGRADE_3] = 0;
			values[Lang.LABORATORY_UPGRADE_4] = 0;
			values[Lang.LABORATORY_UPGRADE_5] = 0;
			values[Lang.LABORATORY_UPGRADE_6] = 0;
			values[Lang.LABORATORY_UPGRADE_7] = 0;
			values[Lang.LABORATORY_UPGRADE_8] = 0;
			values[Lang.LABORATORY_UPGRADE_9] = 0;
			values[Lang.LABORATORY_UPGRADE_10] = 0;

			// Shop Upgrades
			values[Lang.SHOP_UPGRADE_1] = 0;
			values[Lang.SHOP_UPGRADE_2] = 0;
			values[Lang.SHOP_UPGRADE_3] = 0;
			values[Lang.SHOP_UPGRADE_4] = 0;
			values[Lang.SHOP_UPGRADE_5] = 0;
			values[Lang.SHOP_UPGRADE_6] = 0;
			values[Lang.SHOP_UPGRADE_7] = 0;
			values[Lang.SHOP_UPGRADE_8] = 0;
			values[Lang.SHOP_UPGRADE_9] = 0;
			values[Lang.SHOP_UPGRADE_10] = 0;

			// Spaceship Upgrades
			values[Lang.SPACESHIP_UPGRADE_1] = 0;
			values[Lang.SPACESHIP_UPGRADE_2] = 0;
			values[Lang.SPACESHIP_UPGRADE_3] = 0;
			values[Lang.SPACESHIP_UPGRADE_4] = 0;
			values[Lang.SPACESHIP_UPGRADE_5] = 0;
			values[Lang.SPACESHIP_UPGRADE_6] = 0;
			values[Lang.SPACESHIP_UPGRADE_7] = 0;
			values[Lang.SPACESHIP_UPGRADE_8] = 0;
			values[Lang.SPACESHIP_UPGRADE_9] = 0;
			values[Lang.SPACESHIP_UPGRADE_10] = 0;

		}
		
		public static SaveState FromByteArray(Byte[] array)
		{
			
			if(array == null || array.Length == 0)
			{
				GlobalData.connectionStatus = 5;
				SaveState newState = new SaveState(); 
				return newState;
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

		public double getClickValue() {
			return 1f;
		}

		public float getCriticalChance() {
			return 0.1f;
		}

		public double getCriticalClickValue() {
			return 10f;
		}

	}
	
}
