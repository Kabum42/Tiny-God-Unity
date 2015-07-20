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

	// Use this for initialization
	void Start () {

		lastMousePosition = new Vector2(0, 0);
		yahvyBack = gameObject.transform.FindChild ("YahvyBack").gameObject;
		yahvyBody = gameObject.transform.FindChild ("YahvyBodyModel").gameObject;
		yahvyFront = gameObject.transform.FindChild ("YahvyFront").gameObject;
		PlayAnimation ("IdleLoop");
	
	}
	
	// Update is called once per frame
	void Update () {

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
			}

			
		} else if (state == "SleepyBlink" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyBlink") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			CrossFadeAnimation("SleepyLoop");
			
		} else if (state == "SleepyLoop" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SleepyLoop");
			
		} else if (state == "EnterToSleep" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("EnterToSleep") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			CrossFadeAnimation("SleepLoop");
			
		} else if (state == "SleepLoop" && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepLoop") && yahvyBody.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
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

		if (touched && Camera.main.GetComponent<MainScript>().currentScreen == 0) {

			lastInteraction = 0f;

			if (GlobalData.thisState.getCriticalChance() >= Random.Range(0f, 1f)) {

				// CLICK CRITICO
				GlobalData.thisState.love += GlobalData.thisState.getCriticalClickValue();

				CrossFadeAnimation("TapCritical");

			} else {

				// CLICK NORMAL
				GlobalData.thisState.love += GlobalData.thisState.getClickValue();

				Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
				
				if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("YahvyEye"))) {
					
					if (state == "SleepLoop") {
						PlayAnimation("TapCritical");
					} else {
						CrossFadeAnimation("TapEye");
					}
					
				} else if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("YahvyBody"))) {
					
					if (state == "SleepLoop") {
						PlayAnimation("TapCritical");
					} else {
						CrossFadeAnimation("TapBody");
					}
					
				} else {
					
					Vector2 aux = new Vector2(ray.origin.x, ray.origin.y);
					
					float angle = Vector3.Angle(new Vector3(yahvyBack.transform.position.x, yahvyBack.transform.position.y - 0.64f, 0),  new Vector3(aux.x, aux.y, 0));
					if (aux.x < 0f) { angle = 360f - angle; }
					
					lastAngleTapScreen = angle;
					
					if (state == "SleepLoop") {
						PlayAnimation("TapCritical");
					} else {
						CrossFadeAnimation("TapScreen");
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
		// CAMBIAR ANGULO DEL OJO PARA LA ANIMACION DE TAP SCREEN
		if (state == "TapScreen" ) {

			//yahvyBody.transform.RotateAround (yahvyBack.transform.position + new Vector3(0f, -0.64f, 0f), Vector3.forward, lastAngleTapScreen - 90f);
			yahvyBack.transform.FindChild ("Yahvy_Pupil").RotateAround (yahvyBack.transform.position + new Vector3(0f, -0.64f, 0f), Vector3.forward, lastAngleTapScreen - 90f);

			//yahvyBack.transform.FindChild ("Yahvy_Pupil").RotateAround (yahvyBack.transform.position /* +new Vector3(0f, -0.64f, 0f)*/, Vector3.forward, 90);

		} else {

			//yahvyBody.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			//yahvyBack.transform.FindChild ("Yahvy_Pupil").eulerAngles = new Vector3(0f, 0f, Mathf.LerpAngle(yahvyBack.transform.FindChild ("Yahvy_Pupil").eulerAngles.z, 0f, 0f));
		}

	}

	/*
	void OnMouseDown() {
		CrossFadeAnimation("TapBody");
		lastInteraction = 0f;
	}
	*/

}
