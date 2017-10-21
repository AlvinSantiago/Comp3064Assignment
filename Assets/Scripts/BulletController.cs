using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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