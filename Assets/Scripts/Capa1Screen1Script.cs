using UnityEngine;
using System.Collections;

public class Capa1Screen1Script : MonoBehaviour {

	private Upgrade[] upgrades = new Upgrade[96];

	// Use this for initialization
	void Start () {

		int current_upgrade = 22;

		for (int i = 0; i < 96; i++) {

			Upgrade upgrade = new Upgrade(this.gameObject, "Upgrade_"+i, current_upgrade);

			current_upgrade+= 2;

			if (current_upgrade == 42) {
				// THIS IS THE MOTHERFLIPPING HUMAN!!!
				current_upgrade = 44;
			} else if (current_upgrade == 78) {
				// THIS SPECIAL HUMAN DOESN'T EXIST
				current_upgrade = 86;
			} else if (current_upgrade == 106) {
				// THIS IS THE MOTHERFLIPPING TEMPLE!!!
				current_upgrade = 108;
			} else if (current_upgrade == 128) {
				// THIS IS THE MOTHERFLIPPING SHIP!!!
				current_upgrade = 130;
			} else if (current_upgrade == 150) {
				// THIS IS THE MOTHERFLIPPING FACTORY!!!
				current_upgrade = 152;
			} else if (current_upgrade == 172) {
				// THIS IS THE MOTHERFLIPPING LABORATORY!!!
				current_upgrade = 174;
			} else if (current_upgrade == 194) {
				// THIS IS THE MOTHERFLIPPING SHOP!!!
				current_upgrade = 196;
			} else if (current_upgrade == 216) {
				// THIS IS THE MOTHERFLIPPING SPACESHIP!!!
				current_upgrade = 218;
			}

			//Debug.Log (current_upgrade);

			//GameObject auxGO =  Instantiate(Resources.Load("Upgrade")) as GameObject;
			//auxGO.name = "Upgrade_"+i;
			//auxGO.transform.parent = this.gameObject.transform;
			//auxGO.transform.localPosition = new Vector3(0, auxGO.transform.localPosition.y, auxGO.transform.localPosition.z);

			upgrades[i] = upgrade;
			//auxGO.SetActive(false);

		}

		//upgrades [0] = new GameObject ();
	
	}
	
