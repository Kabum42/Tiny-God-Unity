﻿using UnityEngine;
using System.Collections;

public class Capa1Screen3Script : MonoBehaviour {
	
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

	private GameObject fogUp;
	private GameObject fogDown;

	// Use this for initialization
	void Start () {

		//Lang.setLanguage (Lang.SPANISH_VALUE);

		fogUp = GameObject.Find ("Capa1/Screen3/FogUp");
		fogDown = GameObject.Find ("Capa1/Screen3/FogDown");

		buy1 = gameObject.AddComponent<AudioSource>();
		buy1.clip = Resources.Load ("Audio/buy1") as AudioClip;
		buy1.volume = 0.8f;
		buy1.playOnAwake = false;

		buy2 = gameObject.AddComponent<AudioSource>();
		buy2.clip = Resources.Load ("Audio/buy2") as AudioClip;
		buy2.volume = 0.8f;
		buy2.playOnAwake = false;

		buy3 = gameObject.AddComponent<AudioSource>();
		buy3.clip = Resources.Load ("Audio/buy3") as AudioClip;
		buy3.volume = 0.8f;
		buy3.playOnAwake = false;

		epic_ching = gameObject.AddComponent<AudioSource>();
		epic_ching.clip = Resources.Load ("Audio/epic_ching") as AudioClip;
		epic_ching.volume = 0.9f;
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
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Camera.main.GetComponent<MainScript> ().capa1.transform.localPosition.x < -8f && Camera.main.GetComponent<MainScript> ().capa1.transform.localPosition.x > -32) {

			if (!fogUp.activeInHierarchy) {
				
				fogUp.SetActive (true);
				fogDown.SetActive (true);

			}

			fogUp.transform.localPosition = new Vector3 (0, 6.5f - this.gameObject.transform.localPosition.y, -5);
			fogDown.transform.localPosition = new Vector3 (0, -7.76f - this.gameObject.transform.localPosition.y, -5);

			if (producerSelected != null && selectedStatus < 2.5f) {
				selectedStatus += Time.deltaTime * 8f;
				if (selectedStatus > 1f && selectedStatus < 2f) { 
					
					selectedStatus = 2f; 
					previousPosition = producerSelected.root.transform.localPosition;

					producerSelected.board.SetActive (true);
					producerSelected.buyButton.SetActive (true);
					producerSelected.icon.SetActive (true);
					producerSelected.screen.SetActive (true);

					if (producerSelected.staticClosedU.activeInHierarchy) {

						producerSelected.buyButton.GetComponent<Animator> ().Play ("Unavailable", 0, 0f);
						//producerSelected.icon.GetComponent<Animator>().Play ("Unavailable", 0, 0f);
						producerSelected.screen.GetComponent<Animator> ().Play ("Unavailable", 0, 0f);

					} else if (producerSelected.staticClosedA.activeInHierarchy) {

						producerSelected.buyButton.GetComponent<Animator> ().Play ("Available", 0, 0f);
						producerSelected.icon.GetComponent<Animator> ().Play ("Available", 0, 0f);
						producerSelected.screen.GetComponent<Animator> ().Play ("Available", 0, 0f);

					}

					producerSelected.staticClosedU.SetActive (false);
					producerSelected.staticClosedA.SetActive (false);


					producerSelected.board.GetComponent<Animator> ().CrossFade ("Opening", 0f, 0, 0f);
					producerSelected.info.SetActive (true);
					producerSelected.info.GetComponent<TextMesh> ().color = new Color (producerSelected.info.GetComponent<TextMesh> ().color.r, producerSelected.info.GetComponent<TextMesh> ().color.g, producerSelected.info.GetComponent<TextMesh> ().color.b, 0f);
					
				}
				
				if (selectedStatus > 2.5f) {
					selectedStatus = 2.5f;
				}
			}
			
			if (producerSelected == null && selectedStatus > 0f) {
				selectedStatus -= Time.deltaTime * 8f;
				float x_value = Mathf.Lerp (lastProducerSelected.root.transform.localPosition.x, previousPosition.x, Time.deltaTime * 10f);
				float y_value = Mathf.Lerp (lastProducerSelected.root.transform.localPosition.y, previousPosition.y, Time.deltaTime * 10f);
				lastProducerSelected.root.transform.localPosition = new Vector3 (x_value, y_value, 0);
				lastProducerSelected.info.GetComponent<TextMesh> ().color = new Color (lastProducerSelected.info.GetComponent<TextMesh> ().color.r, lastProducerSelected.info.GetComponent<TextMesh> ().color.g, lastProducerSelected.info.GetComponent<TextMesh> ().color.b, Mathf.Lerp (lastProducerSelected.info.GetComponent<TextMesh> ().color.a, 0f, Time.deltaTime * 50f));
				if (selectedStatus < 0f) { 
					selectedStatus = 0f; 
					lastProducerSelected.root.transform.localPosition = new Vector3 (previousPosition.x, previousPosition.y, 0);
					lastProducerSelected.info.GetComponent<TextMesh> ().color = new Color (lastProducerSelected.info.GetComponent<TextMesh> ().color.r, lastProducerSelected.info.GetComponent<TextMesh> ().color.g, lastProducerSelected.info.GetComponent<TextMesh> ().color.b, 0f);
				}
			}

		} else {

			if (fogUp.activeInHierarchy) {

				fogUp.SetActive (false);
				fogDown.SetActive(false);

				// AQUI SE PUEDEN DESACTIVAR TODOS LOS PRODUCERS, DE MOMENTO NO PARECE SER NECESARIO

			}

		}

