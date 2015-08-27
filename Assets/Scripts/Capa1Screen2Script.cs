using UnityEngine;
using System.Collections;

public class Capa1Screen2Script : MonoBehaviour {

	private GameObject miniLeft;
	private GameObject miniRight;
	private float randomCooldown = 0f;
	private float defaultRandomCooldown = 0.1f;
	private float windDirection = 0f;

	// Use this for initialization
	void Start () {

		miniLeft = GameObject.Find ("Capa1/Screen2/MiniLeft");
		miniRight = GameObject.Find ("Capa1/Screen2/MiniRight");
		miniLeft.SetActive (false);
		miniRight.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		randomCooldown -= Time.deltaTime;
		windDirection = Random.Range(-0.75f, 0.75f);

		if (randomCooldown <= 0f) {

			if (!miniLeft.activeInHierarchy && Random.Range(0f, 100f) > 95f) {
				miniLeft.SetActive(true);
				miniLeft.GetComponent<Animator> ().Play ("Transformation", 0, Random.Range(0f, 1f));
				miniLeft.transform.localPosition = new Vector3(15f, Random.Range (-7.5f, 6f), 0.1f);
			}

			if (!miniRight.activeInHierarchy && Random.Range(0f, 100f) > 95f) {
				miniRight.SetActive(true);
				miniRight.GetComponent<Animator> ().Play ("Transformation", 0, Random.Range(0f, 1f));
				miniRight.transform.localPosition = new Vector3(-15f, Random.Range (-7.5f, 6f), 0.1f);
			}

			randomCooldown = defaultRandomCooldown;

		}

		if (miniLeft.activeInHierarchy) {

			if (miniLeft.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.99f) {
				miniLeft.GetComponent<Animator> ().Play ("Transformation", 0, 0f);
			}

			miniLeft.transform.localPosition = new Vector3(miniLeft.transform.localPosition.x - Time.deltaTime*(1f - windDirection), miniLeft.transform.localPosition.y, 0.1f);

			if (miniLeft.transform.localPosition.x <= -15f) {
				miniLeft.SetActive(false);
			}

		}

		if (miniRight.activeInHierarchy) {
			
			if (miniRight.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.99f) {
				miniRight.GetComponent<Animator> ().Play ("Transformation", 0, 0f);
			}

			miniRight.transform.localPosition = new Vector3(miniRight.transform.localPosition.x + Time.deltaTime*(1f + windDirection), miniRight.transform.localPosition.y, 0.1f);

			if (miniRight.transform.localPosition.x >= 15f) {
				miniRight.SetActive(false);
			}

		}


	
	}
}
