using UnityEngine;
using System.Collections;

public class Capa1Screen1Script : MonoBehaviour {

	private Upgrade[] upgrades = new Upgrade[100];

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 100; i++) {

			Upgrade upgrade = new Upgrade(this.gameObject, 0, "Upgrade_"+i, 0);

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


		//public string status;
		//public int langCode;
		//public int description;
		//public GameObject text;
		//public GameObject loveIcon;
		//public GameObject cost;

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
		
		
		public Upgrade(GameObject parent, int position, string name, int langAux) {
			
			//status = "unexistant";
			
			root =  Instantiate(Resources.Load("Upgrade")) as GameObject;
			root.name = name;
			root.transform.parent = parent.transform;
			root.transform.localPosition = new Vector3(0, root.transform.localPosition.y +3f -2.5f*position, root.transform.localPosition.z);
			
			//text = root.gameObject.transform.FindChild("Text").gameObject;
			//cost = root.gameObject.transform.FindChild("Cost").gameObject;
			//cost.SetActive(false);

			
			//loveIcon = root.gameObject.transform.FindChild("LoveIcon").gameObject;
			//Material mat = Instantiate(loveIcon.GetComponent<SpriteRenderer>().material) as Material;
			//loveIcon.GetComponent<SpriteRenderer>().sharedMaterial = mat;
			//loveIcon.SetActive(false);
			
		
			board = root.gameObject.transform.FindChild("Upg_Board").gameObject;
			board.SetActive(false);

			button = root.gameObject.transform.FindChild("Upg_Button").gameObject;
			button.SetActive(false);

			icon = root.gameObject.transform.FindChild("Upg_Icon").gameObject;
			icon.SetActive(false);

			staticClosedU = root.gameObject.transform.FindChild("Closed_Unavailable").gameObject;
			staticClosedU.SetActive(false);

			staticClosedA = root.gameObject.transform.FindChild("Closed_Available").gameObject;
			staticClosedA.SetActive(false);

			staticShrinked = root.gameObject.transform.FindChild("Shrinked").gameObject; 
			//staticShrinked.SetActive(false);

			/*
			if (langAux == Lang.SERVANT_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/servant"); 
				description = Lang.SERVANT_DESCRIPTION;
			}
			if (langAux == Lang.HUMAN_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/human"); 
				description = Lang.HUMAN_DESCRIPTION;
			}
			if (langAux == Lang.PROPHET_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/prophet"); 
				description = Lang.PROPHET_DESCRIPTION;
			}
			if (langAux == Lang.TEMPLE_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); 
				description = Lang.TEMPLE_DESCRIPTION;
			}
			if (langAux == Lang.SHIP_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma");
				description = Lang.SHIP_DESCRIPTION;
			}
			if (langAux == Lang.FACTORY_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); 
				description = Lang.FACTORY_DESCRIPTION;
			}
			if (langAux == Lang.LABORATORY_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); 
				description = Lang.LABORATORY_DESCRIPTION;
			}
			if (langAux == Lang.SHOP_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma"); 
				description = Lang.SHOP_DESCRIPTION;
			}
			if (langAux == Lang.SPACESHIP_NAME) { 
				icon_producer.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite>("Producers/grandma");
				description = Lang.SPACESHIP_DESCRIPTION;
			}
			*/
			
			root.SetActive(true);
			
			//langCode = langAux;
			
		}
		
	}

}
