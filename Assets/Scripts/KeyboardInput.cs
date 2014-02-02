using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {

	Vector3 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			position.x -= 0.1f;
			transform.position = position;
		}

		if (Input.GetKey(KeyCode.UpArrow)) {
			position.z += 0.1f;
			transform.position = position;
		}

		if (Input.GetKey(KeyCode.RightArrow)) {
			position.x += 0.1f;
			transform.position = position;
		}

		if (Input.GetKey(KeyCode.DownArrow)) {
			position.z -= 0.1f;
			transform.position = position;
		}

		//Up and Down
		if (Input.GetKey(KeyCode.A)) {
			position.y += 0.1f;
			transform.position = position;
		}else if (Input.GetKey(KeyCode.Z)) {
			position.y -= 0.1f;
			transform.position = position;
		}


	}
}
