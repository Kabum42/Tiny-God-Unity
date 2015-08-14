using UnityEngine;
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

	private GameObject producerSelected = null;
	private float selectedStatus = 0f;

	private Vector3 lastMousePosition;

	private AudioSource buy1;
	private AudioSource buy2;
	private AudioSource buy3;

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

		servant = new Producer (this.gameObject, 0, "Servant", Lang.SERVANT_NAME);
		human = new Producer (this.gameObject, 1, "Human", Lang.HUMAN_NAME);
		prophet = new Producer (this.gameObject, 2, "Prophet", Lang.PROPHET_NAME);
		temple = new Producer (this.gameObject, 3, "Temple", Lang.TEMPLE_NAME);
		ship = new Producer (this.gameObject, 4, "Ship", Lang.SHIP_NAME);
		factory = new Producer (this.gameObject, 5, "Factory", Lang.FACTORY_NAME);
		laboratory = new Producer (this.gameObject, 6, "Laboratory", Lang.LABORATORY_NAME);
		shop = new Producer (this.gameObject, 7, "Shop", Lang.SHOP_NAME);
		spaceship = new Producer (this.gameObject, 8, "Spaceship", Lang.SPACESHIP_NAME);

		/*
		servant = GameObject.Find ("Scene1/Capa1/Screen3/Servant");
		servantBG = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Background");
		servantIcon = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Icon");
		servantText = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Text");
		servantNumber = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Number");
		servantSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Servant/SubNumber");
		servantCost = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Cost");
		servantLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Servant/LoveIcon");
		servantBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		servantIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		servantText.GetComponent<TextMesh> ().color = new Color(servantText.GetComponent<TextMesh> ().color.r, servantText.GetComponent<TextMesh> ().color.g, servantText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		servantNumber.GetComponent<TextMesh> ().color = new Color(servantNumber.GetComponent<TextMesh> ().color.r, servantNumber.GetComponent<TextMesh> ().color.g, servantNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		servantSubNumber.GetComponent<TextMesh> ().color = new Color(servantSubNumber.GetComponent<TextMesh> ().color.r, servantSubNumber.GetComponent<TextMesh> ().color.g, servantSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		servantCost.GetComponent<TextMesh> ().color = new Color(servantCost.GetComponent<TextMesh> ().color.r, servantCost.GetComponent<TextMesh> ().color.g, servantCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		servantNumber.SetActive (false);
		servantSubNumber.SetActive (false);
		servantCost.SetActive (false);
		servantLoveIcon.SetActive (false);
		*/
	
	}
	
	// Update is called once per frame
	void Update () {

		RegularComprobation ("meh", ref servant);
		RegularComprobation (servant.status, ref human);
		RegularComprobation (human.status, ref prophet);
		RegularComprobation (prophet.status, ref temple);
		RegularComprobation (temple.status, ref ship);
		RegularComprobation (ship.status, ref factory);
		RegularComprobation (factory.status, ref laboratory);
		RegularComprobation (laboratory.status, ref shop);
		RegularComprobation (shop.status, ref spaceship);

		/*
		RegularComprobation ("meh", ref servantStatus, ref servant, ref servantBG, ref servantIcon, ref servantText, ref servantNumber, ref servantSubNumber, ref servantCost, ref servantLoveIcon, Lang.SERVANT_NAME);
		RegularComprobation (servantStatus, ref humanStatus, ref human, ref humanBG, ref humanIcon, ref humanText, ref humanNumber, ref humanSubNumber, ref humanCost, ref humanLoveIcon, Lang.HUMAN_NAME);
		RegularComprobation (humanStatus, ref prophetStatus, ref prophet, ref prophetBG, ref prophetIcon, ref prophetText, ref prophetNumber, ref prophetSubNumber, ref prophetCost, ref prophetLoveIcon, Lang.PROPHET_NAME);
		RegularComprobation (prophetStatus, ref templeStatus, ref temple, ref templeBG, ref templeIcon, ref templeText, ref templeNumber, ref templeSubNumber, ref templeCost, ref templeLoveIcon, Lang.TEMPLE_NAME);
		RegularComprobation (templeStatus, ref shipStatus, ref ship, ref shipBG, ref shipIcon, ref shipText, ref shipNumber, ref shipSubNumber, ref shipCost, ref shipLoveIcon, Lang.SHIP_NAME);
		RegularComprobation (shipStatus, ref factoryStatus, ref factory, ref factoryBG, ref factoryIcon, ref factoryText, ref factoryNumber, ref factorySubNumber, ref factoryCost, ref factoryLoveIcon, Lang.FACTORY_NAME);
		RegularComprobation (factoryStatus, ref laboratoryStatus, ref laboratory, ref laboratoryBG, ref laboratoryIcon, ref laboratoryText, ref laboratoryNumber, ref laboratorySubNumber, ref laboratoryCost, ref laboratoryLoveIcon, Lang.LABORATORY_NAME);
		RegularComprobation (laboratoryStatus, ref shopStatus, ref shop, ref shopBG, ref shopIcon, ref shopText, ref shopNumber, ref shopSubNumber, ref shopCost, ref shopLoveIcon, Lang.SHOP_NAME);
		RegularComprobation (shopStatus, ref spaceshipStatus, ref spaceship, ref spaceshipBG, ref spaceshipIcon, ref spaceshipText, ref spaceshipNumber, ref spaceshipSubNumber, ref spaceshipCost, ref spaceshipLoveIcon, Lang.SPACESHIP_NAME);


		if (servantStatus != "unexistant" && servantStatus != "undiscovered" && ClickedOn (servantNumber)) {	
			checkCanBuy (Lang.SERVANT_NAME);
		} else if (false) {
			// COMPROBAR SI HA CLICKADO ENCIMA DE LA CABECERA
		}

		if (humanStatus != "unexistant" && humanStatus != "undiscovered" && ClickedOn (humanNumber)) {	
			checkCanBuy (Lang.HUMAN_NAME);
		}

		if (prophetStatus != "unexistant" && prophetStatus != "undiscovered" && ClickedOn (prophetNumber)) {	
			checkCanBuy (Lang.PROPHET_NAME);
		}

		if (templeStatus != "unexistant" && templeStatus != "undiscovered" && ClickedOn (templeNumber)) {	
			checkCanBuy (Lang.TEMPLE_NAME);
		}

		if (shipStatus != "unexistant" && shipStatus != "undiscovered" && ClickedOn (shipNumber)) {	
			checkCanBuy (Lang.SHIP_NAME);
		}

		if (factoryStatus != "unexistant" && factoryStatus != "undiscovered" && ClickedOn (factoryNumber)) {	
			checkCanBuy (Lang.FACTORY_NAME);
		}

		if (laboratoryStatus != "unexistant" && laboratoryStatus != "undiscovered" && ClickedOn (laboratoryNumber)) {	
			checkCanBuy (Lang.LABORATORY_NAME);
		}

		if (shopStatus != "unexistant" && shopStatus != "undiscovered" && ClickedOn (shopNumber)) {	
			checkCanBuy (Lang.SHOP_NAME);
		}

		if (spaceshipStatus != "unexistant" && spaceshipStatus != "undiscovered" && ClickedOn (spaceshipNumber)) {	
			checkCanBuy (Lang.SPACESHIP_NAME);
		}
		*/

	}

	private void RegularComprobation(string previousStatus, ref Producer producer) {
		
		if (producer.status == "unexistant" && (previousStatus != "undiscovered" && previousStatus != "unexistant")) {
			producer.root.SetActive(true);
			producer.status = "undiscovered";
		} else if ((producer.status == "undiscovered" && GlobalData.thisState.totalLove >= GlobalData.getBaseCost (producer.langCode)) ||
		           (producer.status == "buyable" && GlobalData.thisState.love < Mathf.Floor(GlobalData.getBaseCost (producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode])))) {
			producer.status = "discovered";
		} else if (producer.status == "discovered" && GlobalData.thisState.love >= Mathf.Floor (GlobalData.getBaseCost (producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode]))) {
			producer.status = "buyable";
		}
		
		if (producer.status != "unexistant" && producer.status != "undiscovered") {
			producer.text.GetComponent<TextMesh> ().text = Lang.getText(producer.langCode);
			producer.number.GetComponent<TextMesh> ().text = ""+GlobalData.thisState.values[producer.langCode];
			producer.cost.GetComponent<TextMesh> ().text = ""+GlobalData.FormattedNumber(Mathf.Floor (GlobalData.getBaseCost (producer.langCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[producer.langCode])));
		}
		
		float producerAlpha = 1f;
		
		if (selectedStatus == 0f) {
			producerAlpha = 1f;
		}


		if (producer.status == "undiscovered") {
			//background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			//icon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency*producerAlpha);
			producer.text.GetComponent<TextMesh> ().color = new Color(producer.text.GetComponent<TextMesh> ().color.r, producer.text.GetComponent<TextMesh> ().color.g, producer.text.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
			producer.number.GetComponent<TextMesh> ().color = new Color(producer.number.GetComponent<TextMesh> ().color.r, producer.number.GetComponent<TextMesh> ().color.g, producer.number.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
		} else if (producer.status == "discovered") {
			//background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			//icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			producer.text.GetComponent<TextMesh> ().color = new Color(producer.text.GetComponent<TextMesh> ().color.r, producer.text.GetComponent<TextMesh> ().color.g, producer.text.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
			producer.number.GetComponent<TextMesh> ().color = new Color(producer.number.GetComponent<TextMesh> ().color.r, producer.number.GetComponent<TextMesh> ().color.g, producer.number.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
		} else if (producer.status == "buyable") {
			//background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			//icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			producer.text.GetComponent<TextMesh> ().color = new Color(producer.text.GetComponent<TextMesh> ().color.r, producer.text.GetComponent<TextMesh> ().color.g, producer.text.GetComponent<TextMesh> ().color.b, 1f*producerAlpha);
			producer.number.GetComponent<TextMesh> ().color = new Color(producer.number.GetComponent<TextMesh> ().color.r, producer.number.GetComponent<TextMesh> ().color.g, producer.number.GetComponent<TextMesh> ().color.b, 1f*producerAlpha);
		}
		
		if (!producer.number.activeInHierarchy && (producer.status != "unexistant" && producer.status != "undiscovered")) {
			producer.number.SetActive(true);
			//subNumber.SetActive(true);
			producer.cost.SetActive(true);
			//loveIcon.SetActive(true);
		}

		
	}

	private void checkCanBuy(int LangCode) {

		if (GlobalData.thisState.love >= Mathf.Floor (GlobalData.getBaseCost(LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode]))) {
			
			GlobalData.thisState.love -= Mathf.Floor (GlobalData.getBaseCost(LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode]));
			GlobalData.thisState.values[LangCode]++;
			
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

	}

	private bool ClickedOn(GameObject target) {
		
		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			
			if (Input.GetMouseButtonDown(0)) { 

				lastMousePosition = Input.mousePosition;

			} else if (Input.GetMouseButtonUp(0)) { 

				Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
				
				RaycastHit2D hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
				
				if (hit.collider != null) {
					
					Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
					
					RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("BuyMask"));
					
					if (hit2.collider != null) {

						if (hit.collider.gameObject == hit2.collider.gameObject && hit.collider.gameObject == target) { return true; }
						
					}
					
				}

			}
			
		} else {
			
			if (Input.touchCount > 0) { 

				if (Input.GetTouch(0).phase == TouchPhase.Began) {

					lastMousePosition = Input.GetTouch(0).position;

				} else if (Input.GetTouch(0).phase == TouchPhase.Ended) {

					Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);

					RaycastHit2D hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("ProducerMask"));

					if (hit != null) {

						Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
						
						RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("ProducerMask"));
						
						if (hit2 != null) {
							
							if (hit.collider.gameObject == hit2.collider.gameObject && hit.collider.gameObject == target) { return true; }
							
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
		public GameObject cost;

		public Producer(GameObject parent, int position, string name, int langAux) {

			status = "unexistant";

			root =  Instantiate(Resources.Load("Producer")) as GameObject;
			root.name = name;
			root.transform.parent = parent.transform;
			root.transform.localPosition = new Vector3(0, root.transform.localPosition.y +3f -2.5f*position, root.transform.localPosition.z);

			text = root.gameObject.transform.FindChild("Text").gameObject;
			number = root.gameObject.transform.FindChild("Number").gameObject;
			cost = root.gameObject.transform.FindChild("Cost").gameObject;

			root.SetActive(false);

			langCode = langAux;

		}

	}

}
