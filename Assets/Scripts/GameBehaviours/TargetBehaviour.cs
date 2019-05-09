using UnityEngine;

public class TargetBehaviour : MonoBehaviour {
	private GameObject _camera;

	void Start() {
		_camera = GameObject.FindWithTag("MainCamera");
	}
	void Update() {
		transform.LookAt(_camera.transform);
	}
}