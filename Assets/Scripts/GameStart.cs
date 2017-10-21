using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour {
	
	public void PlayGame(){
		PlayerPrefs.SetInt ("Score", 0);
		SceneManager.LoadScene ("MainScene");
	}
	public void TitleScreen(){
		SceneManager.LoadScene (0);
	}

}
