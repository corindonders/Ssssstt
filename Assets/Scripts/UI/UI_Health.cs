using System.Collections.Generic;
using UnityEngine;
public class UI_Health : MonoBehaviour {
    private LiveBehaviour Lives;
	private int _lives;

    [SerializeField]GameObject[] _health_hards;

    void Start()
    {
		Lives = GetComponent<LiveBehaviour>();
    }

    void Update()
    {
		_lives = Lives.currentLives;
		Debug.Log(_lives);
		switch (_lives) {
			case 5:
				Destroy(_health_hards[0]);
				break;
			case 4:
				Destroy(_health_hards[1]);
				break;
			case 3:
				Destroy(_health_hards[2]);
				break;
			case 2:
				Destroy(_health_hards[3]);
				break;
			case 1:
				Destroy(_health_hards[4]);
				break;
			case 0:
				Destroy(_health_hards[5]);
				break;
		}
    }
}
