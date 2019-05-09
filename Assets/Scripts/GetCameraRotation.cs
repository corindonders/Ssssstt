using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCameraRotation : MonoBehaviour {

	private GameObject cameraToLookAt;


	void Start() {
		cameraToLookAt = GameObject.FindWithTag("MainCamera");
	}

	void Update() 
	{
		this.transform.localEulerAngles = new Vector3(cameraToLookAt.transform.localEulerAngles.x, cameraToLookAt.transform.localEulerAngles.y, 0);

		//float newRotation = cameraToLookAt.transform.eulerAngles.y;
		//Debug.Log(newRotation);

	}
}
