using UnityEngine;
using System.Collections;

public class Capa1Screen3Script : MonoBehaviour {

	private GameObject servant;
	private GameObject servantBG;
	private GameObject servantIcon;
	private GameObject servantText;

	private GameObject human;
	private GameObject humanBG;
	private GameObject humanIcon;
	private GameObject humanText;

	private GameObject prophet;
	private GameObject prophetBG;
	private GameObject prophetIcon;
	private GameObject prophetText;

	private GameObject temple;
	private GameObject templeBG;
	private GameObject templeIcon;
	private GameObject templeText;

	private GameObject ship;
	private GameObject shipBG;
	private GameObject shipIcon;
	private GameObject shipText;

	private GameObject factory;
	private GameObject factoryBG;
	private GameObject factoryIcon;
	private GameObject factoryText;

	private GameObject laboratory;
	private GameObject laboratoryBG;
	private GameObject laboratoryIcon;
	private GameObject laboratoryText;

	private GameObject shop;
	private GameObject shopBG;
	private GameObject shopIcon;
	private GameObject shopText;

	private GameObject spaceship;
	private GameObject spaceshipBG;
	private GameObject spaceshipIcon;
	private GameObject spaceshipText;

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

	// Use this for initialization
	void Start () {

		servant = GameObject.Find ("Scene1/Capa1/Screen3/Servant");
		servantBG = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Background");
		servantIcon = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Icon");
		servantText = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Text");
		servantBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		servantIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		servantText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);

		human = GameObject.Find ("Scene1/Capa1/Screen3/Human");
		humanBG = GameObject.Find ("Scene1/Capa1/Screen3/Human/Background");
		humanIcon = GameObject.Find ("Scene1/Capa1/Screen3/Human/Icon");
		humanText = GameObject.Find ("Scene1/Capa1/Screen3/Human/Text");
		humanBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		humanIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		humanText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		human.SetActive (false);

		prophet = GameObject.Find ("Scene1/Capa1/Screen3/Prophet");
		prophetBG = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Background");
		prophetIcon = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Icon");
		prophetText = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Text");
		prophetBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		prophetIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		prophetText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		prophet.SetActive (false);

		temple = GameObject.Find ("Scene1/Capa1/Screen3/Temple");
		templeBG = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Background");
		templeIcon = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Icon");
		templeText = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Text");
		templeBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		templeIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		templeText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		temple.SetActive (false);

		ship = GameObject.Find ("Scene1/Capa1/Screen3/Ship");
		shipBG = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Background");
		shipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Icon");
		shipText = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Text");
		shipBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		shipIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		shipText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		ship.SetActive (false);

		factory = GameObject.Find ("Scene1/Capa1/Screen3/Factory");
		factoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Background");
		factoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Icon");
		factoryText = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Text");
		factoryBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		factoryIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		factoryText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		factory.SetActive (false);

		laboratory = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory");
		laboratoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Background");
		laboratoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Icon");
		laboratoryText = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Text");
		laboratoryBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		laboratoryIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		laboratoryText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		laboratory.SetActive (false);

		shop = GameObject.Find ("Scene1/Capa1/Screen3/Shop");
		shopBG = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Background");
		shopIcon = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Icon");
		shopText = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Text");
		shopBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		shopIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		shopText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		shop.SetActive (false);

		spaceship = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship");
		spaceshipBG = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Background");
		spaceshipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Icon");
		spaceshipText = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Text");
		spaceshipBG.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency);
		spaceshipIcon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency);
		spaceshipText.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency);
		spaceship.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		RegularComprobation ("meh", ref servantStatus, ref servant, ref servantBG, ref servantIcon, ref servantText, Lang.SERVANT_NAME);
		RegularComprobation (servantStatus, ref humanStatus, ref human, ref humanBG, ref humanIcon, ref humanText, Lang.HUMAN_NAME);
		RegularComprobation (humanStatus, ref prophetStatus, ref prophet, ref prophetBG, ref prophetIcon, ref prophetText, Lang.PROPHET_NAME);
		RegularComprobation (prophetStatus, ref templeStatus, ref temple, ref templeBG, ref templeIcon, ref templeText, Lang.TEMPLE_NAME);
		RegularComprobation (templeStatus, ref shipStatus, ref ship, ref shipBG, ref shipIcon, ref shipText, Lang.SHIP_NAME);
		RegularComprobation (shipStatus, ref factoryStatus, ref factory, ref factoryBG, ref factoryIcon, ref factoryText, Lang.FACTORY_NAME);
		RegularComprobation (factoryStatus, ref laboratoryStatus, ref laboratory, ref laboratoryBG, ref laboratoryIcon, ref laboratoryText, Lang.LABORATORY_NAME);
		RegularComprobation (laboratoryStatus, ref shopStatus, ref shop, ref shopBG, ref shopIcon, ref shopText, Lang.SHOP_NAME);
		RegularComprobation (shopStatus, ref spaceshipStatus, ref spaceship, ref spaceshipBG, ref spaceshipIcon, ref spaceshipText, Lang.SPACESHIP_NAME);

	}

	private void RegularComprobation(string previousStatus, ref string status, ref GameObject father, ref GameObject background, ref GameObject icon, ref GameObject text, int LangCode) {

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
		}

		float producerAlpha = 1f;

		if (selectedStatus == 0f) {
			producerAlpha = 1f;
		}

		if (status == "undiscovered") {
			background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			icon.GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, discovered_transparency*producerAlpha);
			text.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
		} else if (status == "discovered") {
			background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
			text.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, discovered_transparency*producerAlpha);
		} else if (status == "buyable") {
			background.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			icon.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f*producerAlpha);
			text.GetComponent<TextMesh> ().color = new Color(1f, 1f, 1f, 1f*producerAlpha);
		}


	}

}
