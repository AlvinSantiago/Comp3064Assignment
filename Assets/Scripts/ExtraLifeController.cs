using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>
public class ExtraLifeController : MonoBehaviour {
	public AudioSource pickupSound;

	void Start () {
		
	}
	

	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collide){
		if (collide.gameObject.tag == "Player") {
			collide.gameObject.GetComponent<PlayerController> ().GainLife ();
			Destroy (gameObject);
			this.pickupSound.Play ();
		}
	}

}
