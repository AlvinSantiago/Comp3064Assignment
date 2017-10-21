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

public class PlayerController : MonoBehaviour {
	public AudioSource fireSound;
	GameObject playerBullet;
	[SerializeField]
	GameObject playerExplosion;
	Rigidbody2D rigidBody;
	public GameObject bullet;
	[SerializeField]
	private float speed;
	int fireDelay=0;
	[SerializeField]
	private int playerHealth=3;

	/// <summary>
	/// Class is responsible for all player actions and traits.
	/// The awake function makes sure that the player can interact with other gameobjects on the scene.
	/// The start function allows for the player lives to be properly display on the canvas
	/// The update function allows the player to utilize the WASD keys to move within the game. It allows calls the firebullet function to allow the player to shoot.
	/// The playerhit function starts quick animations for when the player is hit.
	/// The checkfordamage function allows the player sprite to recognize when it is hit and eventually destroy the object when the player life hits 0
	/// The die function destroys the game object
	/// the firebullet funciton creates a bullet from the bullet class and puts it on the scene. 
	/// The gain life function lets the player acquire more lives if they manage to pick up the crosses dropped by the enemy copters.
	/// </summary>




	void Awake(){
		rigidBody = GetComponent<Rigidbody2D> ();
		playerBullet = transform.Find ("Shoot").gameObject;
	}
	void Start(){
		PlayerPrefs.SetInt ("Lives", playerHealth);
	}

	void Update(){
		rigidBody.AddForce(new Vector2(Input.GetAxis("Horizontal")*speed,0));
		rigidBody.AddForce(new Vector2(0,Input.GetAxis("Vertical")*speed));

		if (Input.GetMouseButtonDown (0) && fireDelay > 10) 
			
			FireBullet ();

			fireDelay++;
		
	}
	IEnumerator PlayerHit()
	{
		GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0);
		yield return new WaitForSeconds (0.1f);
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
	}
	public void checkForDamage(){
		playerHealth--;
		PlayerPrefs.SetInt ("Lives", playerHealth);
		StartCoroutine (PlayerHit ());

		if (playerHealth == 0) {
			Instantiate (playerExplosion, transform.position, Quaternion.identity);
			Die ();
		
			SceneManager.LoadScene (2);
		}
	}
	void Die(){
		Destroy (gameObject, 0.1f);

	}
	void FireBullet(){
		fireDelay = 3;
		Instantiate (bullet, playerBullet.transform.position, Quaternion.identity);

	}
	public void GainLife(){
		playerHealth++;
		PlayerPrefs.SetInt ("Lives", playerHealth);
	}

	}

