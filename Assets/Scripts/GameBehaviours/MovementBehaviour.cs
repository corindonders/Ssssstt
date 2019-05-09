using UnityEngine;

public class MovementBehaviour : MonoBehaviour {
	private GameObject _camera;
	
	void Start() 
    {
		_camera = GameObject.FindWithTag("MainCamera");
	}
	void Update()
    {
        transform.LookAt(_camera.transform);
        transform.position += GetForward() / 50;
    }

    private Vector3 GetForward()
    {
        return transform.forward;
    }
}
