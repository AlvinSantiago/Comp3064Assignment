using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
	[SerializeField]
	private float spawnRate;
	public GameObject [] enemyCopters;
	[SerializeField]
	private int enemyWaves=1;
	void Start () {
		InvokeRepeating ("SpawnEnemy",spawnRate, spawnRate);
	}
	

	void SpawnEnemy () {
		for (int i = 0; i < enemyWaves; i++) {
			Instantiate (enemyCopters [(int)Random.Range (0, enemyCopters.Length)], new Vector3 ( 100,Random.Range (-41f, 41f), 1), Quaternion.identity);
		}
	}
}
