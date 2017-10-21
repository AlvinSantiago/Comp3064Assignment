using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>
public class GameStart : MonoBehaviour {
	
	public void PlayGame(){
		PlayerPrefs.SetInt ("Score", 0);
		SceneManager.LoadScene ("MainScene");
	}
	public void TitleScreen(){
		SceneManager.LoadScene (0);
	}

}
