using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour {

	void OnTriggerEnter(Collider target)
	{
		if(target.tag == "Enemy")
		{
			GetComponent<AudioSource>().Play();
		}
	}


}