		// THIS REGULAR COMPROBATION IS SPECIAL, HAS NO PREVIOUS PRODUCER
		RegularComprobation ("meh", ref servant);

		// OTHER REGULAR COMPROBATIONS
		RegularComprobation (servant.status, ref human);
		RegularComprobation (human.status, ref prophet);
		RegularComprobation (prophet.status, ref temple);
		RegularComprobation (temple.status, ref ship);
		RegularComprobation (ship.status, ref factory);
		RegularComprobation (factory.status, ref laboratory);
		RegularComprobation (laboratory.status, ref shop);
		RegularComprobation (shop.status, ref spaceship);

		if (fogUp.activeInHierarchy) {
			ClickingComprobation (ref servant);
			ClickingComprobation (ref human);
			ClickingComprobation (ref prophet);
			ClickingComprobation (ref temple);
			ClickingComprobation (ref ship);
			ClickingComprobation (ref factory);
			ClickingComprobation (ref laboratory);
			ClickingComprobation (ref shop);
			ClickingComprobation (ref spaceship);
		}

	}

	private void ClickingComprobation(ref Producer producer) {

		if (producer.status != "unexistant" && producer.status != "undiscovered" && (ClickedOn (producer.staticClosedA) || ClickedOn (producer.staticClosedU) || ClickedOn(producer.buyButton)) && (producerSelected == null || producerSelected == producer)) {	
			if (checkCanBuy(producer)) { buy (producer); }
		} else {	

			if (producerSelected == null) {
				if (selectedStatus == 0f) {
					if (producer.status != "unexistant" && producer.status != "undiscovered" && ClickedOn (producer.root)) {
						producerSelected = producer;
						lastProducerSelected = producer;
						tap.Play();
					}
				}
			} else {
				if (ClickedOn (producerSelected.root) && producer == producerSelected && selectedStatus == 2.5f) {

					producerSelected.board.GetComponent<Animator> ().CrossFade ("Opening2", 0f, 0, 0f);
					producerSelected = null;
					tap.Play();

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

			producer.staticClosedL.SetActive(false);

			producer.board.SetActive(true);
			producer.buyButton.SetActive(true);
			producer.icon.SetActive(true);
			producer.screen.SetActive(true);

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

			producer.board.SetActive(false);
			producer.buyButton.SetActive(false);
			producer.icon.SetActive(false);
			producer.screen.SetActive(false);

			producer.staticClosedA.SetActive(true);

		}

		// ANIMATIONS: BUYING TO AVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Buying") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			if (producerSelected == producer) {

				producer.buyButton.GetComponent<Animator> ().Play("Available", 0, 0f);

			} else {

				producer.board.SetActive(false);
				producer.buyButton.SetActive(false);
				producer.icon.SetActive(false);
				producer.screen.SetActive(false);
				
				producer.staticClosedA.SetActive(true);

			}

		}

		// ANIMATIONS: AVAILABLE TO CHANGING (NOT AVAILABLE)
		if ((producer.staticClosedA.activeInHierarchy || (producerSelected == producer && producerSelected.buyButton.GetComponent<Animator>().GetCurrentAnimatorStateInfo (0).IsName ("Available"))) && !checkCanBuy(producer)) {

			producer.staticClosedA.SetActive(false);

			producer.board.SetActive(true);
			producer.buyButton.SetActive(true);
			producer.icon.SetActive(true);
			producer.screen.SetActive(true);

			producer.buyButton.GetComponent<Animator> ().Play ("Changing", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Changing", 0, 0f);
			producer.icon.GetComponent<Animator> ().Play ("Available", 0, 0f);

		}

		// ANIMATIONS: CHANGING (NOT AVAILABLE) TO UNAVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Changing") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			if (producerSelected == producer) {

				producer.buyButton.GetComponent<Animator> ().Play ("Unavailable", 0, 0f);
				producer.screen.GetComponent<Animator> ().Play ("Unavailable", 0, 0f);

			} else {

				producer.staticClosedU.SetActive(true);

				producer.board.SetActive(false);
				producer.buyButton.SetActive(false);
				producer.icon.SetActive(false);
				producer.screen.SetActive(false);

			}


		}

		// ANIMATIONS: UNAVAILABLE TO CHANGING2 (AVAILABLE)
		if ((producer.staticClosedU.activeInHierarchy || (producerSelected == producer && producerSelected.buyButton.GetComponent<Animator>().GetCurrentAnimatorStateInfo (0).IsName ("Unavailable"))) && checkCanBuy(producer)) {

			producer.staticClosedU.SetActive(false);
			
			producer.board.SetActive(true);
			producer.buyButton.SetActive(true);
			producer.icon.SetActive(true);
			producer.screen.SetActive(true);

			producer.buyButton.GetComponent<Animator> ().Play ("Changing2", 0, 0f);
			producer.screen.GetComponent<Animator> ().Play ("Changing2", 0, 0f);
			producer.icon.GetComponent<Animator> ().Play ("Available", 0, 0f);

		}

		// ANIMATIONS: CHANGING2 (AVAILABLE) TO AVAILABLE
		if (producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Changing2") && producer.buyButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			if (producerSelected == producer) {

				producer.buyButton.GetComponent<Animator> ().Play ("Available", 0, 0f);
				producer.screen.GetComponent<Animator> ().Play ("Available", 0, 0f);

			} 
			else {

				producer.board.SetActive(false);
				producer.buyButton.SetActive(false);
				producer.icon.SetActive(false);
				producer.screen.SetActive(false);
				
				producer.staticClosedA.SetActive(true);

			}


		}

		// ANIMATIONS OPENING2
		if (producer.board.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Opening2") && producer.board.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

			if (checkCanBuy(producer)) {
				producer.staticClosedA.SetActive(true);
			}
			else {
				producer.staticClosedU.SetActive(true);
			}

			producer.board.SetActive(false);
			producer.buyButton.SetActive(false);
			producer.icon.SetActive(false);
			producer.screen.SetActive(false);
			
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

		producer.staticClosedA.SetActive (false);

		producer.board.SetActive (true);
		producer.buyButton.SetActive (true);
		producer.icon.SetActive (true);
		producer.screen.SetActive (true);


		producer.buyButton.GetComponent<Animator> ().Play ("Buying", 0, 0f);
		producer.screen.GetComponent<Animator> ().Play ("Available", 0, 0f);
		producer.icon.GetComponent<Animator> ().Play ("Unlocking", 0, 0f);

		float aux = Random.Range(0f, 1f);

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
				RaycastHit2D[] hits = Physics2D.RaycastAll(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
				
				for (int i = 0; i < hits.Length; i++) {
					
					Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
					
					RaycastHit2D[] hits2 = Physics2D.RaycastAll(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
					
					for (int j = 0; j < hits2.Length; j++) {

						if (j < hits.Length) {
							if (hits[j].collider.gameObject == hits2[j].collider.gameObject && hits[j].collider.gameObject == target) { return true; }
						}
						
					}
					
				}

				// HEAD MASK
				//hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));
				hits = Physics2D.RaycastAll(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));

				for (int i = 0; i < hits.Length; i++) {

					Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);

					RaycastHit2D[] hits2 = Physics2D.RaycastAll(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("HeadMask"));

					for (int j = 0; j < hits2.Length; j++) {

						if (j < hits.Length) {
							if (hits[j].collider.gameObject == hits2[j].collider.gameObject && hits[j].collider.gameObject == target) { return true; }
						}

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
		public int description;
		public GameObject text;
		public GameObject number;
		public GameObject loveIcon;
		public GameObject cost;

		public GameObject board;
		public GameObject buyButton;
		public GameObject icon;
		public GameObject screen;

		public GameObject hb_head;

		public GameObject icon_producer;

		public GameObject info;

		public GameObject staticClosedL;
		public GameObject staticClosedU;
		public GameObject staticClosedA;


		public Producer(GameObject parent, int position, string name, int langAux) {

			status = "unexistant";

			root =  Instantiate(Resources.Load("Producer")) as GameObject;
			root.name = name;
			root.transform.parent = parent.transform;
			root.transform.localPosition = new Vector3(0, root.transform.localPosition.y +3f -2.5f*position, root.transform.localPosition.z);

			text = root.gameObject.transform.FindChild("Text").gameObject;
			number = root.gameObject.transform.FindChild("Number").gameObject;
			number.SetActive(false);
			cost = root.gameObject.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);

			board = root.gameObject.transform.FindChild("Pro_Board").gameObject;
			board.SetActive(false);
			buyButton = root.gameObject.transform.FindChild("Pro_Button").gameObject;
			buyButton.SetActive(false);
			screen = root.gameObject.transform.FindChild("Screen").gameObject;
			screen.SetActive(false);
			icon = root.gameObject.transform.FindChild("Pro_Icon").gameObject;
			icon.SetActive(false);

			loveIcon = root.gameObject.transform.FindChild("LoveIcon").gameObject;
			Material mat = Instantiate(loveIcon.GetComponent<SpriteRenderer>().material) as Material;
			loveIcon.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			loveIcon.SetActive(false);

			hb_head = root.gameObject.transform.FindChild("Pro_Board/hb_pix_board").gameObject;
			hb_head.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_botcorner_right").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_botcorner_left").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_pix_foot").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_topcorner_right").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_topcorner_left").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_pix_section").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Board/hb_pix_panel").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;

			root.gameObject.transform.FindChild("Pro_Icon/icon_shine").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Icon/icon_heart").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Icon/icon_heartside").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Icon/icon_cover").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Icon/icon_base").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Icon/icon_side").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			icon_producer = root.gameObject.transform.FindChild("Pro_Icon/icon_base/icon_producer").gameObject;
			icon_producer.GetComponent<SpriteRenderer>().sharedMaterial = mat;

			root.gameObject.transform.FindChild("Screen/icon_cover").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Screen/sc_side").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Screen/sc_on").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Screen/sc_off").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;

			root.gameObject.transform.FindChild("Pro_Button/bb_plus").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Button/bb_plus_side").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Button/bb_cross").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Button/icon_cover").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Button/bb_lock").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Button/bb_square").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Pro_Button/bb_square_side").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;

			info = root.gameObject.transform.FindChild("Info").gameObject;

			staticClosedL = root.gameObject.transform.FindChild("Closed_Lock").gameObject;
			staticClosedL.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			//staticClosedL.SetActive(false);

			staticClosedA = root.gameObject.transform.FindChild("Closed_Available").gameObject;
			staticClosedA.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Closed_Available/icon_producer").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			staticClosedA.SetActive(false);

			staticClosedU = root.gameObject.transform.FindChild("Closed_Unavailable").gameObject;
			staticClosedU.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			root.gameObject.transform.FindChild("Closed_Unavailable/icon_producer").gameObject.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			staticClosedU.SetActive(false);

			if (langAux == Lang.SERVANT_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
				description = Lang.SERVANT_DESCRIPTION;
			}
			if (langAux == Lang.HUMAN_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
				description = Lang.HUMAN_DESCRIPTION;
			}
			if (langAux == Lang.PROPHET_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
				description = Lang.PROPHET_DESCRIPTION;
			}
			if (langAux == Lang.TEMPLE_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/temple"); 
				description = Lang.TEMPLE_DESCRIPTION;
			}
			if (langAux == Lang.SHIP_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/ship");
				description = Lang.SHIP_DESCRIPTION;
			}
			if (langAux == Lang.FACTORY_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/factory"); 
				description = Lang.FACTORY_DESCRIPTION;
			}
			if (langAux == Lang.LABORATORY_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/laboratory"); 
				description = Lang.LABORATORY_DESCRIPTION;
			}
			if (langAux == Lang.SHOP_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
				description = Lang.SHOP_DESCRIPTION;
			}
			if (langAux == Lang.SPACESHIP_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001");
				description = Lang.SPACESHIP_DESCRIPTION;
			}

			root.gameObject.transform.FindChild("Closed_Available/icon_producer").gameObject.GetComponent<SpriteRenderer> ().sprite = icon_producer.GetComponent<SpriteRenderer> ().sprite; 
			root.gameObject.transform.FindChild("Closed_Unavailable/icon_producer").gameObject.GetComponent<SpriteRenderer> ().sprite = icon_producer.GetComponent<SpriteRenderer> ().sprite; 


			icon_producer.SetActive(false);
			info.SetActive(false);

			root.SetActive(false);

			langCode = langAux;

		}

	}

	private void smartText(string original, GameObject target) {

		string builder = "";
		target.GetComponent<TextMesh> ().text = "";
		float rowLimit = 4.5f; //find the sweet spot    
		string[] parts = original.Split(' ');

		for (int i = 0; i < parts.Length; i++)
		{
			target.GetComponent<TextMesh> ().text += parts[i] + " ";
			if (target.GetComponent<MeshRenderer> ().bounds.extents.x > rowLimit)
			{
				target.GetComponent<TextMesh> ().text = builder.TrimEnd() + System.Environment.NewLine + parts[i] + " ";
			}
			builder = target.GetComponent<TextMesh> ().text;
		}

	}

	private void Adjust(ref Producer producer) {

		if (producerSelected == producer) {

			if (selectedStatus >= 2f) {
				producer.root.transform.localPosition = new Vector3(Mathf.Lerp(producer.root.transform.localPosition.x, 0f, Time.deltaTime*10f), Mathf.Lerp(producer.root.transform.localPosition.y, 4.25f -producer.root.transform.parent.localPosition.y , Time.deltaTime*10f), 0);
				if (selectedStatus >= 2.5f) {
					string originalText = Lang.getText(producer.description);
					originalText += System.Environment.NewLine + System.Environment.NewLine + "1x " + Lang.getText(producer.langCode) + " = " + GlobalData.FormattedNumber(GlobalData.getBaseLps(producer.langCode)) + " " +Lang.getText(Lang.LOVE_PER_SECOND_WORD);
					if (GlobalData.thisState.values[producer.langCode] > 1) {
						originalText += System.Environment.NewLine + GlobalData.thisState.values[producer.langCode] +"x " + Lang.getText(producer.langCode) + " = " + GlobalData.FormattedNumber(GlobalData.getBaseLps(producer.langCode)*GlobalData.thisState.values[producer.langCode]) + " " +Lang.getText(Lang.LOVE_PER_SECOND_WORD);
					}
					smartText(originalText, producer.info);
					producer.info.GetComponent<TextMesh>().color = new Color(producer.info.GetComponent<TextMesh>().color.r, producer.info.GetComponent<TextMesh>().color.g, producer.info.GetComponent<TextMesh>().color.b, Mathf.Lerp(producer.info.GetComponent<TextMesh>().color.a, 1f, Time.deltaTime*10f));
				}
			}

		} else if (lastProducerSelected == producer) {

		} else {

			float alphaValue = selectedStatus;
			if (alphaValue > 1f)  { alphaValue = 1f; }
			alphaValue = 1f - alphaValue;

			producer.hb_head.gameObject.GetComponent<SpriteRenderer>().sharedMaterial.color = new Color(1f, 1f, 1f, alphaValue);

			producer.text.gameObject.GetComponent<TextMesh>().color = new Color (producer.text.gameObject.GetComponent<TextMesh>().color.r, producer.text.gameObject.GetComponent<TextMesh>().color.g, producer.text.gameObject.GetComponent<TextMesh>().color.b, alphaValue);
			producer.cost.gameObject.GetComponent<TextMesh>().color = new Color (producer.cost.gameObject.GetComponent<TextMesh>().color.r, producer.cost.gameObject.GetComponent<TextMesh>().color.g, producer.cost.gameObject.GetComponent<TextMesh>().color.b, alphaValue);
			producer.number.gameObject.GetComponent<TextMesh>().color = new Color(producer.number.gameObject.GetComponent<TextMesh>().color.r, producer.number.gameObject.GetComponent<TextMesh>().color.g, producer.number.gameObject.GetComponent<TextMesh>().color.b, alphaValue);
			
		}


		
	}

	void LateUpdate() {

		if (GlobalData.currentScreen == 1) {
			Adjust (ref servant);
			Adjust (ref human);
			Adjust (ref prophet);
			Adjust (ref temple);
			Adjust (ref ship);
			Adjust (ref factory);
			Adjust (ref laboratory);
			Adjust (ref shop);
			Adjust (ref spaceship);
		}
		
	}

}
