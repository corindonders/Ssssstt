using UnityEngine;
using System.Collections;

public class AddPoints : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.P)) // Change this to your thing!
		{
			PointScore.pointScore += 5;
			Destroy (gameObject);
		}
	}
}