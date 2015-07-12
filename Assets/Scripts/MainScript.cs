using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public int[] screens = {-2, -1, 0, 1, 2};
	public int currentScreen = 0;

	private GameObject capa0;
	private GameObject capa1;

	private Rect auxScreen;

	private Vector3 lastMouse;
	private Vector3 lastFinger;

	// Use this for initialization
	void Start () 
	{

		capa0 = GameObject.Find ("Capa0");
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

		auxScreen = camera.rect;

	}
	
	// Update is called once per frame
	void Update () {

		if (Application.platform == RuntimePlatform.WindowsEditor) {
			if (Input.GetMouseButton(0)) {

				Vector2 touchDelta = new Vector2(Input.mousePosition.x - lastMouse.x, Input.mousePosition.y - lastMouse.y);
				Vector2 deltaPercentage = new Vector2((float)touchDelta.x/((float)Screen.width * (float)auxScreen.width), (float)touchDelta.y/((float)Screen.height  * (float)auxScreen.height));
				capa1.transform.position = new Vector3(capa1.transform.position.x + deltaPercentage.x*20f, 0f, 0f);

				if (capa1.transform.position.x > 60) {
					capa1.transform.position = new Vector3(60f, 0f, 0f);
				}
				else if (capa1.transform.position.x < -60) {
					capa1.transform.position = new Vector3(-60f, 0f, 0f);
				}
			
			}
			else if (Input.GetMouseButtonUp(0)) {

				Vector2 touchDelta = new Vector2(Input.mousePosition.x - lastMouse.x, Input.mousePosition.y - lastMouse.y);
				Vector2 deltaPercentage = new Vector2((float)touchDelta.x/((float)Screen.width * (float)auxScreen.width), (float)touchDelta.y/((float)Screen.height  * (float)auxScreen.height));

				if (deltaPercentage.x > 0) {

					currentScreen++;
					if (currentScreen > 2) { currentScreen = 2; }

				}
				else if (deltaPercentage.x < -0) {

					currentScreen--;
					if (currentScreen < -2) { currentScreen = -2; }

				}
				else {

					// NINGUN DESLIZAMIENTO BRUSCO
					if (capa1.transform.position.x <= -30) {
						currentScreen = -2;
					}
					else if (capa1.transform.position.x > -30 && capa1.transform.position.x <= -10) {
						currentScreen = -1;
					}
					else if (capa1.transform.position.x > -10 && capa1.transform.position.x <= 10) {
						currentScreen = 0;
					}
					else if (capa1.transform.position.x > 10 && capa1.transform.position.x <= 30) {
						currentScreen = 1;
					}
					else if (capa1.transform.position.x > 30) {
						currentScreen = 2;
					}

				}

			}
			else {
				capa1.transform.position = Vector3.Lerp(capa1.transform.position, new Vector3(currentScreen*20, 0, 0), Time.deltaTime*10f);
			}

			lastMouse = Input.mousePosition;

		} else {

			if (Input.touchCount > 0) {

				if (Input.GetTouch(0).phase == TouchPhase.Moved) {
					
					Vector2 touchDelta = new Vector2(Input.GetTouch(0).position.x - lastFinger.x, Input.GetTouch(0).position.y - lastFinger.y);
					Vector2 deltaPercentage = new Vector2((float)touchDelta.x/((float)Screen.width * (float)auxScreen.width), (float)touchDelta.y/((float)Screen.height  * (float)auxScreen.height));
					capa1.transform.position = new Vector3(capa1.transform.position.x + deltaPercentage.x*20f, 0f, 0f);
					
					if (capa1.transform.position.x > 60) {
						capa1.transform.position = new Vector3(60f, 0f, 0f);
					}
					else if (capa1.transform.position.x < -60) {
						capa1.transform.position = new Vector3(-60f, 0f, 0f);
					}
					
				}
				else if (Input.GetTouch(0).phase == TouchPhase.Ended) {
					
					Vector2 touchDelta = new Vector2(Input.GetTouch(0).position.x - lastFinger.x, Input.GetTouch(0).position.y - lastFinger.y);
					Vector2 deltaPercentage = new Vector2((float)touchDelta.x/((float)Screen.width * (float)auxScreen.width), (float)touchDelta.y/((float)Screen.height  * (float)auxScreen.height));
					
					if (deltaPercentage.x > 0) {
						
						currentScreen++;
						if (currentScreen > 2) { currentScreen = 2; }
						
					}
					else if (deltaPercentage.x < -0) {
						
						currentScreen--;
						if (currentScreen < -2) { currentScreen = -2; }
						
					}
					else {
						
						// NINGUN DESLIZAMIENTO BRUSCO
						if (capa1.transform.position.x <= -30) {
							currentScreen = -2;
						}
						else if (capa1.transform.position.x > -30 && capa1.transform.position.x <= -10) {
							currentScreen = -1;
						}
						else if (capa1.transform.position.x > -10 && capa1.transform.position.x <= 10) {
							currentScreen = 0;
						}
						else if (capa1.transform.position.x > 10 && capa1.transform.position.x <= 30) {
							currentScreen = 1;
						}
						else if (capa1.transform.position.x > 30) {
							currentScreen = 2;
						}
						
					}
					
				}

				lastFinger = Input.GetTouch(0).position;

			}
			else {

				capa1.transform.position = Vector3.Lerp(capa1.transform.position, new Vector3(currentScreen*20, 0, 0), Time.deltaTime*10f);
			
			}

		}



		capa0.transform.position = new Vector3 (capa1.transform.position.x/15f, 0, 0);

	}


}
