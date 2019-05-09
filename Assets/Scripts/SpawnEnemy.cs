using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject[] objects;                // The prefab to be spawned.
	public float spawnTime = 6f;            // How long between each spawn.
	private Vector3 spawnPosition;

	// Use this for initialization
	void Start () 
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

	}

	void Spawn ()
	{
		spawnPosition.x = Random.Range (-30, 30);
		spawnPosition.y = Random.Range (5, 40);
		spawnPosition.z = Random.Range (-44, 44);

		Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
		}
		
}
