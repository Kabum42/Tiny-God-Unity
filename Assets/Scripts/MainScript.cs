﻿using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	private Vector3 lastMousePosition;

	public int[] screens = {-2, -1, 0, 1, 2};

	private AsyncOperation async;

	public GameObject capa0;
	public GameObject capa1;
	public GameObject capa1Cloud;
	public GameObject capa1AnimatedCloud;
	public GameObject capa1BackgroundCloud;
	public GameObject capa1Screen1;
	public GameObject capa1Screen2Yahvy;
	public GameObject capa1Screen3;
	public GameObject capa2;
	public GameObject capa2Heart;

	public GameObject sceneReward;

	private Rect auxScreen;

	public Vector3 lastMouse;

	private Vector2 mouseDown;

	private AudioSource slide;

	private float slideToLeft = 0f;
	private float slideToRight = 0f;

	//private AudioSource daySong;
	//private AudioSource nightSong;

	private Vector2 inertia = new Vector2(0f, 0f);

	// Use this for initialization
	void Start () 
	{

		if (!GlobalData.started) { GlobalData.Start(); }
		GameObject.Find ("AdHolder").GetComponent<AdHolderScript> ().LoadInterstitial ();

		slide = gameObject.AddComponent<AudioSource>();
		slide.clip = Resources.Load ("Audio/slide") as AudioClip;
		slide.playOnAwake = false;
		slide.volume = 1f;

		capa2Heart = GameObject.Find ("Capa2/Heart");

		/*
		daySong = gameObject.AddComponent<AudioSource>();
		daySong.clip = Resources.Load ("Audio/day") as AudioClip;
		daySong.loop = true;
		daySong.volume = 0f;
		daySong.Play ();

		nightSong = gameObject.AddComponent<AudioSource>();
		nightSong.clip = Resources.Load ("Audio/night") as AudioClip;
		nightSong.loop = true;
		nightSong.volume = 0f;
		nightSong.Play ();
		*/

		capa0 = GameObject.Find ("Capa0");
		capa1 = GameObject.Find ("Capa1");
		capa1Cloud = GameObject.Find ("Capa1/Cloud");
		capa1AnimatedCloud = GameObject.Find ("Capa1/Cloud/AnimatedCloud");
		capa1BackgroundCloud = GameObject.Find ("Capa1/Cloud/Background");
		capa1Screen2Yahvy = GameObject.Find ("Capa1/Screen2/Yahvy");
		capa1Screen1 = GameObject.Find ("Capa1/Screen1");
		capa1Screen3 = GameObject.Find ("Capa1/Screen3");
		capa2 = GameObject.Find ("Capa2");


		sceneReward = GameObject.Find ("SceneReward");
		sceneReward.transform.FindChild("Second Camera").gameObject.GetComponent<RewardScript>().scene1 = GameObject.Find ("Scene1");

		sceneReward.SetActive (false);

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

		GlobalData.Update ();

		/*
		if (GlobalData.thisState.timeOfDay < 0.5f) {

			daySong.volume = Mathf.Lerp(daySong.volume, 0.3f, Time.deltaTime*10f);
			nightSong.volume = Mathf.Lerp(nightSong.volume, 0f, Time.deltaTime*10f);

		} else {

			daySong.volume = Mathf.Lerp(daySong.volume, 0f, Time.deltaTime*10f);
			nightSong.volume = Mathf.Lerp(nightSong.volume, 0.5f, Time.deltaTime*10f);

		}
		*/



		UpdateLastSlides ();

		bool isTouched = false;
		bool isMoving = false;
		bool touchEnded = false;

		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			// TESTEANDO EN WINDOWS
			if (Input.GetMouseButtonDown(0)) {
				mouseDown = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			}

			if (Input.GetMouseButton(0)) { 
				isTouched = true;
				isMoving = true; 
			}
			else if (Input.GetMouseButtonUp(0)) { 
				isTouched = true;
				touchEnded = true; }
		} else {
			// EN CUALQUIER OTRO SITIO
			if (Input.touchCount > 0) { 
				isTouched = true; 
				if (Input.GetTouch(0).phase == TouchPhase.Began) { mouseDown = new Vector2(Input.mousePosition.x, Input.mousePosition.y); }
				else if (Input.GetTouch(0).phase == TouchPhase.Moved) { isMoving = true; }
				else if (Input.GetTouch(0).phase == TouchPhase.Ended) { touchEnded = true; }
			}
		}

		if (isTouched) {
			if (isMoving) {

				Vector2 touchDelta = new Vector2(Input.mousePosition.x - lastMouse.x, Input.mousePosition.y - lastMouse.y);
				Vector2 deltaPercentage = new Vector2((float)touchDelta.x/((float)Screen.width * (float)auxScreen.width), (float)touchDelta.y/((float)Screen.height  * (float)auxScreen.height));

				if (Mathf.Abs(deltaPercentage.x) >= Mathf.Abs(deltaPercentage.y)) {

					// X WINS OVER Y
					capa1.transform.position = new Vector3(capa1.transform.position.x + deltaPercentage.x*GlobalData.CAPA1_WIDTH_SCREEN, 0f, 0f);

					if (capa1.transform.position.x > GlobalData.CAPA1_WIDTH_SCREEN*3f) {
						capa1.transform.position = new Vector3(GlobalData.CAPA1_WIDTH_SCREEN*3f, 0f, 0f);
					}
					else if (capa1.transform.position.x < -GlobalData.CAPA1_WIDTH_SCREEN*3f) {
						capa1.transform.position = new Vector3(-GlobalData.CAPA1_WIDTH_SCREEN*3f, 0f, 0f);
					}
					
					if (deltaPercentage.x > 0.02f) { slideToLeft = 0.5f; }
					else if (deltaPercentage.x < -0.02f) { slideToRight = 0.5f; }

				}
				else {

					// Y WINS OVER X
					if (capa1.transform.position.x >= GlobalData.CAPA1_WIDTH_SCREEN*-1.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*-0.5f) {

						if (capa1Screen3.GetComponent<Capa1Screen3Script>().producerSelected == null) {
							capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, capa1Screen3.transform.position.y + deltaPercentage.y*GlobalData.CAPA1_WIDTH_SCREEN, capa1Screen3.transform.position.z);
						}

						
					}
					else if (capa1.transform.position.x >= GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*1.5f) {
						
						if (capa1Screen1.GetComponent<Capa1Screen1Script>().upgradeSelected == null) {
							capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, capa1Screen1.transform.position.y + deltaPercentage.y*GlobalData.CAPA1_WIDTH_SCREEN, capa1Screen1.transform.position.z);
						}

						
					}

					inertia += deltaPercentage*20f;

				}

				
			}
			else if (touchEnded) {
				
				Vector2 touchDelta = new Vector2(Input.mousePosition.x - lastMouse.x, Input.mousePosition.y - lastMouse.y);
				Vector2 deltaPercentage = new Vector2((float)touchDelta.x/((float)Screen.width * (float)auxScreen.width), (float)touchDelta.y/((float)Screen.height  * (float)auxScreen.height));
				
				Vector2 downUp = new Vector2(Input.mousePosition.x - mouseDown.x, Input.mousePosition.y - mouseDown.y);
				downUp.Normalize();

				bool possibleSlide = false;

				if (Mathf.Abs(downUp.x) >= Mathf.Abs(downUp.y)) {
					possibleSlide = true;
				}

				if (slideToLeft > 0f && slideToLeft >= slideToRight && possibleSlide) {
					
					slide.Play();
					
					GlobalData.currentScreen--;
					if (GlobalData.currentScreen < -2) { GlobalData.currentScreen = -2; }
					
				}
				else if (slideToRight > 0f && slideToRight >= slideToLeft && possibleSlide) {
					
					slide.Play();
					
					GlobalData.currentScreen++;
					if (GlobalData.currentScreen > 2) { GlobalData.currentScreen = 2; }
					
				}
				else {

					// NINGUN DESLIZAMIENTO BRUSCO, PUNTERO ESTATICO
					if (capa1.transform.position.x <= -GlobalData.CAPA1_WIDTH_SCREEN*1.5) {
						GlobalData.currentScreen = 2;
					}
					else if (capa1.transform.position.x > -GlobalData.CAPA1_WIDTH_SCREEN*1.5f && capa1.transform.position.x <= -GlobalData.CAPA1_WIDTH_SCREEN*0.5f) {
						GlobalData.currentScreen = 1;
					}
					else if (capa1.transform.position.x > -GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*0.5f) {
						GlobalData.currentScreen = 0;
					}
					else if (capa1.transform.position.x > GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*1.5) {
						GlobalData.currentScreen = -1;
					}
					else if (capa1.transform.position.x > GlobalData.CAPA1_WIDTH_SCREEN*1.5) {
						GlobalData.currentScreen = -2;
					}
					
				}
				
			}

		}
		else {
			// PUNTERO NO ESTA INTERACTUANDO
			capa1.transform.position = Vector3.Lerp(capa1.transform.position, new Vector3(GlobalData.currentScreen*-GlobalData.CAPA1_WIDTH_SCREEN, 0, 0), Time.deltaTime*10f);
		
			if (capa1.transform.position.x >= GlobalData.CAPA1_WIDTH_SCREEN*-1.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*-0.5f) {

				if (capa1Screen3.GetComponent<Capa1Screen3Script>().producerSelected == null) {
					capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, capa1Screen3.transform.position.y + inertia.y * Time.deltaTime * GlobalData.CAPA1_WIDTH_SCREEN, capa1Screen3.transform.position.z);
				}
			
				float max_y = 0f;
				
				if (GlobalData.thisState.totalLove >= GlobalData.getBaseCost(Lang.TEMPLE_NAME)) {
					max_y += 2.5f;
				}
				if (GlobalData.thisState.totalLove >= GlobalData.getBaseCost(Lang.SHIP_NAME)) {
					max_y += 2.5f;
				}
				if (GlobalData.thisState.totalLove >= GlobalData.getBaseCost(Lang.FACTORY_NAME)) {
					max_y += 2.5f;
				}
				if (GlobalData.thisState.totalLove >= GlobalData.getBaseCost(Lang.LABORATORY_NAME)) {
					max_y += 2.5f;
				}
				if (GlobalData.thisState.totalLove >= GlobalData.getBaseCost(Lang.SHOP_NAME)) {
					max_y += 2.5f;
				}
				
				if (capa1Screen3.transform.position.y < 0f) {
					capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, Mathf.Lerp (capa1Screen3.transform.position.y, 0f, Time.deltaTime*20f), capa1Screen3.transform.position.z);
				}
				else if (capa1Screen3.transform.position.y > max_y) {
					capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, Mathf.Lerp (capa1Screen3.transform.position.y, max_y, Time.deltaTime*20f), capa1Screen3.transform.position.z);
				}

			}
			else if (capa1.transform.position.x >= GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*1.5f) {
				
				if (capa1Screen1.GetComponent<Capa1Screen1Script>().upgradeSelected == null) {
					capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, capa1Screen1.transform.position.y + inertia.y * Time.deltaTime * GlobalData.CAPA1_WIDTH_SCREEN, capa1Screen1.transform.position.z);
				}
				
				if (capa1Screen1.transform.position.y < 0f) {
					capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, Mathf.Lerp (capa1Screen1.transform.position.y, 0f, Time.deltaTime*20f), capa1Screen1.transform.position.z);
				}

				float max_y2 = capa1Screen1.GetComponent<Capa1Screen1Script>().current_maxY -7f;
				if (max_y2 < 0f) { max_y2 = 0f; }
				
				if (capa1Screen1.transform.position.y > max_y2) {
					capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, Mathf.Lerp (capa1Screen1.transform.position.y, max_y2, Time.deltaTime*20f), capa1Screen1.transform.position.z);
				}
				
			}
		
		}

		inertia = new Vector2 (Mathf.Lerp(inertia.x, 0f, Time.deltaTime*5f), Mathf.Lerp(inertia.y, 0f, Time.deltaTime*5f));

		if (capa1.transform.position.x > -18 && capa1.transform.position.x < -2) {

			capa1AnimatedCloud.SetActive(true);
			capa1Cloud.transform.localScale = new Vector3 (-1, 1.05f, 1);
			float anim_right = (float)-capa1.transform.position.x / 20f;
			if (anim_right < 0f) {
				anim_right = 0f;
			} else if (anim_right > 1f) {
				anim_right = 0.97f;
			}
			capa1AnimatedCloud.GetComponent<Animator> ().Play ("Covering", 0, anim_right);
			capa1Cloud.transform.localPosition = new Vector3 (10 - capa1.transform.position.x / 1.5f, 0, -4);
			capa1BackgroundCloud.transform.localPosition = new Vector3(-50 - capa1.transform.position.x *1.8f, 0, 4);

		} else if (capa1.transform.position.x > 2 && capa1.transform.position.x < 18) {

			capa1AnimatedCloud.SetActive(true);
			capa1Cloud.transform.localScale = new Vector3 (1, 1.05f, 1);
			float anim_left = (float)capa1.transform.position.x / 20f;
			if (anim_left < 0f) {
				anim_left = 0f;
			} else if (anim_left > 1f) {
				anim_left = 0.97f;
			}
			capa1AnimatedCloud.GetComponent<Animator> ().Play ("Covering", 0, anim_left);
			capa1Cloud.transform.localPosition = new Vector3 (-10 - capa1.transform.position.x / 1.5f, 0, -4);
			capa1BackgroundCloud.transform.localPosition = new Vector3(-50 + capa1.transform.position.x *1.8f, 0, 4);

		} else {

			if (capa1.transform.position.x < 0) {
				capa1Cloud.transform.localPosition = new Vector3 (10 - capa1.transform.position.x / 1.5f, 0, -4);
			}
			else {
				capa1Cloud.transform.localPosition = new Vector3 (-10 - capa1.transform.position.x / 1.5f, 0, -4);
			}

			capa1AnimatedCloud.SetActive(false);

		}



		UpdateMousePosition ();

		capa0.transform.position = new Vector3 (capa1.transform.position.x/15f, 0, 0);

		/*
		if (Input.GetKeyDown (KeyCode.M)) {

			Application.LoadLevelAdditive("MiniGame");

		}
		*/



	}

	void UpdateLastSlides() {

		if (slideToLeft > 0f) { 
			slideToLeft -= Time.deltaTime; 
			if (slideToLeft <= 0f) {
				slideToLeft = 0f;
			}
		}
		
		if (slideToRight > 0f) { 
			slideToRight -= Time.deltaTime; 
			if (slideToRight <= 0f) {
				slideToRight = 0f;
			}
		}

	}

	void UpdateMousePosition() {

		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			lastMouse = Input.mousePosition;
		} else {
			if (Input.touchCount > 0) { 
				lastMouse = Input.GetTouch(0).position;
			}
		}

	}

	private bool ClickedOn(GameObject target) {
		
		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			
			if (Input.GetMouseButtonDown(0)) { 
				
				lastMousePosition = Input.mousePosition;
				
			} else if (Input.GetMouseButtonUp(0)) { 
				
				Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
				
				// BUY MASK
				RaycastHit2D[] hits = Physics2D.RaycastAll(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
				
				for (int i = 0; i < hits.Length; i++) {
					
					Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
					
					RaycastHit2D[] hits2 = Physics2D.RaycastAll(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
					
					for (int j = 0; j < hits2.Length; j++) {

						if (j < hits.Length) {
							if (hits[j].collider.gameObject == hits2[j].collider.gameObject && hits[j].collider.gameObject == target) { return true; }
						}
						
					}
					
				}
				
			}
			
		} else {
			
			if (Input.touchCount > 0) { 
				
				if (Input.GetTouch(0).phase == TouchPhase.Began) {
					
					lastMousePosition = Input.GetTouch(0).position;
					
				} else if (Input.GetTouch(0).phase == TouchPhase.Ended) {
					
					Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
					
					// BUY MASK
					RaycastHit2D[] hits = Physics2D.RaycastAll(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
					
					for (int i = 0; i < hits.Length; i++) {
						
						Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
						
						RaycastHit2D[] hits2 = Physics2D.RaycastAll(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
						
						for (int j = 0; j < hits2.Length; j++) {
							
							if (j < hits.Length) {
								if (hits[j].collider.gameObject == hits2[j].collider.gameObject && hits[j].collider.gameObject == target) { return true; }
							}
							
						}
						
					}
					
				}
				
			}
			
		}
		
		return false;
		
	}


}
