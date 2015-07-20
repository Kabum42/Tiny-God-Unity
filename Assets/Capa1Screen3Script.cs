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

	// Use this for initialization
	void Start () {

		servant = GameObject.Find ("Scene1/Capa1/Screen3/Servant");
		servantBG = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Background");
		servantIcon = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Icon");
		servantText = GameObject.Find ("Scene1/Capa1/Screen3/Servant/Text");

		human = GameObject.Find ("Scene1/Capa1/Screen3/Human");
		humanBG = GameObject.Find ("Scene1/Capa1/Screen3/Human/Background");
		humanIcon = GameObject.Find ("Scene1/Capa1/Screen3/Human/Icon");
		humanText = GameObject.Find ("Scene1/Capa1/Screen3/Human/Text");

		prophet = GameObject.Find ("Scene1/Capa1/Screen3/Prophet");
		prophetBG = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Background");
		prophetIcon = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Icon");
		prophetText = GameObject.Find ("Scene1/Capa1/Screen3/Prophet/Text");

		temple = GameObject.Find ("Scene1/Capa1/Screen3/Temple");
		templeBG = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Background");
		templeIcon = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Icon");
		templeText = GameObject.Find ("Scene1/Capa1/Screen3/Temple/Text");

		ship = GameObject.Find ("Scene1/Capa1/Screen3/Ship");
		shipBG = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Background");
		shipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Icon");
		shipText = GameObject.Find ("Scene1/Capa1/Screen3/Ship/Text");

		factory = GameObject.Find ("Scene1/Capa1/Screen3/Factory");
		factoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Background");
		factoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Icon");
		factoryText = GameObject.Find ("Scene1/Capa1/Screen3/Factory/Text");

		laboratory = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory");
		laboratoryBG = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Background");
		laboratoryIcon = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Icon");
		laboratoryText = GameObject.Find ("Scene1/Capa1/Screen3/Laboratory/Text");

		shop = GameObject.Find ("Scene1/Capa1/Screen3/Shop");
		shopBG = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Background");
		shopIcon = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Icon");
		shopText = GameObject.Find ("Scene1/Capa1/Screen3/Shop/Text");

		spaceship = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship");
		spaceshipBG = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Background");
		spaceshipIcon = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Icon");
		spaceshipText = GameObject.Find ("Scene1/Capa1/Screen3/Spaceship/Text");
	
	}
	
	// Update is called once per frame
	void Update () {

		servantText.GetComponent<TextMesh> ().text = Lang.getText(Lang.SERVANT_NAME);
		humanText.GetComponent<TextMesh> ().text = Lang.getText(Lang.HUMAN_NAME);
		prophetText.GetComponent<TextMesh> ().text = Lang.getText(Lang.PROPHET_NAME);
		templeText.GetComponent<TextMesh> ().text = Lang.getText(Lang.TEMPLE_NAME);
		shipText.GetComponent<TextMesh> ().text = Lang.getText(Lang.SHIP_NAME);
		factoryText.GetComponent<TextMesh> ().text = Lang.getText(Lang.FACTORY_NAME);
		laboratoryText.GetComponent<TextMesh> ().text = Lang.getText(Lang.LABORATORY_NAME);
		shopText.GetComponent<TextMesh> ().text = Lang.getText(Lang.SHOP_NAME);
		spaceshipText.GetComponent<TextMesh> ().text = Lang.getText(Lang.SPACESHIP_NAME);
	
	}
}
