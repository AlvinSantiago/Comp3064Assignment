using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Name: Delfin Alvin Santiago
/// ID: 101011029
/// Professor:Przemyslaw Pawluk
/// Due: October 20, 2017 
/// </summary>
/// 
public class SkyController : MonoBehaviour {
	[SerializeField]
	private float skySpeed = 0f;

	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;
	/*
	[SerializeField]
	private float startX = -190;
	[SerializeField]
	private float endX=190;

*/
	private Transform transform;
	private Vector2 currentPositon;

	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		currentPositon = transform.position;
		Reset ();
	}


	void Update () {

		currentPositon = transform.position;
		currentPositon -= new Vector2 (skySpeed, 0);

		if (currentPositon.x < endX) {
			Reset ();
		}
		transform.position = currentPositon;
	}
	private void Reset(){
		currentPositon = new Vector2 (startX, 0);
	}
}
