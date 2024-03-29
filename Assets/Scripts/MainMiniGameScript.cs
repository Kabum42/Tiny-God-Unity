﻿using UnityEngine;
using System.Collections;

public class MainMiniGameScript : MonoBehaviour {

	private int loadProgress = 0;
	private Rect auxScreen;
	private AsyncOperation async;
	public GameObject progress;

	// Use this for initialization
	void Start () {
	
		float targetaspect = 1188.0f / 1980.0f;
		
		// determine the game window's current aspect ratio
		float windowaspect = (float)Screen.width / (float)Screen.height;
		
		// current viewport height should be scaled by this amount
		float scaleheight = windowaspect / targetaspect;
		
		// obtain camera component so we can modify its viewport
		Camera camera = GetComponent<Camera>();
		
		// if scaled height is less than current height, add letterbox
		if (scaleheight < 1.0f)
		{  
			Rect rect = camera.rect;
			
			rect.width = 1.0f;
			rect.height = scaleheight;
			rect.x = 0;
			rect.y = (1.0f - scaleheight) / 2.0f;
			
			camera.rect = rect;
		}
		else // add pillarbox
		{
			float scalewidth = 1.0f / scaleheight;
			
			Rect rect = camera.rect;
			
			rect.width = scalewidth;
			rect.height = 1.0f;
			rect.x = (1.0f - scalewidth) / 2.0f;
			rect.y = 0;
			
			camera.rect = rect;
		}
		
		auxScreen = camera.rect;

		StartCoroutine (LoadScreen ());

	}

	IEnumerator LoadScreen() {
		
		//async = Application.LoadLevelAsync ("Game");
		async = Application.LoadLevelAdditiveAsync ("MiniGame"+GlobalData.currentMiniGame);
		
		while (!async.isDone) {
			
			loadProgress = (int)(async.progress*100);
			progress.GetComponent<TextMesh>().text = loadProgress + "%";
			
			yield return null;
			
		}
		


		GameObject aux = GameObject.Find ("MiniGame");
		aux.transform.parent = GameObject.Find ("Scene2").transform;

		loadProgress = 100;
		progress.GetComponent<TextMesh>().text = loadProgress + "%";

		aux = GameObject.Find ("Scene2/Loading");
		//aux.SetActive (false);
		GameObject.Destroy (aux);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
