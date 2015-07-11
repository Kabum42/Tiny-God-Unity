using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public int[] screens = {-2, -1, 0, 1, 2};
	public int currentScreen = 0;

	private GameObject capa1;

	// Use this for initialization
	void Start () 
	{

		capa1 = GameObject.Find ("Capa1");

		// set the desired aspect ratio (the values in this example are
		// hard-coded for 16:9, but you could make them into public
		// variables instead so you can set them at design time)
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

		Debug.Log (Screen.height);

	}
	
	// Update is called once per frame
	void Update () {

		if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)) {
			Vector2 touchDelta = Input.GetTouch(0).deltaPosition;
			Vector2 deltaPercentage = new Vector2(touchDelta.x/Screen.width, touchDelta.y/Screen.height);
			capa1.transform.Translate(-deltaPercentage.x*20f, 0, 0);
		}

		/*
		if (Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended) {
			Vector2 touchDelta = Input.GetTouch(0).deltaPosition;
			if (touchDelta.x>5) {} //This was a flick to the left with magnitude of 5 or more
			if (touchDelta.x<-5) {} //This was a flick to the right with magnitude of 5 or more
		}

		goal = Mathf.Round(transform.position.x/goalGrid)*goalGrid; //Where goalGrid would be an int of steps

		goal = Mathf.Clamp(goal, minimum, maximum);
	
		transform.position.x = Mathf.Lerp(transform.position.x, goal, speed*Time.deltaTime); //Where speed would be the multiplier to reach into position
		*/

	}


}
