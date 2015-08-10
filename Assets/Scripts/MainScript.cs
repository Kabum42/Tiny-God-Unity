using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class MainScript : MonoBehaviour {

	public int[] screens = {-2, -1, 0, 1, 2};
	public int currentScreen = 0;

	private AsyncOperation async;

	public GameObject capa0;
	public GameObject capa1;
	public GameObject capa1Screen2Yahvy;
	public GameObject capa1Screen3;
	public GameObject capa2;
	public GameObject capa2TopText;

	public GameObject sceneReward;

	private Rect auxScreen;

	private Vector3 lastMouse;

	private Vector2 mouseDown;

	private AudioSource slide;

	private float slideToLeft = 0f;
	private float slideToRight = 0f;

	private InterstitialAd interstitial;
	private bool showedAd = false;

	// Use this for initialization
	void Start () 
	{

		if (!GlobalData.started) { GlobalData.Start(); }

		slide = gameObject.AddComponent<AudioSource>();
		slide.clip = Resources.Load ("Audio/slide") as AudioClip;
		slide.playOnAwake = false;
		slide.volume = 1f;

		capa0 = GameObject.Find ("Capa0");
		capa1 = GameObject.Find ("Capa1");
		capa1Screen2Yahvy = GameObject.Find ("Capa1/Screen2/Yahvy");
		capa1Screen3 = GameObject.Find ("Capa1/Screen3");
		capa2 = GameObject.Find ("Capa2");
		capa2TopText = GameObject.Find ("Capa2/Top/TopText");

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

		interstitial = new InterstitialAd("ca-app-pub-7511456809904271/6234934949");
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);

	}
	
	// Update is called once per frame
	void Update () {

		if (!showedAd) {
			if (interstitial.IsLoaded()) {
				showedAd = true;
				interstitial.Show();
			}
		}

		GlobalData.Update ();
		capa2TopText.GetComponent<TextMesh> ().text = GlobalData.FormattedNumber(GlobalData.thisState.love);

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
					if (capa1.transform.position.x > GlobalData.CAPA1_WIDTH_SCREEN*-1.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*-0.5f) {
						
						capa1Screen3.transform.position = new Vector3(capa1Screen3.transform.position.x, capa1Screen3.transform.position.y + deltaPercentage.y*GlobalData.CAPA1_WIDTH_SCREEN, capa1Screen3.transform.position.z);

						float max_y = 0f;

						if (GlobalData.thisState.totalLove >= GlobalData.getBaseCost(Lang.SHIP_NAME)) {
							max_y += 1.5f;
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
					
					currentScreen--;
					if (currentScreen < -2) { currentScreen = -2; }
					
				}
				else if (slideToRight > 0f && slideToRight >= slideToLeft && possibleSlide) {
					
					slide.Play();
					
					currentScreen++;
					if (currentScreen > 2) { currentScreen = 2; }
					
				}
				else {

					// NINGUN DESLIZAMIENTO BRUSCO, PUNTERO ESTATICO
					if (capa1.transform.position.x <= -GlobalData.CAPA1_WIDTH_SCREEN*1.5) {
						currentScreen = 2;
					}
					else if (capa1.transform.position.x > -GlobalData.CAPA1_WIDTH_SCREEN*1.5f && capa1.transform.position.x <= -GlobalData.CAPA1_WIDTH_SCREEN*0.5f) {
						currentScreen = 1;
					}
					else if (capa1.transform.position.x > -GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*0.5f) {
						currentScreen = 0;
					}
					else if (capa1.transform.position.x > GlobalData.CAPA1_WIDTH_SCREEN*0.5f && capa1.transform.position.x <= GlobalData.CAPA1_WIDTH_SCREEN*1.5) {
						currentScreen = -1;
					}
					else if (capa1.transform.position.x > GlobalData.CAPA1_WIDTH_SCREEN*1.5) {
						currentScreen = -2;
					}
					
				}
				
			}
		}
		else {
			// PUNTERO NO ESTA INTERACTUANDO
			capa1.transform.position = Vector3.Lerp(capa1.transform.position, new Vector3(currentScreen*-GlobalData.CAPA1_WIDTH_SCREEN, 0, 0), Time.deltaTime*10f);
		}

		UpdateMousePosition ();

		capa0.transform.position = new Vector3 (capa1.transform.position.x/15f, 0, 0);

		if (Input.GetKeyDown (KeyCode.M)) {

			Application.LoadLevelAdditive("MiniGame");

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


}
