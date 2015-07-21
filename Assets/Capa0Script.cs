using UnityEngine;
using System.Collections;

public class Capa0Script : MonoBehaviour {

	private GameObject background;
	public Gradient color_background;

	// Use this for initialization
	void Start () {
	
		background = GameObject.Find ("Scene1/Capa0/Background");

	}
	
	// Update is called once per frame
	void Update () {

		background.GetComponent<SpriteRenderer> ().material.color = color_background.Evaluate (GlobalData.thisState.timeOfDay);
	
	}
}
