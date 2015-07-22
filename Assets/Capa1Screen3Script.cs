using UnityEngine;
using System.Collections;

public class Capa1Screen3Script : MonoBehaviour {

	private GameObject servant;
	private GameObject servantBG;
	private GameObject servantIcon;
	private GameObject servantText;
	private GameObject servantNumber;
	private GameObject servantSubNumber;
	private GameObject servantCost;
	private GameObject servantLoveIcon;


	private GameObject human;
	private GameObject humanBG;
	private GameObject humanIcon;
	private GameObject humanText;
	private GameObject humanNumber;
	private GameObject humanSubNumber;
	private GameObject humanCost;
	private GameObject humanLoveIcon;


	private GameObject prophet;
	private GameObject prophetBG;
	private GameObject prophetIcon;
	private GameObject prophetText;
	private GameObject prophetNumber;
	private GameObject prophetSubNumber;
	private GameObject prophetCost;
	private GameObject prophetLoveIcon;


	private GameObject temple;
	private GameObject templeBG;
	private GameObject templeIcon;
	private GameObject templeText;
	private GameObject templeNumber;
	private GameObject templeSubNumber;
	private GameObject templeCost;
	private GameObject templeLoveIcon;


	private GameObject ship;
	private GameObject shipBG;
	private GameObject shipIcon;
	private GameObject shipText;
	private GameObject shipNumber;
	private GameObject shipSubNumber;
	private GameObject shipCost;
	private GameObject shipLoveIcon;


	private GameObject factory;
	private GameObject factoryBG;
	private GameObject factoryIcon;
	private GameObject factoryText;
	private GameObject factoryNumber;
	private GameObject factorySubNumber;
	private GameObject factoryCost;
	private GameObject factoryLoveIcon;


	private GameObject laboratory;
	private GameObject laboratoryBG;
	private GameObject laboratoryIcon;
	private GameObject laboratoryText;
	private GameObject laboratoryNumber;
	private GameObject laboratorySubNumber;
	private GameObject laboratoryCost;
	private GameObject laboratoryLoveIcon;


	private GameObject shop;
	private GameObject shopBG;
	private GameObject shopIcon;
	private GameObject shopText;
	private GameObject shopNumber;
	private GameObject shopSubNumber;
	private GameObject shopCost;
	private GameObject shopLoveIcon;


	private GameObject spaceship;
	private GameObject spaceshipBG;
	private GameObject spaceshipIcon;
	private GameObject spaceshipText;
	private GameObject spaceshipNumber;
	private GameObject spaceshipSubNumber;
	private GameObject spaceshipCost;
	private GameObject spaceshipLoveIcon;


	private string servantStatus = "undiscovered";
	private string humanStatus = "unexistant";
	private string prophetStatus = "unexistant";
	private string templeStatus = "unexistant";
	private string shipStatus = "unexistant";
	private string factoryStatus = "unexistant";
	private string laboratoryStatus = "unexistant";
	private string shopStatus = "unexistant";
	private string spaceshipStatus = "unexistant";

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

		buy2 = gameObject.AddComponent<AudioSource>();
		buy2.clip = Resources.Load ("Audio/buy2") as AudioClip;
		buy2.volume = 1f;

		buy3 = gameObject.AddComponent<AudioSource>();
		buy3.clip = Resources.Load ("Audio/buy3") as AudioClip;
		buy3.volume = 1f;

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

