using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastCopterController : MonoBehaviour {
	Rigidbody2D rigidBody;

	public  float speedX;
	/// <summary>
	/// speed x and speed y respectively determine how fast the copter will fly in the upwards or downwards direction
	/// The canshoot boolean will be true or false depending on the copter type.
	/// Firerate determines how fast the enemy copters shoot back at the player 
	/// copterhealth determines how many hits the copters can take from the player.
	/// </summary>
	public float speedY;
	[SerializeField]
	bool canShoot;
	[SerializeField]
	float fireRate;
	[SerializeField]
	float copterHealth;

	void Awake(){
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void Start () {
		


	}
	

	void Update () {
		rigidBody.velocity = new Vector2 (speedX --, speedY );
	}
	/// <summary>
	/// checks if the copter collides with the player.
	/// if so the check for damage function in the player class is called and damages the player.the enemy copter is also destroyed.
	/// </summary>
	/// 
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			collision.gameObject.GetComponent<PlayerController> ().checkForDamage ();
			Die ();
			
		}
		
	}
	void Die(){
		Destroy (gameObject);
	}
	/// <summary>
	/// when the copter health reaches zero the die funciton is called.
	/// </summary>
	public void Damaged(){
		copterHealth--;
		if (copterHealth == 0)
			Die ();
	}

}
