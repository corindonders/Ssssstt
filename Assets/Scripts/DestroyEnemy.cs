using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void OnTriggerEnter(Collider node) {
		if(node.gameObject.tag == "Bullet")
		{
			Destroy(gameObject);
			Debug.Log("Destroy");
			GetComponent<AudioSource> ().Play ();	
			// Increase the score by the enemy's score value.
			ScoreManager.score += scoreValue;
		}
	}
		


}