		human = GameObject.Find ("Scene1/Capa1/Screen3/Human");
		humanBG = GameObject.Find ("Scene1/Capa1/Screen3/Human/Background");
		humanIcon = GameObject.Find ("Scene1/Capa1/Screen3/Human/Icon");
		humanText = GameObject.Find ("Scene1/Capa1/Screen3/Human/Text");
		humanNumber = GameObject.Find ("Scene1/Capa1/Screen3/Human/Number");
		humanSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Human/SubNumber");
		humanCost = GameObject.Find ("Scene1/Capa1/Screen3/Human/Cost");
		humanLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Human/LoveIcon");
		humanBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		humanIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		humanText.GetComponent<TextMesh> ().color = new Color(humanText.GetComponent<TextMesh> ().color.r, humanText.GetComponent<TextMesh> ().color.g, humanText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		humanNumber.GetComponent<TextMesh> ().color = new Color(humanNumber.GetComponent<TextMesh> ().color.r, humanNumber.GetComponent<TextMesh> ().color.g, humanNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		humanSubNumber.GetComponent<TextMesh> ().color = new Color(humanSubNumber.GetComponent<TextMesh> ().color.r, humanSubNumber.GetComponent<TextMesh> ().color.g, humanSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		humanCost.GetComponent<TextMesh> ().color = new Color(humanCost.GetComponent<TextMesh> ().color.r, humanCost.GetComponent<TextMesh> ().color.g, humanCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		humanNumber.SetActive (false);
		humanSubNumber.SetActive (false);
		humanCost.SetActive (false);
		humanLoveIcon.SetActive (false);
		human.SetActive (false);

		prophet = GameObject.Find ("Scene1/Capa1/Screen3/Prophet");
		prophetBG = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Background");
		prophetIcon = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Icon");
		prophetText = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Text");
		prophetNumber = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Number");
		prophetSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/SubNumber");
		prophetCost = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Cost");
		prophetLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/LoveIcon");
		prophetBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		prophetIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		prophetText.GetComponent<TextMesh> ().color = new Color(prophetText.GetComponent<TextMesh> ().color.r, prophetText.GetComponent<TextMesh> ().color.g, prophetText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		prophetNumber.GetComponent<TextMesh> ().color = new Color(prophetNumber.GetComponent<TextMesh> ().color.r, prophetNumber.GetComponent<TextMesh> ().color.g, prophetNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		prophetSubNumber.GetComponent<TextMesh> ().color = new Color(prophetSubNumber.GetComponent<TextMesh> ().color.r, prophetSubNumber.GetComponent<TextMesh> ().color.g, prophetSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		prophetCost.GetComponent<TextMesh> ().color = new Color(prophetCost.GetComponent<TextMesh> ().color.r, prophetCost.GetComponent<TextMesh> ().color.g, prophetCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		prophetNumber.SetActive (false);
		prophetSubNumber.SetActive (false);
		prophetCost.SetActive (false);
		prophetLoveIcon.SetActive (false);
		prophet.SetActive (false);

		temple = GameObject.Find ("Scene1/Capa1/Screen3/Temple");
		templeBG = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Background");
		templeIcon = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Icon");
		templeText = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Text");
		templeNumber = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Number");
		templeSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Temple/SubNumber");
		templeCost = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Cost");
		templeLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Temple/LoveIcon");
		templeBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		templeIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		templeText.GetComponent<TextMesh> ().color = new Color(templeText.GetComponent<TextMesh> ().color.r, templeText.GetComponent<TextMesh> ().color.g, templeText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		templeNumber.GetComponent<TextMesh> ().color = new Color(templeNumber.GetComponent<TextMesh> ().color.r, templeNumber.GetComponent<TextMesh> ().color.g, templeNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		templeSubNumber.GetComponent<TextMesh> ().color = new Color(templeSubNumber.GetComponent<TextMesh> ().color.r, templeSubNumber.GetComponent<TextMesh> ().color.g, templeSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		templeCost.GetComponent<TextMesh> ().color = new Color(templeCost.GetComponent<TextMesh> ().color.r, templeCost.GetComponent<TextMesh> ().color.g, templeCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		templeNumber.SetActive (false);
		templeSubNumber.SetActive (false);
		templeCost.SetActive (false);
		templeLoveIcon.SetActive (false);
		temple.SetActive (false);

		ship = GameObject.Find ("Scene1/Capa1/Screen3/Ship");
		shipBG = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Background");
		shipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Icon");
		shipText = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Text");
		shipNumber = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Number");
		shipSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Ship/SubNumber");
		shipCost = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Cost");
		shipLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Ship/LoveIcon");
		shipBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		shipIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		shipText.GetComponent<TextMesh> ().color = new Color(shipText.GetComponent<TextMesh> ().color.r, shipText.GetComponent<TextMesh> ().color.g, shipText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shipNumber.GetComponent<TextMesh> ().color = new Color(shipNumber.GetComponent<TextMesh> ().color.r, shipNumber.GetComponent<TextMesh> ().color.g, shipNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shipSubNumber.GetComponent<TextMesh> ().color = new Color(shipSubNumber.GetComponent<TextMesh> ().color.r, shipSubNumber.GetComponent<TextMesh> ().color.g, shipSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shipCost.GetComponent<TextMesh> ().color = new Color(shipCost.GetComponent<TextMesh> ().color.r, shipCost.GetComponent<TextMesh> ().color.g, shipCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shipNumber.SetActive (false);
		shipSubNumber.SetActive (false);
		shipCost.SetActive (false);
		shipLoveIcon.SetActive (false);
		ship.SetActive (false);

		factory = GameObject.Find ("Scene1/Capa1/Screen3/Factory");
		factoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Background");
		factoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Icon");
		factoryText = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Text");
		factoryNumber = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Number");
		factorySubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Factory/SubNumber");
		factoryCost = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Cost");
		factoryLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Factory/LoveIcon");
		factoryBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		factoryIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		factoryText.GetComponent<TextMesh> ().color = new Color(factoryText.GetComponent<TextMesh> ().color.r, factoryText.GetComponent<TextMesh> ().color.g, factoryText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		factoryNumber.GetComponent<TextMesh> ().color = new Color(factoryNumber.GetComponent<TextMesh> ().color.r, factoryNumber.GetComponent<TextMesh> ().color.g, factoryNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		factorySubNumber.GetComponent<TextMesh> ().color = new Color(factorySubNumber.GetComponent<TextMesh> ().color.r, factorySubNumber.GetComponent<TextMesh> ().color.g, factorySubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		factoryCost.GetComponent<TextMesh> ().color = new Color(factoryCost.GetComponent<TextMesh> ().color.r, factoryCost.GetComponent<TextMesh> ().color.g, factoryCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		factoryNumber.SetActive (false);
		factorySubNumber.SetActive (false);
		factoryCost.SetActive (false);
		factoryLoveIcon.SetActive (false);
		factory.SetActive (false);

		laboratory = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory");
		laboratoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Background");
		laboratoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Icon");
		laboratoryText = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Text");
		laboratoryNumber = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Number");
		laboratorySubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/SubNumber");
		laboratoryCost = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Cost");
		laboratoryLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/LoveIcon");
		laboratoryBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		laboratoryIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		laboratoryText.GetComponent<TextMesh> ().color = new Color(laboratoryText.GetComponent<TextMesh> ().color.r, laboratoryText.GetComponent<TextMesh> ().color.g, laboratoryText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		laboratoryNumber.GetComponent<TextMesh> ().color = new Color(laboratoryNumber.GetComponent<TextMesh> ().color.r, laboratoryNumber.GetComponent<TextMesh> ().color.g, laboratoryNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		laboratorySubNumber.GetComponent<TextMesh> ().color = new Color(laboratorySubNumber.GetComponent<TextMesh> ().color.r, laboratorySubNumber.GetComponent<TextMesh> ().color.g, laboratorySubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		laboratoryCost.GetComponent<TextMesh> ().color = new Color(laboratoryCost.GetComponent<TextMesh> ().color.r, laboratoryCost.GetComponent<TextMesh> ().color.g, laboratoryCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		laboratoryNumber.SetActive (false);
		laboratorySubNumber.SetActive (false);
		laboratoryCost.SetActive (false);
		laboratoryLoveIcon.SetActive (false);
		laboratory.SetActive (false);

		shop = GameObject.Find ("Scene1/Capa1/Screen3/Shop");
		shopBG = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Background");
		shopIcon = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Icon");
		shopText = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Text");
		shopNumber = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Number");
		shopSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Shop/SubNumber");
		shopCost = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Cost");
		shopLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Shop/LoveIcon");
		shopBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		shopIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		shopText.GetComponent<TextMesh> ().color = new Color(shopText.GetComponent<TextMesh> ().color.r, shopText.GetComponent<TextMesh> ().color.g, shopText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shopNumber.GetComponent<TextMesh> ().color = new Color(shopNumber.GetComponent<TextMesh> ().color.r, shopNumber.GetComponent<TextMesh> ().color.g, shopNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shopSubNumber.GetComponent<TextMesh> ().color = new Color(shopSubNumber.GetComponent<TextMesh> ().color.r, shopSubNumber.GetComponent<TextMesh> ().color.g, shopSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shopCost.GetComponent<TextMesh> ().color = new Color(shopCost.GetComponent<TextMesh> ().color.r, shopCost.GetComponent<TextMesh> ().color.g, shopCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shopNumber.SetActive (false);
		shopSubNumber.SetActive (false);
		shopCost.SetActive (false);
		shopLoveIcon.SetActive (false);
		shop.SetActive (false);

		spaceship = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship");
		spaceshipBG = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Background");
		spaceshipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Icon");
		spaceshipText = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Text");
		spaceshipNumber = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Number");
		spaceshipSubNumber = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/SubNumber");
		spaceshipCost = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Cost");
		spaceshipLoveIcon = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/LoveIcon");
		spaceshipBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		spaceshipIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		spaceshipText.GetComponent<TextMesh> ().color = new Color(spaceshipText.GetComponent<TextMesh> ().color.r, spaceshipText.GetComponent<TextMesh> ().color.g, spaceshipText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		spaceshipNumber.GetComponent<TextMesh> ().color = new Color(spaceshipNumber.GetComponent<TextMesh> ().color.r, spaceshipNumber.GetComponent<TextMesh> ().color.g, spaceshipNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		spaceshipSubNumber.GetComponent<TextMesh> ().color = new Color(spaceshipSubNumber.GetComponent<TextMesh> ().color.r, spaceshipSubNumber.GetComponent<TextMesh> ().color.g, spaceshipSubNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		spaceshipCost.GetComponent<TextMesh> ().color = new Color(spaceshipCost.GetComponent<TextMesh> ().color.r, spaceshipCost.GetComponent<TextMesh> ().color.g, spaceshipCost.GetComponent<TextMesh> ().color.b, discovered_transparency);
		spaceshipNumber.SetActive (false);
		spaceshipSubNumber.SetActive (false);
		spaceshipCost.SetActive (false);
		spaceshipLoveIcon.SetActive (false);
		spaceship.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

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

	private void RegularComprobation(string previousStatus, ref string status, ref GameObject father, ref GameObject background, ref GameObject icon, ref GameObject text, ref GameObject number, ref GameObject subNumber, ref GameObject cost, ref GameObject loveIcon, int LangCode) {

		if (status == "unexistant" && (previousStatus != "undiscovered" && previousStatus != "unexistant")) {
			father.SetActive(true);
			status = "undiscovered";
		} else if ((status == "undiscovered" && GlobalData.thisState.totalLove >= GlobalData.getBaseCost (LangCode)) ||
		           (status == "buyable" && GlobalData.thisState.love < Mathf.Floor(GlobalData.getBaseCost (LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode])))) {
			status = "discovered";
		} else if (status == "discovered" && GlobalData.thisState.love >= Mathf.Floor (GlobalData.getBaseCost (LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode]))) {
			status = "buyable";
		}

		if (status != "unexistant" && status != "undiscovered") {
			text.GetComponent<TextMesh> ().text = Lang.getText(LangCode);
			number.GetComponent<TextMesh> ().text = ""+GlobalData.thisState.values[LangCode];
			cost.GetComponent<TextMesh> ().text = ""+GlobalData.FormattedNumber(Mathf.Floor (GlobalData.getBaseCost (LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode])));
		}

		float producerAlpha = 1f;

		if (selectedStatus == 0f) {
			producerAlpha = 1f;
		}

		if (status == "undiscovered") {
			background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			icon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency*producerAlpha);
			text.GetComponent<TextMesh> ().color = new Color(text.GetComponent<TextMesh> ().color.r, text.GetComponent<TextMesh> ().color.g, text.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
			number.GetComponent<TextMesh> ().color = new Color(number.GetComponent<TextMesh> ().color.r, number.GetComponent<TextMesh> ().color.g, number.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
		} else if (status == "discovered") {
			background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			text.GetComponent<TextMesh> ().color = new Color(text.GetComponent<TextMesh> ().color.r, text.GetComponent<TextMesh> ().color.g, text.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
			number.GetComponent<TextMesh> ().color = new Color(number.GetComponent<TextMesh> ().color.r, number.GetComponent<TextMesh> ().color.g, number.GetComponent<TextMesh> ().color.b, discovered_transparency*producerAlpha);
		} else if (status == "buyable") {
			background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			text.GetComponent<TextMesh> ().color = new Color(text.GetComponent<TextMesh> ().color.r, text.GetComponent<TextMesh> ().color.g, text.GetComponent<TextMesh> ().color.b, 1f*producerAlpha);
			number.GetComponent<TextMesh> ().color = new Color(number.GetComponent<TextMesh> ().color.r, number.GetComponent<TextMesh> ().color.g, number.GetComponent<TextMesh> ().color.b, 1f*producerAlpha);
		}

		if (!number.activeInHierarchy && (status != "unexistant" && status != "undiscovered")) {
			number.SetActive(true);
			subNumber.SetActive(true);
			cost.SetActive(true);
			loveIcon.SetActive(true);
		}


	}

}
