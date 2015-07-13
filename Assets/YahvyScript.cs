using UnityEngine;
using System.Collections;

public class YahvyScript : MonoBehaviour {
	
	public GameObject yahvyBack;
	public GameObject yahvyBody;
	public GameObject yahvyFront;

	public string state = "IdleLoop";

	private float probBlinkDecSecond = 0.01f;
	private float probBlinkCooldown = 0.1f;

	// Use this for initialization
	void Start () {

		state = "IdleLoop";
		yahvyBack = gameObject.transform.FindChild ("YahvyBack").gameObject;
		yahvyBody = gameObject.transform.FindChild ("YahvyBodyModel").gameObject;
		yahvyFront = gameObject.transform.FindChild ("YahvyFront").gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {

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

		} else if (state == "IdleBlink" && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("IdleBlink") && yahvyBack.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			PlayAnimation("IdleLoop");

		}


	
	}

	void PlayAnimation(string anim) {
		yahvyBack.GetComponent<Animator> ().CrossFade (anim, 0.1f, 0, 0f);
		yahvyFront.GetComponent<Animator> ().CrossFade (anim, 0.1f, 0, 0f);
		state = anim;
	}

	void OnMouseDown() {
		Debug.Log ("LOL");
	}

}
