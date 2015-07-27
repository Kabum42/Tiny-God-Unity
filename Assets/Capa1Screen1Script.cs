using UnityEngine;
using System.Collections;

public class Capa1Screen1Script : MonoBehaviour {

	private GameObject[] upgrades = new GameObject[100];

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 100; i++) {

			GameObject auxGO =  Instantiate(Resources.Load("Upgrade")) as GameObject;
			auxGO.name = "Upgrade_"+i;
			auxGO.transform.parent = this.gameObject.transform;
			auxGO.transform.localPosition = new Vector3(0, auxGO.transform.localPosition.y, auxGO.transform.localPosition.z);

			upgrades[i] = auxGO;
			auxGO.SetActive(false);

		}

		//upgrades [0] = new GameObject ();
	
	}
	
	// Update is called once per frame
	void Update () {

		int num_actives = 0;
		float origin_y = 2f;

		for (int i = 0; i < 100; i++) {


			float x_position = -1.5f + num_actives % 4f;
			float y_position = -Mathf.Floor(num_actives / 4);

			upgrades[i].SetActive(true);
			upgrades[i].transform.localPosition = new Vector3(x_position*2.5f, origin_y + y_position*2.5f, upgrades[i].transform.localPosition.z);

			if (true) {
				num_actives++;
			}

		}
	
	}
}
