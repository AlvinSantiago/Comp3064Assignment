using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>

public class PlayPref : MonoBehaviour {

	public string name;


	
	//allows for the score and life labels to be updated according to the player actions
	void Update () {
		GetComponent<Text> ().text = PlayerPrefs.GetInt (name) + " ";
	}

}
