using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveBehaviour : MonoBehaviour {
	private int _lives = 6;
	private int _currentLives;

	public int currentLives {
		get {
			return _currentLives;
		}
		set {
			int _minLives = _currentLives - 2;
			if (_minLives < value && value <_currentLives && 0 <= value) {
				_currentLives = value;
			
			}
		}
	}

	void Start() 
	{
		_currentLives = _lives;
	}
}
