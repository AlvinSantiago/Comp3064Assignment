using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour {
	/// <summary>
	/// Destroys any game object that exists the game screen.
	/// </summary>

	void OnTriggerEnter2d(Collider2D col){
		Destroy (col.gameObject);
	}
}