	// Update is called once per frame
	void Update () {

		Upgrade[] upgradesClosed = new Upgrade[96];
		Upgrade[] upgradesShrinked = new Upgrade[96];
		int currentClosed = 0;
		int currentShrinked = 0;
		float current_Y = 0f;

		for (int i = 0; i < upgrades.Length; i++) {

			if (upgrades[i].status == "unexistant") {
				// PUEDE ESTAR PARA COMPRAR O HABER SIDO COMPRADO YA
				if (GlobalData.thisState.values[upgrades[i].langCode] == 0 && GlobalData.thisState.values[upgrades[i].typeRequired] >= upgrades[i].amountRequired) {

					upgrades[i].root.transform.localPosition = new Vector3(0f, 2.7f -current_Y, upgrades[i].root.transform.localPosition.z);
					current_Y += 2.5f;
					upgrades[i].status = "available";

					upgrades[i].text.GetComponent<TextMesh>().text = Lang.getText(upgrades[i].langCode);
					upgrades[i].root.SetActive(true);

				}
			}

			if (upgrades[i].status == "available" || upgrades[i].status == "buyable") {

				upgradesClosed[currentClosed] = upgrades[i];
				currentClosed++;

				upgrades[i].root.transform.localPosition = new Vector3(0f, Mathf.Lerp(upgrades[i].root.transform.localPosition.y, 2.7f -current_Y, Time.deltaTime*10f), upgrades[i].root.transform.localPosition.z);
				current_Y += 2.5f;

				if (upgrades[i].status == "available" && upgrades[i].staticClosedU.activeInHierarchy && GlobalData.thisState.love >= upgrades[i].price) {

					upgrades[i].staticClosedU.SetActive(false);
					upgrades[i].board.SetActive(true);
					upgrades[i].icon.SetActive(true);
					upgrades[i].button.SetActive(true);
					upgrades[i].button.GetComponent<Animator> ().Play ("Changing2", 0, 0f);

					upgrades[i].status = "buyable";

				} 
				else if (upgrades[i].status == "buyable" && upgrades[i].button.activeInHierarchy && upgrades[i].button.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {

					upgrades[i].board.SetActive(false);
					upgrades[i].icon.SetActive(false);
					upgrades[i].button.SetActive(false);
					upgrades[i].staticClosedA.SetActive(true);

				}
				else if (upgrades[i].status == "buyable" && upgrades[i].staticClosedA.activeInHierarchy && GlobalData.thisState.love < upgrades[i].price) {
					
					upgrades[i].staticClosedA.SetActive(false);
					upgrades[i].board.SetActive(true);
					upgrades[i].icon.SetActive(true);
					upgrades[i].button.SetActive(true);
					upgrades[i].button.GetComponent<Animator> ().Play ("Changing", 0, 0f);
					
					upgrades[i].status = "available";
					
				}
				else if (upgrades[i].status == "available" && upgrades[i].button.activeInHierarchy && upgrades[i].button.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
					
					upgrades[i].board.SetActive(false);
					upgrades[i].icon.SetActive(false);
					upgrades[i].button.SetActive(false);
					upgrades[i].staticClosedU.SetActive(true);
					
				}

			}
			if (upgrades[i].status == "bought") {
				upgradesShrinked[currentShrinked] = upgrades[i];
				currentShrinked++;
			}

		}

		/*
		int num_actives = 0;
		float origin_y = 2f;


		for (int i = 0; i < 100; i++) {


			float x_position = -1f + num_actives % 3f;
			float y_position = -Mathf.Floor(num_actives / 3);

			upgrades[i].SetActive(true);
			upgrades[i].transform.localPosition = new Vector3(x_position*3.2f, origin_y + y_position*2.5f, upgrades[i].transform.localPosition.z);

			if (true) {
				num_actives++;
			}

		}
		*/
	
	}


	public class Upgrade {
		
		public GameObject root;
		public string status;
		public int langCode;
		public double price;
		//public int description;
		public GameObject text;
		//public GameObject loveIcon;
		public GameObject cost;

		public int typeRequired;
		public int amountRequired;

		public GameObject board;
		public GameObject button;
		public GameObject icon;

		public GameObject staticClosedU;
		public GameObject staticClosedA;
		public GameObject staticShrinked;

		/*

		public GameObject buyButton;
		public GameObject icon;
		public GameObject screen;
		
		public GameObject hb_head;
		public GameObject hb_botcorner_right;
		public GameObject hb_botcorner_left;
		public GameObject hb_pix_foot;
		public GameObject hb_topcorner_right;
		public GameObject hb_topcorner_left;
		public GameObject hb_pix_section;
		public GameObject hb_pix_panel;
		
		public GameObject icon_shine;
		public GameObject icon_heart;
		public GameObject icon_heartside;
		public GameObject icon_cover;
		public GameObject icon_base;
		public GameObject icon_side;
		public GameObject icon_producer;
		
		public GameObject icon_cover_s;
		public GameObject sc_side;
		public GameObject sc_on;
		public GameObject sc_off;
		
		public GameObject bb_plus;
		public GameObject bb_plus_side;
		public GameObject bb_cross;
		public GameObject icon_cover_b;
		public GameObject bb_lock;
		public GameObject bb_square;
		public GameObject bb_square_side;
		
		public GameObject info;
		*/
		
		
		public Upgrade(GameObject parent, string name, int langAux) {
			
			status = "unexistant";
			
			root =  Instantiate(Resources.Load("Upgrade")) as GameObject;
			root.name = name;
			root.transform.parent = parent.transform;
			root.transform.localPosition = new Vector3(0, root.transform.localPosition.y +29f -langAux*1.2f, root.transform.localPosition.z);
			
			text = root.gameObject.transform.FindChild("Text").gameObject;
			cost = root.gameObject.transform.FindChild("Cost").gameObject;

			
			//loveIcon = root.gameObject.transform.FindChild("LoveIcon").gameObject;
			//Material mat = Instantiate(loveIcon.GetComponent<SpriteRenderer>().material) as Material;
			//loveIcon.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			//loveIcon.SetActive(false);
			
		
			board = root.gameObject.transform.FindChild("Upg_Board").gameObject;
			board.SetActive(false);

			button = root.gameObject.transform.FindChild("Upg_Button").gameObject;
			button.SetActive(false);

			icon = root.gameObject.transform.FindChild("Upg_Icon").gameObject;
			root.gameObject.transform.FindChild("Upg_Icon/icon_base/icon_producer").gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
			icon.SetActive(false);

			staticClosedU = root.gameObject.transform.FindChild("Closed_Unavailable").gameObject;
			root.gameObject.transform.FindChild("Shrinked/icon_producer").gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
			//staticClosedU.SetActive(false);

			staticClosedA = root.gameObject.transform.FindChild("Closed_Available").gameObject;
			staticClosedA.SetActive(false);

			staticShrinked = root.gameObject.transform.FindChild("Shrinked").gameObject; 
			root.gameObject.transform.FindChild("Shrinked/icon_producer").gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Upgrades/upgrade_0001"); 
			staticShrinked.SetActive(false);


			if (langAux <= Lang.SERVANT_UPGRADE_10) {
				typeRequired = Lang.SERVANT_NAME;
				int aux_position = (langAux - Lang.SERVANT_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.SERVANT_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.HUMAN_UPGRADE_10) { 
				typeRequired = Lang.HUMAN_NAME;
				int aux_position = (langAux - Lang.HUMAN_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.HUMAN_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.SPECIAL_HUMAN_10) {
				int aux_position = (langAux - Lang.SPECIAL_HUMAN_1)/2;
				if (aux_position == 0) {
					typeRequired = Lang.PROPHET_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.PROPHET_NAME));
				}
				else if (aux_position == 1) {
					typeRequired = Lang.TEMPLE_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.TEMPLE_NAME));
				}
				else if (aux_position == 2) {
					typeRequired = Lang.SHIP_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.SHIP_NAME));
				}
				else if (aux_position == 3) {
					typeRequired = Lang.FACTORY_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.FACTORY_NAME));
				}
				else if (aux_position == 4) {
					typeRequired = Lang.LABORATORY_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.LABORATORY_NAME));
				}
				else if (aux_position == 5) {
					typeRequired = Lang.SHOP_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.SHOP_NAME));
				}
				else if (aux_position == 6) {
					typeRequired = Lang.SPACESHIP_NAME;
					price = Mathf.Floor(GlobalData.getBaseCost(Lang.SPACESHIP_NAME));
				}
				amountRequired = 5;
			}
			else if (langAux <= Lang.PROPHET_UPGRADE_10) { 
				typeRequired = Lang.PROPHET_NAME;
				int aux_position = (langAux - Lang.PROPHET_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.PROPHET_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.TEMPLE_UPGRADE_10) { 
				typeRequired = Lang.TEMPLE_NAME;
				int aux_position = (langAux - Lang.TEMPLE_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.TEMPLE_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.SHIP_UPGRADE_10) { 
				typeRequired = Lang.SHIP_NAME;
				int aux_position = (langAux - Lang.SHIP_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.SHIP_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.FACTORY_UPGRADE_10) { 
				typeRequired = Lang.FACTORY_NAME;
				int aux_position = (langAux - Lang.FACTORY_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.FACTORY_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.LABORATORY_UPGRADE_10) { 
				typeRequired = Lang.LABORATORY_NAME;
				int aux_position = (langAux - Lang.LABORATORY_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.LABORATORY_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.SHOP_UPGRADE_10) { 
				typeRequired = Lang.SHOP_NAME;
				int aux_position = (langAux - Lang.SHOP_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.SHOP_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}
			else if (langAux <= Lang.SPACESHIP_UPGRADE_10) { 
				typeRequired = Lang.SPACESHIP_NAME;
				int aux_position = (langAux - Lang.SPACESHIP_UPGRADE_1)/2;
				price = Mathf.Floor(GlobalData.getBaseCost(Lang.SPACESHIP_NAME)*Mathf.Pow(10f, aux_position));
				if (aux_position == 0) { amountRequired = 1; }
				else if (aux_position == 1) { amountRequired = 10; }
				else { amountRequired = (aux_position-1)*25; }
			}

			cost.gameObject.GetComponent<TextMesh>().text = GlobalData.FormattedNumber(price);
			
			root.SetActive(false);
			
			langCode = langAux;
			
		}
		
	}

}
