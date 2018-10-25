using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    //I am using it to rotate the snowman's base based on keyboard presses.
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left, -2);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right, -2);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, -2);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, -2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressing A key");
            transform.RotateAround(GetComponent<Rigidbody>().position, Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressing D key");
            transform.RotateAround(GetComponent<Rigidbody>().position, Vector3.up, 1);
        }
    }
}
