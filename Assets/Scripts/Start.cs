using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Start : MonoBehaviour {


	public void OnTriggerEnter(Collider node) {
		if(node.gameObject.tag == "Bullet")
		{
			SceneManager.LoadScene ("Corin_Scene");	

		}
	}
		
}
