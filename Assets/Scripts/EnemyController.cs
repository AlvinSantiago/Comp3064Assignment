using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	Rigidbody2D rigidBody;

	public  float speedX;

	public GameObject enemyBullet;
	public GameObject explosionAnimation;
	public GameObject extraLife;
	public float speedY;
	[SerializeField]
	bool canShoot;
	[SerializeField]
	float fireRate;
	[SerializeField]
	float copterHealth;

	public int enemyScore;



	void Awake(){
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	/// <summary>
	/// start methods checks if enemy type can shoot. if it can, the enemy's firing rate will be ranomized between half and double the set firerate. 
	/// the invokerepeating will then call the firebullet method at a rate corresponding to the value of the fireRate value.
	/// </summary>

	void Start () {
		Destroy (gameObject, 6);
		if (!canShoot)
			return;
		fireRate = fireRate + (Random.Range (fireRate / -2, fireRate / 2));
			InvokeRepeating ("FireBullet", fireRate, fireRate);
		

	}


	void Update () {
		rigidBody.velocity = new Vector2 (speedX --, speedY );
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			collision.gameObject.GetComponent<PlayerController> ().checkForDamage ();
			Die ();

		}

	}
	void Die(){
		if((int)Random.Range(0,5)==0)
			Instantiate(extraLife, transform.position, Quaternion.identity);
		Instantiate (explosionAnimation, transform.position, Quaternion.identity);
		PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+enemyScore);
		Destroy (gameObject);

	}
	public void Damaged(){
		copterHealth--;
		if (copterHealth == 0)
			
			Die ();
		
			

	}
	void FireBullet(){
		GameObject fire = (GameObject)Instantiate (enemyBullet, transform.position, Quaternion.identity);
		fire.GetComponent<BulletController> ().BulletDirection ();
	    
	}

}
