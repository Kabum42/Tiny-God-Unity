using UnityEngine;
using System.Collections;

public class YahvyScript : MonoBehaviour {
	
	public GameObject yahvyBack;
	public GameObject yahvyBody;
	public GameObject yahvyFront;

	public string state = "IdleLoop";

	private float probBlinkDecSecond = 0.05f;
	private float probBlinkCooldown = 0.1f;

	private float lastInteraction = 0f;
	private float sleepyThreshold = 5f;
	private float sleepThreshold = 10f;

	private float tapScreenCoolingDown = 0f;

	private Vector2 lastMousePosition;
	private float lastAngleTapScreen;

	private string currentSkin = "Standard";

	private GameObject yahvyBackSheen;
	private Sprite currentBackSheen;

	private GameObject yahvyBackPupil;
	private Sprite currentBackPupil;

	private GameObject yahvyBackEyeBack;
	private Sprite currentBackEyeBack;

	private GameObject yahvyFrontTearRight;
	private Sprite currentFrontTearRight;

	private GameObject yahvyFrontTearLeft;
	private Sprite currentFrontTearLeft;

	private GameObject yahvyFrontTwistMouth;
	private Sprite currentFrontTwistMouth;

	private GameObject yahvyFrontYawn;
	private Sprite currentFrontYawn;

	private GameObject yahvyFrontSad;
	private Sprite currentFrontSad;

	private GameObject yahvyFrontOpenMouth;
	private Sprite currentFrontOpenMouth;

	private GameObject yahvyFrontGrin;
	private Sprite currentFrontGrin;

	private GameObject yahvyFrontEyelash;
	private Sprite currentFrontEyelash;

	private GameObject yahvyFrontCloseMouth;
	private Sprite currentFrontCloseMouth;

	private GameObject yahvyFrontSmile;
	private Sprite currentFrontSmile;

	private GameObject yahvyFrontTeeth;
	private Sprite currentFrontTeeth;

	private GameObject yahvyFrontFrecklesRight;
	private Sprite currentFrontFrecklesRight;

	private GameObject yahvyFrontFrecklesLeft;
	private Sprite currentFrontFrecklesLeft;

	private GameObject yahvyFrontCheekRight;
	private Sprite currentFrontCheekRight;

	private GameObject yahvyFrontCheekLeft;
	private Sprite currentFrontCheekLeft;

	private GameObject yahvyFrontEyebrow;
	private Sprite currentFrontEyebrow;

	private GameObject yahvyFrontShadeDetailUp;
	private Sprite currentFrontShadeDetailUp;

	private GameObject yahvyFrontShadeDetailDown;
	private Sprite currentFrontShadeDetailDown;

	private string backAnimation = "IdleLoop";
	private string bodyAnimation = "IdleLoop";
	private string frontAnimation = "IdleBlink";

