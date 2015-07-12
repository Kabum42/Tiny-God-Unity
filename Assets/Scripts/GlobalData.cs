using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public static class GlobalData {
	
	public static bool started = false;
	public static double love = 1f;

	public static float CAPA1_WIDTH_SCREEN = 20f;
	

	
	public static void Start() {

		started = true;


	}
	
	public static void Update() {

		love += love*Time.deltaTime;

	}

	public static String FormattedNumber(double d) {

		String result = "";
		String finalWord = "";

		int iterations = 0;
		
		while (d > 1000) {
			iterations++;
			d = d / 1000;
		}

		if (iterations == 1) {
			finalWord = "K";
		}
		else if (iterations == 2) {
			finalWord = "million";
		}
		else if (iterations == 3) {
			finalWord = "billion";
		}
		else if (iterations == 4) {
			finalWord = "trillion";
		}
		else if (iterations == 5) {
			finalWord = "quadrillion";
		}
		else if (iterations == 6) {
			finalWord = "quintillion";
		}
		else if (iterations == 7) {
			finalWord = "sextillion";
		}
		else if (iterations == 8) {
			finalWord = "septillion";
		}
		else if (iterations == 9) {
			finalWord = "octillion";
		}
		else if (iterations == 10) {
			finalWord = "nonillion";
		}

		result = d.ToString ("F3") + " " + finalWord;

		return result;

	}
	
}
