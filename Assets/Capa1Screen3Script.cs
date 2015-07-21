using UnityEngine;
using System.Collections;

public class Capa1Screen3Script : MonoBehaviour {

	private GameObject servant;
	private GameObject servantBG;
	private GameObject servantIcon;
	private GameObject servantText;
	private GameObject servantNumber;

	private GameObject human;
	private GameObject humanBG;
	private GameObject humanIcon;
	private GameObject humanText;
	private GameObject humanNumber;

	private GameObject prophet;
	private GameObject prophetBG;
	private GameObject prophetIcon;
	private GameObject prophetText;
	private GameObject prophetNumber;

	private GameObject temple;
	private GameObject templeBG;
	private GameObject templeIcon;
	private GameObject templeText;
	private GameObject templeNumber;

	private GameObject ship;
	private GameObject shipBG;
	private GameObject shipIcon;
	private GameObject shipText;
	private GameObject shipNumber;

	private GameObject factory;
	private GameObject factoryBG;
	private GameObject factoryIcon;
	private GameObject factoryText;
	private GameObject factoryNumber;

	private GameObject laboratory;
	private GameObject laboratoryBG;
	private GameObject laboratoryIcon;
	private GameObject laboratoryText;
	private GameObject laboratoryNumber;

	private GameObject shop;
	private GameObject shopBG;
	private GameObject shopIcon;
	private GameObject shopText;
	private GameObject shopNumber;

	private GameObject spaceship;
	private GameObject spaceshipBG;
	private GameObject spaceshipIcon;
	private GameObject spaceshipText;
	private GameObject spaceshipNumber;

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

