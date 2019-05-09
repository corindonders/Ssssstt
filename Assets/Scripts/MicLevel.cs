using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicLevel : MonoBehaviour {

	public float Multiply = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var rms = MicInput.MicLoudness * Multiply;

		// Debug.Log(rms);

		if(rms > 9)
		{
			Debug.Log("SSST");			
		}


	}

}
