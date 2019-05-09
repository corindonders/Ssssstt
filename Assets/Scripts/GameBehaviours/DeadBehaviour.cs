using UnityEngine;
using UnityEngine.SceneManagement;


public class DeadBehaviour : MonoBehaviour {
		private LiveBehaviour Lives;
		private int _lives;
		private bool _dead = false;
		public bool dead {
			get {
				return _dead;
			}
		}

		void Start() 
		{
			Lives = GetComponent<LiveBehaviour>();
			_lives = Lives.currentLives;
		}

		void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
			_lives--;
			Destroy (other.gameObject);
			GetComponent<AudioSource> ().Play ();	
		}
		Lives.currentLives = _lives;

		if (Lives.currentLives == 0) {
			SceneManager.LoadScene ("Gameover_Scene");	
		}
	}
}
