using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    //This allows the camera to be rotated up and down
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressing W key");
            transform.Rotate(Vector3.right, -2);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S key");
            transform.Rotate(Vector3.left, -2);
        }
    }
}
