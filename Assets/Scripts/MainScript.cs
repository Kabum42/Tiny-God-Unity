using UnityEngine;
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
	public GameObject capa2Top;
	public GameObject capa2TopText;
	public GameObject capa2TopText2;
	public GameObject capa2Dots;
	public GameObject capa2Heart;
	public GameObject capa2Miracle1;
	public GameObject capa2MiracleHeader;
	public GameObject capa2MiracleBar;
	public GameObject capa2Miracle2;
	public GameObject capa2MiracleButtonBase;
	public GameObject capa2MiracleButton;

	public GameObject sceneReward;

	private Rect auxScreen;

	public Vector3 lastMouse;

	private Vector2 mouseDown;

	private AudioSource slide;

	private float slideToLeft = 0f;
	private float slideToRight = 0f;

	private AudioSource rise3;
	private AudioSource tap;

	private AudioSource daySong;
	private AudioSource nightSong;

	// Use this for initialization
	void Start () 
	{

		if (!GlobalData.started) { GlobalData.Start(); }
		GameObject.Find ("AdHolder").GetComponent<AdHolderScript> ().LoadInterstitial ();

		slide = gameObject.AddComponent<AudioSource>();
		slide.clip = Resources.Load ("Audio/slide") as AudioClip;
		slide.playOnAwake = false;
		slide.volume = 1f;

		rise3 = gameObject.AddComponent<AudioSource>();
		rise3.clip = Resources.Load ("Audio/rise3") as AudioClip;
		rise3.volume = 1f;
		rise3.playOnAwake = false;

		tap = gameObject.AddComponent<AudioSource>();
		tap.clip = Resources.Load ("Audio/tap") as AudioClip;
		tap.volume = 1f;
		tap.playOnAwake = false;

		daySong = gameObject.AddComponent<AudioSource>();
		daySong.clip = Resources.Load ("Audio/day") as AudioClip;
		daySong.loop = true;
		daySong.volume = 0.5f;
		daySong.Play ();

		nightSong = gameObject.AddComponent<AudioSource>();
		nightSong.clip = Resources.Load ("Audio/night") as AudioClip;
		nightSong.loop = true;
		nightSong.volume = 0f;
		nightSong.Play ();

		capa0 = GameObject.Find ("Capa0");
		capa1 = GameObject.Find ("Capa1");
		capa1Cloud = GameObject.Find ("Capa1/Cloud");
		capa1AnimatedCloud = GameObject.Find ("Capa1/Cloud/AnimatedCloud");
		capa1BackgroundCloud = GameObject.Find ("Capa1/Cloud/Background");
		capa1Screen2Yahvy = GameObject.Find ("Capa1/Screen2/Yahvy");
		capa1Screen1 = GameObject.Find ("Capa1/Screen1");
		capa1Screen3 = GameObject.Find ("Capa1/Screen3");
		capa2 = GameObject.Find ("Capa2");
		capa2Top = GameObject.Find ("Capa2/Top");
		capa2TopText = GameObject.Find ("Capa2/Top/TopText");
		capa2TopText2 = GameObject.Find ("Capa2/Top/TopText2");
		capa2Dots = GameObject.Find ("Capa2/Dots");
		capa2Heart = GameObject.Find ("Capa2/Heart");
		capa2Miracle1 = GameObject.Find ("Capa2/Miracle1");
		capa2MiracleHeader = GameObject.Find ("Capa2/Miracle1/MiracleHeader");
		capa2MiracleBar = GameObject.Find ("Capa2/Miracle1/MiracleBar");
		capa2Miracle2 = GameObject.Find ("Capa2/Miracle2");
		capa2MiracleButtonBase = GameObject.Find ("Capa2/Miracle2/ButtonBase");
		capa2MiracleButton = GameObject.Find ("Capa2/Miracle2/MiracleButton");

		capa2Miracle2.SetActive (false);

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

		if (GlobalData.thisState.timeOfDay < 0.5f) {

			daySong.volume = Mathf.Lerp(daySong.volume, 0.5f, Time.deltaTime*10f);
			nightSong.volume = Mathf.Lerp(nightSong.volume, 0f, Time.deltaTime*10f);

		} else {

			daySong.volume = Mathf.Lerp(daySong.volume, 0f, Time.deltaTime*10f);
			nightSong.volume = Mathf.Lerp(nightSong.volume, 0.5f, Time.deltaTime*10f);

		}

		string original = GlobalData.FormattedNumber(GlobalData.thisState.love);
		string[] parts = original.Split(' ');
		capa2TopText.GetComponent<TextMesh> ().text = parts[0];
		if (parts [1] != null) {
			capa2TopText2.GetComponent<TextMesh> ().text = parts [1];
		} else {
			capa2TopText2.GetComponent<TextMesh> ().text = "";
		}

		capa2TopText2.GetComponent<TextMesh> ().fontSize = 40;
		
		while (capa2TopText2.GetComponent<MeshRenderer> ().bounds.size.x > 1.5f) {
			capa2TopText2.GetComponent<TextMesh> ().fontSize -= 1;
		}

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
							capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, 0f, capa1Screen3.transform.position.z);
						}
						else if (capa1Screen3.transform.position.y > max_y) {
							capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, max_y, capa1Screen3.transform.position.z);
						}
						
					}
					else if (capa1.transform.position.x >= GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*1.5f) {
						
						if (capa1Screen1.GetComponent<Capa1Screen1Script>().upgradeSelected == null) {
							capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, capa1Screen1.transform.position.y + deltaPercentage.y*GlobalData.CAPA1_WIDTH_SCREEN, capa1Screen1.transform.position.z);
						}
						

						
						if (capa1Screen1.transform.position.y < 0f) {
							capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, 0f, capa1Screen1.transform.position.z);
						}
						
					}

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
		}

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

			capa1AnimatedCloud.SetActive(false);

		}

		float anim_dots = 0.5f - (float)capa1.transform.position.x / 80f;
		if (anim_dots >= 0.49f && anim_dots <= 0.51f) { anim_dots = 0.49f; }
		if (anim_dots >= 0.74f && anim_dots <= 0.76f) { anim_dots = 0.74f; }
		if (anim_dots > 0.99f) { anim_dots = 0.99f; }
		capa2Dots.GetComponent<Animator> ().Play ("Slide", 0, anim_dots);

		anim_dots += 0.060f;
		capa2Top.GetComponent<Animator> ().Play ("Transition", 0, anim_dots);
		capa2MiracleHeader.GetComponent<Animator> ().Play ("Transition", 0, anim_dots);
		capa2MiracleButtonBase.GetComponent<Animator> ().Play ("Transition", 0, anim_dots);

		capa2MiracleBar.GetComponent<Animator> ().Play ("Grow", 0, (float) GlobalData.thisState.minigame_timer);

		if (GlobalData.thisState.minigame_timer == 1f) {
			if (capa2Miracle1.transform.localPosition.y > -11.5f) {
				if (capa2Miracle1.transform.localPosition.y == -10f) {
					rise3.Play();
				}
				float aux_y = Mathf.Lerp (capa2Miracle1.transform.localPosition.y, -11.51f, Time.deltaTime*10f);
				capa2Miracle1.transform.localPosition = new Vector3(0, aux_y, -17.7f);
				if (aux_y <= -11.5f) { 
					capa2Miracle1.SetActive(false); 
					capa2Miracle2.SetActive(true);
				}
			} else {

				if (capa2Miracle2.transform.localPosition.y < -10.1f) {
					float aux_y = Mathf.Lerp (capa2Miracle2.transform.localPosition.y, -10f, Time.deltaTime*10f);
					capa2Miracle2.transform.localPosition = new Vector3(0, aux_y, -17.7f);
					if (aux_y >= -10.1f) { 
						capa2Miracle2.transform.localPosition = new Vector3(0, -10f, -17.7f);
					}
				}

				if (capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Idle") && capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
					capa2MiracleButton.GetComponent<Animator> ().Play ("Idle", 0, 0f);
				}

				if (capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Idle") && ClickedOn(capa2MiracleButton)) {
					tap.Play();
					capa2MiracleButton.GetComponent<Animator> ().Play ("Pressing", 0, 0f);
				}

				if (capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Pressing") && capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
					Application.LoadLevelAdditive("MiniGame");
				}

			}

		}

		if (capa2Heart.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.99f) {
			capa2Heart.GetComponent<Animator>().Play("Idle", 0, 0);
		}

		UpdateMousePosition ();

		capa0.transform.position = new Vector3 (capa1.transform.position.x/15f, 0, 0);

		/*
		if (Input.GetKeyDown (KeyCode.M)) {

			Application.LoadLevelAdditive("MiniGame");

		}
		*/

		float max_y2 = capa1Screen1.GetComponent<Capa1Screen1Script>().current_maxY -7f;
		if (max_y2 < 0f) { max_y2 = 0f; }
		
		if (capa1Screen1.transform.position.y > max_y2) {
			capa1Screen1.transform.position = new Vector3(capa1Screen1.transform.position.x, Mathf.Lerp (capa1Screen1.transform.position.y, max_y2, Time.deltaTime*10f), capa1Screen1.transform.position.z);
		}

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
						
						if (hits[j].collider.gameObject == hits2[j].collider.gameObject && hits[j].collider.gameObject == target) { return true; }
						
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
					RaycastHit2D hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
					
					if (hit.collider != null) {
						
						Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
						
						RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
						
						if (hit2.collider != null) {
							
							if (hit.collider.gameObject == hit2.collider.gameObject && hit.collider.gameObject == target) { return true; }
							
						}
						
					}
					
				}
				
			}
			
		}
		
		return false;
		
	}


}