	// Use this for initialization
	void Start () {

		lastMousePosition = new Vector2(0, 0);

		yahvyBack = gameObject.transform.FindChild ("YahvyBack").gameObject;
		yahvyBody = gameObject.transform.FindChild ("YahvyBodyModel").gameObject;
		yahvyFront = gameObject.transform.FindChild ("YahvyFront").gameObject;

		yahvyBackSheen = yahvyBack.transform.FindChild ("Yahvy_Sheen").gameObject;
		yahvyBackPupil = yahvyBack.transform.FindChild ("Yahvy_Pupil").gameObject;
		yahvyBackEyeBack = yahvyBack.transform.FindChild ("Yahvy_EyeBack").gameObject;

		yahvyFrontTearRight = yahvyFront.transform.FindChild("Yahvy_Tear_Right").gameObject;
		yahvyFrontTearLeft = yahvyFront.transform.FindChild("Yahvy_Tear_Left").gameObject;
		yahvyFrontTwistMouth = yahvyFront.transform.FindChild("Yahvy_TwistMouth").gameObject;
		yahvyFrontYawn = yahvyFront.transform.FindChild("Yahvy_Yawn").gameObject;
		yahvyFrontSad = yahvyFront.transform.FindChild("Yahvy_Sad").gameObject;
		yahvyFrontOpenMouth = yahvyFront.transform.FindChild("Yahvy_OpenMouth").gameObject;
		yahvyFrontGrin = yahvyFront.transform.FindChild("Yahvy_Grin").gameObject;
		yahvyFrontEyelash = yahvyFront.transform.FindChild("Yahvy_Eyelash").gameObject;
		yahvyFrontCloseMouth = yahvyFront.transform.FindChild("Yahvy_CloseMouth").gameObject;
		yahvyFrontSmile = yahvyFront.transform.FindChild("Yahvy_Smile").gameObject;
		yahvyFrontTeeth = yahvyFront.transform.FindChild("Yahvy_Teeth").gameObject;
		yahvyFrontFrecklesRight = yahvyFront.transform.FindChild("Yahvy_Freckles_Right").gameObject;
		yahvyFrontFrecklesLeft = yahvyFront.transform.FindChild("Yahvy_Freckles_Left").gameObject;
		yahvyFrontCheekRight = yahvyFront.transform.FindChild("Yahvy_Cheek_Right").gameObject;
		yahvyFrontCheekLeft = yahvyFront.transform.FindChild("Yahvy_Cheek_Left").gameObject;
		yahvyFrontEyebrow = yahvyFront.transform.FindChild("Yahvy_Eyebrow").gameObject;
		yahvyFrontShadeDetailUp = yahvyFront.transform.FindChild("Yahvy_ShadeDetail_Up").gameObject;
		yahvyFrontShadeDetailDown = yahvyFront.transform.FindChild("Yahvy_ShadeDetail_Down").gameObject;

		PlayAnimation ("IdleLoop");
		ChangeSkin ("Standard");
		//ChangeSkin ("Rainbow");


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Camera.main.GetComponent<MainScript> ().capa1.transform.localPosition.x > -18f && Camera.main.GetComponent<MainScript> ().capa1.transform.localPosition.x < 18) {
			// ESTAS EN LA PANTALLA DE YAHVY
			if (!yahvyBack.activeInHierarchy) {

				yahvyBack.SetActive(true);
				yahvyBody.SetActive(true);
				yahvyFront.SetActive(true);

				if (state == "TapScreen" || state == "TapBody" || state == "TapEye") {
					state = "IdleLoop";
				}
				if (lastInteraction > sleepyThreshold) {
					state = "SleepyLoop";
				}
				if (lastInteraction > sleepThreshold) {
					state = "SleepLoop";
				}

				yahvyBack.GetComponent<Animator> ().Play(state, 0, 0f);
				yahvyBody.GetComponent<Animator> ().Play(state, 0, 0f);
				yahvyFront.GetComponent<Animator> ().Play(state, 0, 0f);

			}

		} else {
			// NO ESTAS EN LA PANTALLA DE YAHVY
			if (yahvyBack.activeInHierarchy) {

				lastAngleTapScreen = 90f;

				yahvyBack.SetActive(false);
				yahvyBody.SetActive(false);
				yahvyFront.SetActive(false);

			}

		}

		lastInteraction += Time.deltaTime;

		if (tapScreenCoolingDown > 0f) {
			tapScreenCoolingDown -= Time.deltaTime;
			if (tapScreenCoolingDown <= 0f) {
				tapScreenCoolingDown = 0f;
			}
		}

