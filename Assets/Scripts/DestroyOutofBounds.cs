using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>
public class DestroyOutofBounds : MonoBehaviour {
	/// <summary>
	/// Destroys any game object that exists the game screen.
	/// </summary>

	void OnTriggerEnter2d(Collider2D col){
		Destroy (col.gameObject);
	}
}
