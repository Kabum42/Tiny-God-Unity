using UnityEngine;
using System.Collections;

public class Capa2Script : MonoBehaviour {

	public GameObject capa2Top;
	public GameObject capa2TopText;
	public GameObject capa2TopText2;
	public GameObject capa2Dots;
	public GameObject capa2Heart;
	public GameObject capa2Miracle1;
	public GameObject capa2MiracleHeader;
	public GameObject capa2MiracleBar;
	public GameObject capa2Miracle2;
	public GameObject capa2MiracleButtonBase;
	public GameObject capa2MiracleButton;
	public GameObject capa2LoveGained;
	public GameObject capa2LoveGainedIcon;

	public GameObject[] iconHearts = new GameObject[10];
	public float[] iconCounters = new float[10];
	public bool[] iconCrits = new bool[10];
	public float[] iconT = new float[10];
	public Vector3[] iconOrigins = new Vector3[10];
	public Vector3[] iconControls = new Vector3[10];

	public float gainedIconCounter = 0f;

	private AudioSource rise3;
	private AudioSource tap;

	private Vector3 lastMousePosition = new Vector3(0f, 0f, 0f);

	// Use this for initialization
	void Start () {

		capa2Top = GameObject.Find ("Capa2/Top");
		capa2TopText = GameObject.Find ("Capa2/Top/TopText");
		capa2TopText2 = GameObject.Find ("Capa2/Top/TopText2");
		capa2Dots = GameObject.Find ("Capa2/Dots");
		capa2Heart = GameObject.Find ("Capa2/Heart");
		capa2Miracle1 = GameObject.Find ("Capa2/Miracle1");
		capa2MiracleHeader = GameObject.Find ("Capa2/Miracle1/MiracleHeader");
		capa2MiracleBar = GameObject.Find ("Capa2/Miracle1/MiracleBar");
		capa2Miracle2 = GameObject.Find ("Capa2/Miracle2");
		capa2MiracleButtonBase = GameObject.Find ("Capa2/Miracle2/ButtonBase");
		capa2MiracleButton = GameObject.Find ("Capa2/Miracle2/MiracleButton");
		capa2LoveGained = GameObject.Find ("Capa2/LoveGained");
		capa2LoveGainedIcon = GameObject.Find ("Capa2/LoveGainedIcon");

		for (int i = 0; i < iconHearts.Length; i++) {
			iconHearts[i] = Instantiate(capa2LoveGainedIcon);
			iconHearts[i].name = "Heart"+i;
			iconHearts[i].transform.parent = capa2LoveGainedIcon.transform.parent;
			iconHearts[i].SetActive(false);
			iconCounters[i] = 0f;
		}
		
		capa2Miracle2.SetActive (false);
		capa2LoveGained.SetActive (false);
		capa2LoveGainedIcon.SetActive (false);

		rise3 = gameObject.AddComponent<AudioSource>();
		rise3.clip = Resources.Load ("Audio/rise3") as AudioClip;
		rise3.volume = 1f;
		rise3.playOnAwake = false;

		tap = gameObject.AddComponent<AudioSource>();
		tap.clip = Resources.Load ("Audio/tap") as AudioClip;
		tap.volume = 1f;
		tap.playOnAwake = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		string original = GlobalData.FormattedNumber(GlobalData.thisState.love);
		string[] parts = original.Split(' ');
		capa2TopText.GetComponent<TextMesh> ().text = parts[0];
		if (parts [1] != null) {
			capa2TopText2.GetComponent<TextMesh> ().text = parts [1];
		} else {
			capa2TopText2.GetComponent<TextMesh> ().text = "";
		}
		
		capa2TopText2.GetComponent<TextMesh> ().fontSize = 40;
		
		while (capa2TopText2.GetComponent<MeshRenderer> ().bounds.size.x > 1.5f) {
			capa2TopText2.GetComponent<TextMesh> ().fontSize -= 1;
		}

		float anim_dots = 0.5f - (float) Camera.main.GetComponent<MainScript>().capa1.transform.position.x / 80f;
		if (anim_dots >= 0.49f && anim_dots <= 0.51f) { anim_dots = 0.49f; }
		if (anim_dots >= 0.74f && anim_dots <= 0.76f) { anim_dots = 0.74f; }
		if (anim_dots > 0.99f) { anim_dots = 0.99f; }
		capa2Dots.GetComponent<Animator> ().Play ("Slide", 0, anim_dots);
		
		anim_dots += 0.060f;
		capa2Top.GetComponent<Animator> ().Play ("Transition", 0, anim_dots);
		capa2MiracleHeader.GetComponent<Animator> ().Play ("Transition", 0, anim_dots);
		capa2MiracleButtonBase.GetComponent<Animator> ().Play ("Transition", 0, anim_dots);
		
		capa2MiracleBar.GetComponent<Animator> ().Play ("Grow", 0, (float) GlobalData.thisState.minigame_timer);
		
		if (GlobalData.thisState.minigame_timer == 1f) {
			if (capa2Miracle1.transform.localPosition.y > -11.5f) {
				if (capa2Miracle1.transform.localPosition.y == -10f) {
					rise3.Play();
				}
				float aux_y = Mathf.Lerp (capa2Miracle1.transform.localPosition.y, -11.51f, Time.deltaTime*10f);
				capa2Miracle1.transform.localPosition = new Vector3(0, aux_y, -17.7f);
				if (aux_y <= -11.5f) { 
					capa2Miracle1.SetActive(false); 
					capa2Miracle2.SetActive(true);
				}
			} else {
				
				if (capa2Miracle2.transform.localPosition.y < -10.1f) {
					float aux_y = Mathf.Lerp (capa2Miracle2.transform.localPosition.y, -10f, Time.deltaTime*10f);
					capa2Miracle2.transform.localPosition = new Vector3(0, aux_y, -17.7f);
					if (aux_y >= -10.1f) { 
						capa2Miracle2.transform.localPosition = new Vector3(0, -10f, -17.7f);
					}
				}
				
				if (capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Idle") && capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
					capa2MiracleButton.GetComponent<Animator> ().Play ("Idle", 0, 0f);
				}
				
				if (capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Idle") && ClickedOn(capa2MiracleButton)) {
					tap.Play();
					capa2MiracleButton.GetComponent<Animator> ().Play ("Pressing", 0, 0f);
				}
				
				if (capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName("Pressing") && capa2MiracleButton.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1f) {
					Application.LoadLevelAdditive("MiniGame");
				}
				
			}
			
		}
		
		if (capa2Heart.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.99f) {
			capa2Heart.GetComponent<Animator>().Play("Idle", 0, 0);
		}

		if (capa2LoveGained.activeInHierarchy) {
			capa2LoveGained.transform.localPosition = new Vector3(capa2LoveGained.transform.localPosition.x, capa2LoveGained.transform.localPosition.y +Time.deltaTime*1f, capa2LoveGained.transform.localPosition.z);
			capa2LoveGained.GetComponent<TextMesh>().color = new Color(capa2LoveGained.GetComponent<TextMesh>().color.r, capa2LoveGained.GetComponent<TextMesh>().color.g, capa2LoveGained.GetComponent<TextMesh>().color.b, capa2LoveGained.GetComponent<TextMesh>().color.a - Time.deltaTime);
			if (capa2LoveGained.GetComponent<TextMesh>().color.a <= 0f) {
				capa2LoveGained.SetActive(false);
			}
		}

		for (int i = 0; i < iconHearts.Length; i++) {
			if (iconHearts[i].activeInHierarchy) {
				if (iconCounters[i] < 0.3f) {
					iconCounters[i] += Time.deltaTime;
					if (iconCounters[i] >= 0.3f) { 
						iconCounters[i] = 0.3f; 
						iconT[i] = 0f;
						iconOrigins[i] = iconHearts[i].transform.localPosition;
						iconControls[i] = (iconOrigins[i] + capa2Heart.transform.position)/2 + new Vector3(Random.Range(-5f, 5f), 0f, 0f);
					}
					iconHearts[i].transform.localPosition = new Vector3(iconHearts[i].transform.localPosition.x, iconHearts[i].transform.localPosition.y +Time.deltaTime*1f, iconHearts[i].transform.localPosition.z);
				}
				if (iconCounters[i] == 0.3f) {
					iconT[i] = Mathf.Lerp(iconT[i], 1f, Time.deltaTime*5f);
					iconHearts[i].transform.position = capa2Heart.transform.position*Mathf.Pow(iconT[i], 2f) + iconControls[i]*2f*iconT[i]*(1f-iconT[i]) + iconOrigins[i]*Mathf.Pow(1f - iconT[i], 2f);
				}
				if (Mathf.Abs(iconHearts[i].transform.position.x - capa2Heart.transform.position.x) < 0.1f && Mathf.Abs(iconHearts[i].transform.position.y - capa2Heart.transform.position.y) < 0.1f) {
					iconHearts[i].SetActive(false);
					if (iconCrits[i]) {
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Crit", 0, 0);
					}
					else {
						Camera.main.GetComponent<MainScript>().capa2Heart.GetComponent<Animator>().Play("Pulse", 0, 0);
					}
				}
			}
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
				
			}
			
		} else {
			
			if (Input.touchCount > 0) { 
				
				if (Input.GetTouch(0).phase == TouchPhase.Began) {
					
					lastMousePosition = Input.GetTouch(0).position;
					
				} else if (Input.GetTouch(0).phase == TouchPhase.Ended) {
					
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
					
				}
				
			}
			
		}
		
		return false;
		
	}

}
