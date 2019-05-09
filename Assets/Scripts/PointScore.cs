using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointScore : MonoBehaviour
{
	Text txt;
	public static int pointScore = 0;


	void Start () {
		txt=GameObject.Find("TotalScore").GetComponent<Text>(); 
	}

	// Update is called once per frame
	void Update () {
		txt.text="Score : " + pointScore;  
	}


}