using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Replay : MonoBehaviour {


	void Start () {
	}

	public void OnTriggerEnter(Collider node) {
		if(node.gameObject.tag == "Bullet")
		{
			SceneManager.LoadScene ("Corin_Scene");	
		}
	}
		
}
