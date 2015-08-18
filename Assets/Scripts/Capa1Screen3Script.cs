﻿using UnityEngine;
using System.Collections;

public class Capa1Screen3Script : MonoBehaviour {

	private Producer[]producers = new Producer[9];

	private Producer servant;
	private Producer human;
	private Producer prophet;
	private Producer temple;
	private Producer ship;
	private Producer factory;
	private Producer laboratory;
	private Producer shop;
	private Producer spaceship;

	private float discovered_transparency = 0.75f;

	public Producer producerSelected = null;
	private Producer lastProducerSelected = null;
	private float selectedStatus = 0f;
	private Vector3 previousPosition;

	private Vector3 lastMousePosition;

	private AudioSource buy1;
	private AudioSource buy2;
	private AudioSource buy3;
	private AudioSource epic_ching;
	private AudioSource tap;

	// Use this for initialization
	void Start () {

		buy1 = gameObject.AddComponent<AudioSource>();
		buy1.clip = Resources.Load ("Audio/buy1") as AudioClip;
		buy1.volume = 1f;
		buy1.playOnAwake = false;

		buy2 = gameObject.AddComponent<AudioSource>();
		buy2.clip = Resources.Load ("Audio/buy2") as AudioClip;
		buy2.volume = 1f;
		buy2.playOnAwake = false;

		buy3 = gameObject.AddComponent<AudioSource>();
		buy3.clip = Resources.Load ("Audio/buy3") as AudioClip;
		buy3.volume = 1f;
		buy3.playOnAwake = false;

		epic_ching = gameObject.AddComponent<AudioSource>();
		epic_ching.clip = Resources.Load ("Audio/epic_ching") as AudioClip;
		epic_ching.volume = 1f;
		epic_ching.playOnAwake = false;

		tap = gameObject.AddComponent<AudioSource>();
		tap.clip = Resources.Load ("Audio/tap") as AudioClip;
		tap.volume = 1f;
		tap.playOnAwake = false;


		servant = new Producer (this.gameObject, 0, "Servant", Lang.SERVANT_NAME);
		human = new Producer (this.gameObject, 1, "Human", Lang.HUMAN_NAME);
		prophet = new Producer (this.gameObject, 2, "Prophet", Lang.PROPHET_NAME);
		temple = new Producer (this.gameObject, 3, "Temple", Lang.TEMPLE_NAME);
		ship = new Producer (this.gameObject, 4, "Ship", Lang.SHIP_NAME);
		factory = new Producer (this.gameObject, 5, "Factory", Lang.FACTORY_NAME);
		laboratory = new Producer (this.gameObject, 6, "Laboratory", Lang.LABORATORY_NAME);
		shop = new Producer (this.gameObject, 7, "Shop", Lang.SHOP_NAME);
		spaceship = new Producer (this.gameObject, 8, "Spaceship", Lang.SPACESHIP_NAME);

		producers [0] = servant;
		producers [1] = human;
		producers [2] = prophet;
		producers [3] = temple;
		producers [4] = ship;
		producers [5] = factory;
		producers [6] = laboratory;
		producers [7] = shop;
		producers [8] = spaceship;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (producerSelected != null  && selectedStatus < 1f) {
			selectedStatus += Time.deltaTime*5f;
			if (selectedStatus > 1f) { 

				selectedStatus = 2f; 
				previousPosition = producerSelected.root.transform.localPosition;
				producerSelected.root.GetComponent<Animator> ().CrossFade ("Opening", 0f, 0, 0f);

			}
		}

		if (producerSelected == null  && selectedStatus > 0f) {
			selectedStatus -= Time.deltaTime*5f;
			float x_value = Mathf.Lerp(lastProducerSelected.root.transform.localPosition.x, previousPosition.x, Time.deltaTime*10f);
			float y_value = Mathf.Lerp(lastProducerSelected.root.transform.localPosition.y, previousPosition.y, Time.deltaTime*10f);
			lastProducerSelected.root.transform.localPosition = new Vector3(x_value, y_value, 0);
			if (selectedStatus < 0f) { 
				selectedStatus = 0f; 
				lastProducerSelected.root.transform.localPosition = new Vector3(previousPosition.x, previousPosition.y, 0);
			}
		}

		// THIS REGULAR COMPROBATION IS SPECIAL, HAS NO PREVIOUS PRODUCER
		RegularComprobation ("meh", ref servant);

		// OTHER REGULAR COMPROBATIONS
		for (int i = 1; i < producers.Length; i++) {
			RegularComprobation (producers[i-1].status, ref producers[i]);
		}

		for (int i = 0; i < producers.Length; i++) {

			// CHECK FOR BUYINGS
			if (producers[i].status != "unexistant" && producers[i].status != "undiscovered" && ClickedOn (producers[i].buyButton)) {	
				if (checkCanBuy(producers[i])) {
					buy (producers[i]);
				}
			} else {

				if (producerSelected == null) {
					
					if (selectedStatus == 0f) {
							
						if (producers[i].status != "unexistant" && producers[i].status != "undiscovered" && ClickedOn (producers[i].hb_head)) {
							producerSelected = producers[i];
							lastProducerSelected = producers[i];
							tap.Play();
						}

					}
					
				} else {
					
					if (ClickedOn (producerSelected.hb_head) && producers[i] == producerSelected && selectedStatus == 2f) {
						producerSelected.root.GetComponent<Animator> ().CrossFade ("Opening2", 0f, 0, 0f);
						producerSelected = null;
						tap.Play();
					}
					
				}

			}

		}



	}