	// Use this for initialization
	void Start () {

		servant = GameObject.Find ("Scene1/Capa1/Screen3/Servant");
		servantBG = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Background");
		servantIcon = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Icon");
		servantText = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Text");
		servantNumber = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Number");
		servantBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		servantIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		servantText.GetComponent<TextMesh> ().color = new Color(servantText.GetComponent<TextMesh> ().color.r, servantText.GetComponent<TextMesh> ().color.g, servantText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		servantNumber.GetComponent<TextMesh> ().color = new Color(servantNumber.GetComponent<TextMesh> ().color.r, servantNumber.GetComponent<TextMesh> ().color.g, servantNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		servantNumber.SetActive (false);

		human = GameObject.Find ("Scene1/Capa1/Screen3/Human");
		humanBG = GameObject.Find ("Scene1/Capa1/Screen3/Human/Background");
		humanIcon = GameObject.Find ("Scene1/Capa1/Screen3/Human/Icon");
		humanText = GameObject.Find ("Scene1/Capa1/Screen3/Human/Text");
		humanNumber = GameObject.Find ("Scene1/Capa1/Screen3/Human/Number");
		humanBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		humanIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		humanText.GetComponent<TextMesh> ().color = new Color(humanText.GetComponent<TextMesh> ().color.r, humanText.GetComponent<TextMesh> ().color.g, humanText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		humanNumber.GetComponent<TextMesh> ().color = new Color(humanNumber.GetComponent<TextMesh> ().color.r, humanNumber.GetComponent<TextMesh> ().color.g, humanNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		humanNumber.SetActive (false);
		human.SetActive (false);

		prophet = GameObject.Find ("Scene1/Capa1/Screen3/Prophet");
		prophetBG = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Background");
		prophetIcon = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Icon");
		prophetText = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Text");
		prophetNumber = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Number");
		prophetBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		prophetIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		prophetText.GetComponent<TextMesh> ().color = new Color(prophetText.GetComponent<TextMesh> ().color.r, prophetText.GetComponent<TextMesh> ().color.g, prophetText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		prophetNumber.GetComponent<TextMesh> ().color = new Color(prophetNumber.GetComponent<TextMesh> ().color.r, prophetNumber.GetComponent<TextMesh> ().color.g, prophetNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		prophetNumber.SetActive (false);
		prophet.SetActive (false);

		temple = GameObject.Find ("Scene1/Capa1/Screen3/Temple");
		templeBG = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Background");
		templeIcon = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Icon");
		templeText = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Text");
		templeNumber = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Number");
		templeBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		templeIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		templeText.GetComponent<TextMesh> ().color = new Color(templeText.GetComponent<TextMesh> ().color.r, templeText.GetComponent<TextMesh> ().color.g, templeText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		templeNumber.GetComponent<TextMesh> ().color = new Color(templeNumber.GetComponent<TextMesh> ().color.r, templeNumber.GetComponent<TextMesh> ().color.g, templeNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		templeNumber.SetActive (false);
		temple.SetActive (false);

		ship = GameObject.Find ("Scene1/Capa1/Screen3/Ship");
		shipBG = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Background");
		shipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Icon");
		shipText = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Text");
		shipNumber = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Number");
		shipBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		shipIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		shipText.GetComponent<TextMesh> ().color = new Color(shipText.GetComponent<TextMesh> ().color.r, shipText.GetComponent<TextMesh> ().color.g, shipText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shipNumber.GetComponent<TextMesh> ().color = new Color(shipNumber.GetComponent<TextMesh> ().color.r, shipNumber.GetComponent<TextMesh> ().color.g, shipNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shipNumber.SetActive (false);
		ship.SetActive (false);

		factory = GameObject.Find ("Scene1/Capa1/Screen3/Factory");
		factoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Background");
		factoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Icon");
		factoryText = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Text");
		factoryNumber = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Number");
		factoryBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		factoryIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		factoryText.GetComponent<TextMesh> ().color = new Color(factoryText.GetComponent<TextMesh> ().color.r, factoryText.GetComponent<TextMesh> ().color.g, factoryText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		factoryNumber.GetComponent<TextMesh> ().color = new Color(factoryNumber.GetComponent<TextMesh> ().color.r, factoryNumber.GetComponent<TextMesh> ().color.g, factoryNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		factoryNumber.SetActive (false);
		factory.SetActive (false);

		laboratory = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory");
		laboratoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Background");
		laboratoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Icon");
		laboratoryText = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Text");
		laboratoryNumber = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Number");
		laboratoryBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		laboratoryIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		laboratoryText.GetComponent<TextMesh> ().color = new Color(laboratoryText.GetComponent<TextMesh> ().color.r, laboratoryText.GetComponent<TextMesh> ().color.g, laboratoryText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		laboratoryNumber.GetComponent<TextMesh> ().color = new Color(laboratoryNumber.GetComponent<TextMesh> ().color.r, laboratoryNumber.GetComponent<TextMesh> ().color.g, laboratoryNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		laboratoryNumber.SetActive (false);
		laboratory.SetActive (false);

		shop = GameObject.Find ("Scene1/Capa1/Screen3/Shop");
		shopBG = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Background");
		shopIcon = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Icon");
		shopText = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Text");
		shopNumber = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Number");
		shopBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		shopIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		shopText.GetComponent<TextMesh> ().color = new Color(shopText.GetComponent<TextMesh> ().color.r, shopText.GetComponent<TextMesh> ().color.g, shopText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shopNumber.GetComponent<TextMesh> ().color = new Color(shopNumber.GetComponent<TextMesh> ().color.r, shopNumber.GetComponent<TextMesh> ().color.g, shopNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		shopNumber.SetActive (false);
		shop.SetActive (false);

		spaceship = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship");
		spaceshipBG = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Background");
		spaceshipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Icon");
		spaceshipText = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Text");
		spaceshipNumber = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Number");
		spaceshipBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		spaceshipIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		spaceshipText.GetComponent<TextMesh> ().color = new Color(spaceshipText.GetComponent<TextMesh> ().color.r, spaceshipText.GetComponent<TextMesh> ().color.g, spaceshipText.GetComponent<TextMesh> ().color.b, discovered_transparency);
		spaceshipNumber.GetComponent<TextMesh> ().color = new Color(spaceshipNumber.GetComponent<TextMesh> ().color.r, spaceshipNumber.GetComponent<TextMesh> ().color.g, spaceshipNumber.GetComponent<TextMesh> ().color.b, discovered_transparency);
		spaceshipNumber.SetActive (false);
		spaceship.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		RegularComprobation ("meh", ref servantStatus, ref servant, ref servantBG, ref servantIcon, ref servantText, ref servantNumber, Lang.SERVANT_NAME);
		RegularComprobation (servantStatus, ref humanStatus, ref human, ref humanBG, ref humanIcon, ref humanText, ref humanNumber, Lang.HUMAN_NAME);
		RegularComprobation (humanStatus, ref prophetStatus, ref prophet, ref prophetBG, ref prophetIcon, ref prophetText, ref prophetNumber, Lang.PROPHET_NAME);
		RegularComprobation (prophetStatus, ref templeStatus, ref temple, ref templeBG, ref templeIcon, ref templeText, ref templeNumber, Lang.TEMPLE_NAME);
		RegularComprobation (templeStatus, ref shipStatus, ref ship, ref shipBG, ref shipIcon, ref shipText, ref shipNumber, Lang.SHIP_NAME);
		RegularComprobation (shipStatus, ref factoryStatus, ref factory, ref factoryBG, ref factoryIcon, ref factoryText, ref factoryNumber, Lang.FACTORY_NAME);
		RegularComprobation (factoryStatus, ref laboratoryStatus, ref laboratory, ref laboratoryBG, ref laboratoryIcon, ref laboratoryText, ref laboratoryNumber, Lang.LABORATORY_NAME);
		RegularComprobation (laboratoryStatus, ref shopStatus, ref shop, ref shopBG, ref shopIcon, ref shopText, ref shopNumber, Lang.SHOP_NAME);
		RegularComprobation (shopStatus, ref spaceshipStatus, ref spaceship, ref spaceshipBG, ref spaceshipIcon, ref spaceshipText, ref spaceshipNumber, Lang.SPACESHIP_NAME);

		if (servantStatus != "unexistant" && servantStatus != "undiscovered" && ClickedOn(servant)) {
			GlobalData.thisState.values[Lang.SERVANT_NAME]++;
		}

	}

	private bool ClickedOn(GameObject target) {
		
		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer) {
			
			if (Input.GetMouseButtonDown(0)) { 

				lastMousePosition = Input.mousePosition;

			} else if (Input.GetMouseButtonUp(0)) { 

				Ray ray = Camera.main.ScreenPointToRay (lastMousePosition);
				
				RaycastHit2D hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("ProducerMask"));
				
				if (hit.collider != null) {
					
					Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
					
					RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(ray2.origin.x, ray2.origin.y), Vector2.zero, 0f, LayerMask.GetMask ("ProducerMask"));
					
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

	private void RegularComprobation(string previousStatus, ref string status, ref GameObject father, ref GameObject background, ref GameObject icon, ref GameObject text, ref GameObject number, int LangCode) {

		if (status == "unexistant" && (previousStatus != "undiscovered" && previousStatus != "unexistant")) {
			father.SetActive(true);
			status = "undiscovered";
		} else if ((status == "undiscovered" && GlobalData.thisState.totalLove >= GlobalData.getBaseCost (LangCode)) ||
		           (status == "buyable" && GlobalData.thisState.love < GlobalData.getBaseCost (LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode]))) {
			status = "discovered";
		} else if (status == "discovered" && GlobalData.thisState.love >= GlobalData.getBaseCost (LangCode)*Mathf.Pow(1.1f, GlobalData.thisState.values[LangCode])) {
			status = "buyable";
		}

		if (status != "unexistant" && status != "undiscovered") {
			text.GetComponent<TextMesh> ().text = Lang.getText(LangCode);
			number.GetComponent<TextMesh> ().text = ""+GlobalData.thisState.values[LangCode];
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

		if (!number.activeInHierarchy && GlobalData.thisState.values[LangCode] > 0) {
			number.SetActive(true);
		}


	}

}
