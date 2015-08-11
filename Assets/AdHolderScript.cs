using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdHolderScript : MonoBehaviour {

	public InterstitialAd interstitial;
	public int showedAd = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (showedAd == 1) {
			
			if (interstitial.IsLoaded()) {
				showedAd = 2;
				interstitial.Show();
			}
			
		}
	
	}

	public void LoadInterstitial() {
		
		showedAd = 0;
		
		interstitial = new InterstitialAd("ca-app-pub-7511456809904271/6234934949");
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);
		
	}

}