		if (state == "IdleLoop") {

			if (yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("IdleLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {	
				PlayAnimation("IdleLoop");
			}

			if (probBlinkCooldown > 0f) {
				probBlinkCooldown -= Time.deltaTime;
				if (probBlinkCooldown <= 0f) {
					if (Random.Range(0f, 1f) > (1f - probBlinkDecSecond)) {
						CrossFadeAnimation("IdleBlink");
					}
					probBlinkCooldown = 0.1f;
				}
			}

			if (lastInteraction >= sleepyThreshold) {
				CrossFadeAnimation("SleepyLoop");
			}


		} else if (state == "IdleBlink" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("IdleBlink") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			CrossFadeAnimation("IdleLoop");

		} else if (state == "SleepyLoop") {

			if (yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {	
				PlayAnimation("SleepyLoop");
			}
			
			if (probBlinkCooldown > 0f) {
				probBlinkCooldown -= Time.deltaTime;
				if (probBlinkCooldown <= 0f) {
					if (Random.Range(0f, 1f) > (1f - probBlinkDecSecond)) {
						CrossFadeAnimation("SleepyBlink");
					}
					probBlinkCooldown = 0.1f;
				}
			}


			if (lastInteraction >= sleepThreshold) {
				CrossFadeAnimation("EnterToSleep");
				backAnimation = "EnterToSleep";
				bodyAnimation = "EnterToSleep";
				frontAnimation = "EnterToSleep";
			}

			
		} else if (state == "SleepyBlink" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyBlink") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			CrossFadeAnimation("SleepyLoop");
			
		} else if (state == "SleepyLoop" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SleepyLoop");
			
		} else if (state == "EnterToSleep" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("EnterToSleep") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			CrossFadeAnimation("SleepLoop");
			
		} else if (state == "SleepLoop" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SleepLoop");
			
		} else if (state == "SleepLoop" && !yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepLoop")) {
			
			PlayAnimation("SleepLoop");
			
		} else if (state == "TapEye" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapEye") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			CrossFadeAnimation("IdleLoop");
			
		} else if (state == "TapBody" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapBody") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			
		} else if (state == "TapScreen" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapScreen") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			//tapScreenCoolingDown = 0.05f;
			
		} else if (state == "TapCritical" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapCritical") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			CrossFadeAnimation("IdleLoop");
			
		} else if (state == "Annoyed" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Annoyed") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("Annoyed");
			
		} else if (state == "SadLoop" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SadLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SadLoop");
			
		}


		bool touched = false;

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

		if (touched && GlobalData.currentScreen == 0) {

			lastInteraction = 0f;

			if (GlobalData.thisState.getCriticalChance() >= Random.Range(0f, 1f)) {

				// CLICK CRITICO
				//GlobalData.thisState.love += GlobalData.thisState.getCriticalClickValue();
				//GlobalData.thisState.totalLove += GlobalData.thisState.getCriticalClickValue();
				GlobalData.thisState.totalLove += GlobalData.thisState.love +1;
				GlobalData.thisState.love += GlobalData.thisState.love +1;

				CrossFadeAnimation("TapCritical");

				Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Crit", 0, 0);

			} else {

				// CLICK NORMAL
				//GlobalData.thisState.love += GlobalData.thisState.getClickValue();
				//GlobalData.thisState.totalLove += GlobalData.thisState.getClickValue();
				GlobalData.thisState.totalLove += GlobalData.thisState.love +1;
				GlobalData.thisState.love += GlobalData.thisState.love +1;


				Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
				
				if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("YahvyEye"))) {
					
					if (state == "SleepLoop") {
						PlayAnimation("TapCritical");
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Crit", 0, 0);
					} else {
						CrossFadeAnimation("TapEye");
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Pulse", 0, 0);
						//Application.LoadLevelAdditive("MiniGame");
					}
					
				} else if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("YahvyBody"))) {
					
					if (state == "SleepLoop") {
						PlayAnimation("TapCritical");
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Crit", 0, 0);
					} else {
						CrossFadeAnimation("TapBody");
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Pulse", 0, 0);
					}
					
				} else {
					
					Vector2 aux = new Vector2(ray.origin.x, ray.origin.y);
					
					float angle = Vector3.Angle(new Vector3(yahvyBack.transform.position.x, yahvyBack.transform.position.y - 0.64f, 0),  new Vector3(aux.x, aux.y, 0));
					if (aux.x < 0f) { angle = 360f - angle; }
					
					lastAngleTapScreen = angle;
					
					if (state == "SleepLoop") {
						PlayAnimation("TapCritical");
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Crit", 0, 0);
					} else {
						CrossFadeAnimation("TapScreen");
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Pulse", 0, 0);
					}
					
				}

			}



		}


	}

	void CrossFadeAnimation(string anim) {
		yahvyBack.GetComponent<Animator> ().CrossFade (anim, 0.05f, 0, 0f);
		yahvyBody.GetComponent<Animator> ().CrossFade (anim, 0.05f, 0, 0f);
		yahvyFront.GetComponent<Animator> ().CrossFade (anim, 0.05f, 0, 0f);
		state = anim;
	}

	void PlayAnimation(string anim) {
		yahvyBack.GetComponent<Animator> ().Play (anim, 0, 0f);
		yahvyBody.GetComponent<Animator> ().Play (anim, 0, 0f);
		yahvyFront.GetComponent<Animator> ().Play (anim, 0, 0f);
		state = anim;
	}

	void LateUpdate() {

		yahvyBackSheen.GetComponent<SpriteRenderer> ().sprite = currentBackSheen;
		yahvyBackPupil.GetComponent<SpriteRenderer>().sprite = currentBackPupil;
		yahvyBackEyeBack.GetComponent<SpriteRenderer>().sprite = currentBackEyeBack;

		yahvyFrontTearRight.GetComponent<SpriteRenderer> ().sprite = currentFrontTearRight;
		yahvyFrontTearLeft.GetComponent<SpriteRenderer> ().sprite = currentFrontTearLeft;
		yahvyFrontTwistMouth.GetComponent<SpriteRenderer> ().sprite = currentFrontTwistMouth;
		yahvyFrontYawn.GetComponent<SpriteRenderer> ().sprite = currentFrontYawn;
		yahvyFrontSad.GetComponent<SpriteRenderer> ().sprite = currentFrontSad;
		yahvyFrontOpenMouth.GetComponent<SpriteRenderer> ().sprite = currentFrontOpenMouth;
		yahvyFrontGrin.GetComponent<SpriteRenderer> ().sprite = currentFrontGrin;
		yahvyFrontEyelash.GetComponent<SpriteRenderer> ().sprite = currentFrontEyelash;
		yahvyFrontCloseMouth.GetComponent<SpriteRenderer> ().sprite = currentFrontCloseMouth;
		yahvyFrontSmile.GetComponent<SpriteRenderer> ().sprite = currentFrontSmile;
		yahvyFrontTeeth.GetComponent<SpriteRenderer> ().sprite = currentFrontTeeth;
		yahvyFrontFrecklesRight.GetComponent<SpriteRenderer> ().sprite = currentFrontFrecklesRight;
		yahvyFrontFrecklesLeft.GetComponent<SpriteRenderer> ().sprite = currentFrontFrecklesLeft;
		yahvyFrontCheekRight.GetComponent<SpriteRenderer> ().sprite = currentFrontCheekRight;
		yahvyFrontCheekLeft.GetComponent<SpriteRenderer> ().sprite = currentFrontCheekLeft;
		yahvyFrontEyebrow.GetComponent<SpriteRenderer> ().sprite = currentFrontEyebrow;
		yahvyFrontShadeDetailUp.GetComponent<SpriteRenderer> ().sprite = currentFrontShadeDetailUp;
		yahvyFrontShadeDetailDown.GetComponent<SpriteRenderer> ().sprite = currentFrontShadeDetailDown;


		// CAMBIAR ANGULO DEL OJO PARA LA ANIMACION DE TAP SCREEN
		if (state == "TapScreen" ) {

			yahvyBack.transform.FindChild ("Yahvy_Pupil").RotateAround (yahvyBack.transform.position + new Vector3(0f, -0.64f, 0f), Vector3.forward, lastAngleTapScreen - 90f);

		}

	}

	void ChangeSkin(string skin) {

		currentBackSheen = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Sheen");
		currentBackPupil = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Pupil");
		currentBackEyeBack = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_EyeBack");
		
		yahvyBody.transform.FindChild ("YahvyModel").GetComponent<SkinnedMeshRenderer> ().material.mainTexture = (Texture) Resources.Load ("Skins/" + skin + "/Yahvy_Body");
		yahvyBody.transform.FindChild ("YahvyModel.1").GetComponent<SkinnedMeshRenderer> ().material.mainTexture = (Texture) Resources.Load ("Skins/" + skin + "/Yahvy_Body");

		currentFrontTearRight = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Tear");
		currentFrontTearLeft = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Tear");
		currentFrontTwistMouth = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Twistmouth");
		currentFrontYawn = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Yawn");
		currentFrontSad = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Sad");
		currentFrontOpenMouth = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_OpenMouth");
		currentFrontGrin = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Grin");
		currentFrontEyelash = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Eyelash");
		currentFrontCloseMouth = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_CloseMouth");
		currentFrontSmile = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Smile");
		currentFrontTeeth = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Teeth");
		currentFrontFrecklesRight = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Freckles");
		currentFrontFrecklesLeft = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Freckles");
		currentFrontCheekRight = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Cheek");
		currentFrontCheekLeft = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Cheek");
		currentFrontEyebrow = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_Eyebrow");
		currentFrontShadeDetailUp = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_ShadeDetail");
		currentFrontShadeDetailDown = Resources.Load<Sprite>("Skins/" + skin + "/Yahvy_ShadeDetail");

		currentSkin = skin;

	}

}
