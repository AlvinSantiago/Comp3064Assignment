using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>
public class BulletController : MonoBehaviour {
	Rigidbody2D rigidBody;
	int bulletDirection=1;

	void Start(){
		Destroy (gameObject, 3);
	}

	void Awake(){
		rigidBody = GetComponent<Rigidbody2D> ();

	}


	public void BulletDirection(){
		bulletDirection *= -1;
	}




	void Update () {
		rigidBody.velocity = new Vector2 (80* bulletDirection,0);
	}
	/// <summary>
	/// Checks if the bullet hits either a enemy or the player game object
	/// if the the direction is equal to 1 it will be registered as a hit to an enemy copter.
	/// after the calculations from the damaged function of the enemy class is done the bullet is then destroyed.
	/// the same logic is followed if it hits the player but the checkfordamage function is called instead
	///  </summary>
	/// <param name="col">Col.</param>
	void OnTriggerEnter2D(Collider2D col){
		if (bulletDirection == 1) {
			if (col.gameObject.tag == "Enemy") {
				col.gameObject.GetComponent<EnemyController> ().Damaged ();
				Destroy (gameObject);
			}
		}
		else if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<PlayerController> ().checkForDamage ();
			Destroy (gameObject);
		}

	
}

}