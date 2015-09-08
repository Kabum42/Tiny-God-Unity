using UnityEngine;
using System.Collections;

public class Capa1Screen2Script : MonoBehaviour {

	private GameObject miniLeft;
	private GameObject miniRight;
	private float randomCooldown = 0f;
	private float defaultRandomCooldown = 0.1f;
	private float windDirection = 0f;

	private bool leftActive = false;
	private bool rightActive = false;
	private float leftTime = 0f;
	private float rightTime = 0f;
	private string leftAnimation = "Transformation";
	private string rightAnimation = "Transformation";

	// Use this for initialization
	void Start () {

		miniLeft = GameObject.Find ("Capa1/Screen2/MiniLeft");
		miniRight = GameObject.Find ("Capa1/Screen2/MiniRight");
		miniLeft.SetActive (false);
		miniRight.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Camera.main.GetComponent<MainScript> ().capa1.transform.localPosition.x > -18f && Camera.main.GetComponent<MainScript> ().capa1.transform.localPosition.x < 18) {

			if (rightActive || leftActive) {

				if (leftActive && !miniLeft.activeInHierarchy) {
					miniLeft.SetActive (true);
					miniLeft.GetComponent<Animator> ().Play (leftAnimation, 0, leftTime);
				}

				if (rightActive && !miniRight.activeInHierarchy) {
					miniRight.SetActive (true);
					miniRight.GetComponent<Animator> ().Play (rightAnimation, 0, rightTime);
				}

			}

		} else {

			if (miniLeft.activeInHierarchy || miniRight.activeInHierarchy) {

				leftTime = miniLeft.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime;
				rightTime = miniRight.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime;

				if (miniLeft.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Transformation")) {
					leftAnimation = "Transformation";
				}
				else if (miniLeft.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Transformation2")) {
					leftAnimation = "Transformation2";
				}

				if (miniRight.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Transformation")) {
					rightAnimation = "Transformation";
				}
				else if (miniRight.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Transformation2")) {
					rightAnimation = "Transformation2";
				}

				miniLeft.SetActive (false);
				miniRight.SetActive (false);
				
			}

		}

		randomCooldown -= Time.deltaTime;
		windDirection = Random.Range(-0.75f, 0.75f);

		if (randomCooldown <= 0f) {

			if (!leftActive && Random.Range(0f, 100f) > 95f) {

				leftActive = true;
				miniLeft.transform.localPosition = new Vector3(15f, Random.Range (-7.5f, 6f), 0.1f);

				float size = Random.Range(0.75f, 1.25f);

				if (Random.Range(0f, 100f) > 50f) {
					miniLeft.transform.localScale = new Vector3(size, miniLeft.transform.localScale.y, miniLeft.transform.localScale.z);
				}
				else {
					miniLeft.transform.localScale = new Vector3(-size, miniLeft.transform.localScale.y, miniLeft.transform.localScale.z);
				}


				if (Random.Range(0f, 100f) > 50f) {
					miniLeft.transform.localScale = new Vector3(miniLeft.transform.localScale.x, size, miniLeft.transform.localScale.z);
				}
				else {
					miniLeft.transform.localScale = new Vector3(miniLeft.transform.localScale.x, -size, miniLeft.transform.localScale.z);
				}


				if (Random.Range(0f, 100f) > 50f) {
					miniLeft.GetComponent<Animator> ().Play ("Transformation", 0, Random.Range(0f, 1f));
				}
				else {
					miniLeft.GetComponent<Animator> ().Play ("Transformation2", 0, Random.Range(0f, 1f));
				}

			}

			if (!rightActive && Random.Range(0f, 100f) > 95f) {

				rightActive = true;
				miniRight.transform.localPosition = new Vector3(-15f, Random.Range (-7.5f, 6f), 0.1f);

				float size = Random.Range(0.75f, 1.25f);
				
				if (Random.Range(0f, 100f) > 50f) {
					miniRight.transform.localScale = new Vector3(size, miniRight.transform.localScale.y, miniRight.transform.localScale.z);
				}
				else {
					miniRight.transform.localScale = new Vector3(-size, miniRight.transform.localScale.y, miniRight.transform.localScale.z);
				}
				
				
				if (Random.Range(0f, 100f) > 50f) {
					miniRight.transform.localScale = new Vector3(miniRight.transform.localScale.x, size, miniRight.transform.localScale.z);
				}
				else {
					miniRight.transform.localScale = new Vector3(miniRight.transform.localScale.x, -size, miniRight.transform.localScale.z);
				}


				if (Random.Range(0f, 100f) > 50f) {
					miniRight.GetComponent<Animator> ().Play ("Transformation", 0, Random.Range(0f, 1f));
				}
				else {
					miniRight.GetComponent<Animator> ().Play ("Transformation2", 0, Random.Range(0f, 1f));
				}

			}

			randomCooldown = defaultRandomCooldown;

		}

		if (miniLeft.activeInHierarchy) {

			if (miniLeft.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.99f) {

				if (miniLeft.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Transformation")) {
					miniLeft.GetComponent<Animator> ().Play ("Transformation", 0, 0f);
				}
				else if (miniLeft.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Transformation2")) {
					miniLeft.GetComponent<Animator> ().Play ("Transformation2", 0, 0f);
				}

			}

		}

		if (miniRight.activeInHierarchy) {
			
			if (miniRight.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.99f) {

				if (miniRight.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Transformation")) {
					miniRight.GetComponent<Animator> ().Play ("Transformation", 0, 0f);
				}
				else if (miniRight.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Transformation2")) {
					miniRight.GetComponent<Animator> ().Play ("Transformation2", 0, 0f);
				}

			}

		}


		miniLeft.transform.localPosition = new Vector3(miniLeft.transform.localPosition.x - Time.deltaTime*(1f - windDirection), miniLeft.transform.localPosition.y, 0.1f);
		
		if (miniLeft.transform.localPosition.x <= -15f) {
			leftActive = false;
			miniLeft.SetActive(false);
		}


		miniRight.transform.localPosition = new Vector3(miniRight.transform.localPosition.x + Time.deltaTime*(1f + windDirection), miniRight.transform.localPosition.y, 0.1f);

		if (miniRight.transform.localPosition.x >= 15f) {
			rightActive = false;
			miniRight.SetActive(false);
		}


	
	}
}
