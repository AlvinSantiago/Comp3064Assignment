using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>
public class SpawnController : MonoBehaviour {
	
	[SerializeField]
	private float spawnRate;
	public GameObject [] enemyCopters;
	[SerializeField]
	private int enemyWaves=1;
	/// <summary>
	/// the spawn enemy funciton will generate enemy copters according to where it was instantiated and where on the scene it was specified. 
	/// the spawn enemy function is then invoke to be called repeatedly while the program is running.
	/// </summary>



	void Start () {
		InvokeRepeating ("SpawnEnemy",spawnRate, spawnRate);
	}
	

	void SpawnEnemy () {
		for (int i = 0; i < enemyWaves; i++) {
			Instantiate (enemyCopters [(int)Random.Range (0, enemyCopters.Length)], new Vector3 ( 100,Random.Range (-41f, 41f), 1), Quaternion.identity);
		}
	}
}
