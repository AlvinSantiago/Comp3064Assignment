using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
