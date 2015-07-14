using UnityEngine;
using System.Collections;

public class YahvyScript : MonoBehaviour {
	
	public GameObject yahvyBack;
	public GameObject yahvyBody;
	public GameObject yahvyFront;

	public string state = "IdleLoop";

	private float probBlinkDecSecond = 0.01f;
	private float probBlinkCooldown = 0.1f;

	private float lastInteraction = 0f;
	private float sleepyThreshold = 2f;
	private float sleepThreshold = 3f;

	private Vector2 lastMousePosition;
	private float lastAngleTapScreen;

	// Use this for initialization
	void Start () {

		lastMousePosition = new Vector2(0, 0);
		state = "IdleLoop";
		yahvyBack = gameObject.transform.FindChild ("YahvyBack").gameObject;
		yahvyBody = gameObject.transform.FindChild ("YahvyBodyModel").gameObject;
		yahvyFront = gameObject.transform.FindChild ("YahvyFront").gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {

		lastInteraction += Time.deltaTime;

		if (state == "IdleLoop") {

			if (probBlinkCooldown > 0f) {
				probBlinkCooldown -= Time.deltaTime;
				if (probBlinkCooldown <= 0f) {
					if (Random.Range(0f, 1f) > (1f - probBlinkDecSecond)) {
						PlayAnimation("IdleBlink");
					}
					probBlinkCooldown = 0.1f;
				}
			}

			if (lastInteraction >= sleepyThreshold) {
				PlayAnimation("SleepyLoop");
			}


		} else if (state == "IdleBlink" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("IdleBlink") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			PlayAnimation("IdleLoop");

		} else if (state == "SleepyLoop") {
			
			if (probBlinkCooldown > 0f) {
				probBlinkCooldown -= Time.deltaTime;
				if (probBlinkCooldown <= 0f) {
					if (Random.Range(0f, 1f) > (1f - probBlinkDecSecond)) {
						PlayAnimation("SleepyBlink");
					}
					probBlinkCooldown = 0.1f;
				}
			}


			if (lastInteraction >= sleepThreshold) {
				PlayAnimation("EnterToSleep");
			}

			
		} else if (state == "SleepyBlink" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyBlink") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SleepyLoop");
			
		} else if (state == "EnterToSleep" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("EnterToSleep") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SleepLoop");
			
		} else if (state == "TapEye" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapEye") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			
		} else if (state == "TapBody" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapBody") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			
		} else if (state == "TapScreen" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapScreen") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			
		}


		bool touched = false;

		if (Application.platform == RuntimePlatform.WindowsEditor) {

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

			Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);

			lastInteraction = 0f;

			if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("YahvyEye"))) {
				PlayAnimation("TapEye");
			} else if (Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("YahvyBody"))) {
				PlayAnimation("TapBody");
			} else {

				Vector2 aux = new Vector2(ray.origin.x, ray.origin.y);
				
				float angle = Vector3.Angle(new Vector3(yahvyBack.transform.position.x, yahvyBack.transform.position.y - 0.64f, 0),  new Vector3(aux.x, aux.y, 0));
				if (aux.x < 0f) { angle = 360f - angle; }

				lastAngleTapScreen = angle;

				PlayAnimation("TapScreen");
			}

		}


	}

	void PlayAnimation(string anim) {
		yahvyBack.GetComponent<Animator> ().CrossFade (anim, 0.05f, 0, 0f);
		yahvyFront.GetComponent<Animator> ().CrossFade (anim, 0.05f, 0, 0f);
		state = anim;
	}

	void LateUpdate() {
		// CAMBIAR ANGULO DEL OJO PARA LA ANIMACION DE TAP SCREEN
		if (state == "TapScreen") {



			yahvyBack.transform.FindChild ("Yahvy_Pupil").RotateAround (yahvyBack.transform.position + new Vector3(0f, -0.64f, 0f), Vector3.forward, lastAngleTapScreen - 90f);

			//yahvyBack.transform.FindChild ("Yahvy_Pupil").RotateAround (yahvyBack.transform.position /* +new Vector3(0f, -0.64f, 0f)*/, Vector3.forward, 90);

		} else {
			yahvyBack.transform.FindChild ("Yahvy_Pupil").eulerAngles = new Vector3(0f, 0f, 0f);
		}

	}

	/*
	void OnMouseDown() {
		PlayAnimation("TapBody");
		lastInteraction = 0f;
	}
	*/

}
