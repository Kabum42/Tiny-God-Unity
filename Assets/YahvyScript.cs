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

	// Use this for initialization
	void Start () {

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

			if (lastInteraction >= 1f) {
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


			if (lastInteraction >= 2f) {
				PlayAnimation("SleepLoop");
			}

			
		} else if (state == "SleepyBlink" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("SleepyBlink") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("SleepyLoop");
			
		} else if (state == "TapEye" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapEye") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			
		} else if (state == "TapBody" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("TapBody") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			
			PlayAnimation("IdleLoop");
			
		}


	
	}

	void PlayAnimation(string anim) {
		yahvyBack.GetComponent<Animator> ().CrossFade (anim, 0.1f, 0, 0f);
		yahvyFront.GetComponent<Animator> ().CrossFade (anim, 0.1f, 0, 0f);
		state = anim;
	}

	void OnMouseDown() {
		PlayAnimation("TapBody");
		lastInteraction = 0f;
	}

}