	private void RegularComprobation(string previousStatus, ref Producer producer) {

		// UNEXISTANT TO UNDISCOVERED
		if (producer.status == "unexistant" && (previousStatus != "undiscovered" && previousStatus != "unexistant")) {
			producer.root.SetActive(true);
			producer.status = "undiscovered";
		} 
		// UNDISCOVERED/BUYABLE TO DISCOVERED
		else if ((producer.status == "undiscovered" && GlobalData.thisState.totalLove >= GlobalData.getBaseCost (producer.langCode)) ||
		           (producer.status == "buyable" && GlobalData.thisState.love < Mathf.Floor(GlobalData.getBaseCost (producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode])))) {
			producer.status = "discovered";
		} 
		// DISCOVERED TO BUYABLE
		else if (producer.status == "discovered" && GlobalData.thisState.love >= Mathf.Floor (GlobalData.getBaseCost (producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode]))) {
			producer.status = "buyable";
		}

		// UPDATE TEXT (LANGUAGE), NUMBER AND COST
		if (producer.status != "unexistant" && producer.status != "undiscovered") {
			producer.text.GetComponent<TextMesh> ().text = Lang.getText(producer.langCode);
			producer.number.GetComponent<TextMesh> ().text = ""+GlobalData.thisState.values[producer.langCode];
			producer.cost.GetComponent<TextMesh> ().text = ""+GlobalData.FormattedNumber(Mathf.Floor (GlobalData.getBaseCost (producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode])));
		}

		// ANIMATIONS: LOCKED TO UNLOCKING
		if (!producer.number.activeInHierarchy && (producer.status != "unexistant" && producer.status != "undiscovered")) {

			producer.number.SetActive(true);
			producer.cost.SetActive(true);
			producer.loveIcon.SetActive(true);
			producer.icon_producer.SetActive(true);
			
			producer.buyButton.GetComponent<Animator> ().Play ("Unlocking", 0, 0f);
			producer.icon.GetComponent<Animator> ().Play ("Unlocking", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Unlocking", 0, 0f);

			epic_ching.Play();

		}

		// ANIMATIONS: UNLOCKING TO AVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Unlocking") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			producer.buyButton.GetComponent<Animator> ().Play ("Available", 0, 0f);
			producer.icon.GetComponent<Animator> ().Play ("Available", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Available", 0, 0f);
		}

		// ANIMATIONS: BUYING TO AVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Buying") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			producer.buyButton.GetComponent<Animator> ().Play ("Available", 0, 0f);
			producer.icon.GetComponent<Animator> ().Play ("Available", 0, 0f);
		}

		// ANIMATIONS: AVAILABLE TO CHANGING (NOT AVAILABLE)
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Available") && !checkCanBuy(producer)) {
			producer.buyButton.GetComponent<Animator> ().Play ("Changing", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Changing", 0, 0f);
		}

		// ANIMATIONS: CHANGING (NOT AVAILABLE) TO UNAVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Changing") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			producer.buyButton.GetComponent<Animator> ().Play ("Unavailable", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Unavailable", 0, 0f);
		}

		// ANIMATIONS: UNAVAILABLE TO CHANGING2 (AVAILABLE)
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Unavailable") && checkCanBuy(producer)) {
			producer.buyButton.GetComponent<Animator> ().Play ("Changing2", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Changing2", 0, 0f);
		}

		// ANIMATIONS: CHANGING2 (AVAILABLE) TO AVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Changing2") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
			producer.buyButton.GetComponent<Animator> ().Play ("Available", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Available", 0, 0f);
		}

		producer.text.GetComponent<TextMesh> ().fontSize = 75;

		while (producer.text.GetComponent<MeshRenderer> ().bounds.size.x > 4.3f) {
			producer.text.GetComponent<TextMesh> ().fontSize -= 1;
		}

		producer.cost.GetComponent<TextMesh> ().fontSize = 50;

		while (producer.cost.GetComponent<MeshRenderer> ().bounds.size.x > 3.8f) {
			producer.cost.GetComponent<TextMesh> ().fontSize -= 1;
		}

		// CHANGE TRANSPARENCIES
		/*
		float producerAlpha = 1f;
		
		if (selectedStatus == 0f) {
			producerAlpha = 1f;
		}


		if (producer.status == "undiscovered") {
			//icon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency*producerAlpha);
			producer.text.GetComponent<TextMesh> ().color = new Color(producer.text.GetComponent<TextMesh> ().color.r, producer.text.GetComponent<TextMesh> ().color.g, producer.text.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
			producer.number.GetComponent<TextMesh> ().color = new Color(producer.number.GetComponent<TextMesh> ().color.r, producer.number.GetComponent<TextMesh> ().color.g, producer.number.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
		} else if (producer.status == "discovered") {
			//icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			producer.text.GetComponent<TextMesh> ().color = new Color(producer.text.GetComponent<TextMesh> ().color.r, producer.text.GetComponent<TextMesh> ().color.g, producer.text.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
			producer.number.GetComponent<TextMesh> ().color = new Color(producer.number.GetComponent<TextMesh> ().color.r, producer.number.GetComponent<TextMesh> ().color.g, producer.number.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
		} else if (producer.status == "buyable") {
			//icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			producer.text.GetComponent<TextMesh> ().color = new Color(producer.text.GetComponent<TextMesh> ().color.r, producer.text.GetComponent<TextMesh> ().color.g, producer.text.GetComponent<TextMesh> ().color.b, 1f*producerAlpha);
			producer.number.GetComponent<TextMesh> ().color = new Color(producer.number.GetComponent<TextMesh> ().color.r, producer.number.GetComponent<TextMesh> ().color.g, producer.number.GetComponent<TextMesh> ().color.b, 1f*producerAlpha);
		}
		*/
		
	}

	private bool checkCanBuy(Producer producer) {

		if (GlobalData.thisState.love >= Mathf.Floor (GlobalData.getBaseCost (producer.langCode) * Mathf.Pow (1.1f, GlobalData.thisState.values [producer.langCode]))) {
			
			return true;
			
		} else {

			return false;

		}

	}

	private void buy (Producer producer) {

		GlobalData.thisState.love -= Mathf.Floor (GlobalData.getBaseCost(producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode]));
		GlobalData.thisState.values[producer.langCode]++;
		
		float aux = Random.Range(0f, 1f);
		
		producer.buyButton.GetComponent<Animator> ().Play ("Buying", 0, 0f);
		producer.icon.GetComponent<Animator> ().Play ("Buying", 0, 0f);
		
		if (aux > 2f/3f) {
			buy1.Play();
		} else if (aux > 1f/3f) {
			buy2.Play();
		}
		else {
			buy3.Play();
		}

	}

	private bool ClickedOn(GameObject target) {
		
		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			
			if (Input.GetMouseButtonDown(0)) { 

				lastMousePosition = Input.mousePosition;

			} else if (Input.GetMouseButtonUp(0)) { 

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

				// HEAD MASK
				//hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));
				RaycastHit2D[] hits = Physics2D.RaycastAll(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));

				for (int i = 0; i < hits.Length; i++) {

					Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);

					RaycastHit2D[] hits2 = Physics2D.RaycastAll(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));

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
					
					// HEAD MASK
					//hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));
					RaycastHit2D[] hits = Physics2D.RaycastAll(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));
					
					for (int i = 0; i < hits.Length; i++) {
						
						Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
						
						RaycastHit2D[] hits2 = Physics2D.RaycastAll(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));
						
						for (int j = 0; j < hits2.Length; j++) {
							
							if (hits[j].collider.gameObject == hits2[j].collider.gameObject && hits[j].collider.gameObject == target) { return true; }
							
						}
						
					}

				}

			}
			
		}

		return false;

	}


	public class Producer {

		public GameObject root;
		public string status;
		public int langCode;
		public GameObject text;
		public GameObject number;
		public GameObject loveIcon;
		public GameObject cost;
		public GameObject buyButton;
		public GameObject icon;
		public GameObject screen;
		public GameObject hb_head;
		public GameObject icon_producer;


		public Producer(GameObject parent, int position, string name, int langAux) {

			status = "unexistant";

			root =  Instantiate(Resources.Load("Producer")) as GameObject;
			root.name = name;
			root.transform.parent = parent.transform;
			root.transform.localPosition = new Vector3(0, root.transform.localPosition.y +3f -2.5f*position, root.transform.localPosition.z);

			text = root.gameObject.transform.FindChild("Text").gameObject;
			number = root.gameObject.transform.FindChild("Number").gameObject;
			number.SetActive(false);
			loveIcon = root.gameObject.transform.FindChild("LoveIcon").gameObject;
			loveIcon.SetActive(false);
			cost = root.gameObject.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			buyButton = root.gameObject.transform.FindChild("BuyButton").gameObject;
			icon = root.gameObject.transform.FindChild("Icon").gameObject;
			screen = root.gameObject.transform.FindChild("Screen").gameObject;
			hb_head = root.gameObject.transform.FindChild("hb_head").gameObject;
			icon_producer = root.gameObject.transform.FindChild("Icon/icon_base/icon_producer").gameObject;

			if (langAux == Lang.SERVANT_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/servant"); }
			if (langAux == Lang.HUMAN_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/human"); }
			if (langAux == Lang.PROPHET_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/prophet"); }
			if (langAux == Lang.TEMPLE_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); }
			if (langAux == Lang.SHIP_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); }
			if (langAux == Lang.FACTORY_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); }
			if (langAux == Lang.LABORATORY_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); }
			if (langAux == Lang.SHOP_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); }
			if (langAux == Lang.SPACESHIP_NAME) { icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); }

			icon_producer.SetActive(false);

			root.SetActive(false);

			langCode = langAux;

		}

	}

	private void Adjust(ref Producer producer) {
		
		if (producerSelected == producer) {

			if (selectedStatus == 2f) {
				producer.root.transform.localPosition = new Vector3(Mathf.Lerp(producer.root.transform.localPosition.x, 0f, Time.deltaTime*10f), Mathf.Lerp(producer.root.transform.localPosition.y, 3f -producer.root.transform.parent.localPosition.y , Time.deltaTime*10f), 0);
			}

		} else if (lastProducerSelected == producer) {

		} else {
			
			float alphaValue = selectedStatus;
			if (alphaValue > 1f)  { alphaValue = 1f; }
			alphaValue = 1f - alphaValue;

			foreach (Transform child in producer.root.transform) {

				if (child.gameObject.GetComponent<TextMesh>() != null) {
					child.gameObject.GetComponent<TextMesh>().color = new Color(child.gameObject.GetComponent<TextMesh>().color.r, child.gameObject.GetComponent<TextMesh>().color.g, child.gameObject.GetComponent<TextMesh>().color.b, alphaValue);
				}

				if (child.gameObject.GetComponent<SpriteRenderer>() != null) {
					child.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alphaValue);
				}

			}

			foreach (Transform child in producer.icon.transform) {
				
				if (child.gameObject.GetComponent<SpriteRenderer>() != null) {
					child.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alphaValue);
				}
				
			}

			producer.icon_producer.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alphaValue);

			foreach (Transform child in producer.screen.transform) {
				
				if (child.gameObject.GetComponent<SpriteRenderer>() != null) {
					child.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alphaValue);
				}
				
			}

			foreach (Transform child in producer.buyButton.transform) {
				
				if (child.gameObject.GetComponent<SpriteRenderer>() != null) {
					child.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alphaValue);
				}
				
			}
			
			//producer.hb_head.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alphaValue);
			
		}
		
	}

	void LateUpdate() {

		for (int i = 0; i < producers.Length; i++) {
			
			// ADJUST ALPHA AND POSITION
			Adjust(ref producers[i]);
			
		}

	}

}
