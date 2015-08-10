using UnityEngine;
using System.Collections;

public class RewardScript : MonoBehaviour {

	private Rect auxScreen;
	public GameObject scene1;
	public float time = 0f;
	private Vector2 lastMousePosition;
	private int optionReward = 0;

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

	}
	
	// Update is called once per frame
	void Update () {
	
		//time += Time.deltaTime;
		/*
		if (time > 2f) {
			time = 0f;
			finishedReward ();
		}
		*/

		bool touched = false;
		lastMousePosition = new Vector2(0f, 0f);

		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			
			if (Input.GetMouseButtonDown(0)) { 
				touched = true; 
				lastMousePosition = Input.mousePosition;
			}
			
		} else {
			
			if (Input.touchCount > 0) { 
				if (Input.GetTouch(0).phase == TouchPhase.Began) {
					touched = true; 
					lastMousePosition = Input.GetTouch(0).position;
				}
			}
			
		}

		if (touched) {

			Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
			
			if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("Option1")) && optionReward == 0) {

				// SELECTED OPTION 1
				optionReward = 1;
				GlobalData.showedAd = 2;

				//finishedReward ();
				
			} else if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("Option2")) && optionReward == 0) {
				
				// SELECTED OPTION 2
				optionReward = 2;
				GlobalData.showedAd = 1;
				
				//finishedReward ();
				
			} else if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("Confirm")) && optionReward != 0 && GlobalData.showedAd == 2) {
				
				// PRESSED CONFIRM BUTTON
				GlobalData.LoadInterstitial();
				finishedReward ();
				
			}

		}



	}

	void finishedReward() {

		this.gameObject.transform.parent.gameObject.SetActive (false);
		scene1.SetActive (true);
		scene1.transform.FindChild ("Main Camera").GetComponent<MainScript> ().lastMouse = Input.mousePosition;

	}
}
