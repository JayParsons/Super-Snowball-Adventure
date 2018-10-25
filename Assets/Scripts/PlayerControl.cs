using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public GUIStyle style = new GUIStyle();
    private bool hasCollided = false;
    private float currentPosition;

    // Use this for initialization
    void Start () {
       
    }

    // Update is called once per frame
    //This is used to move the character in a direction based on what
    //keyboard button is pressed.
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressing up arrow");
            GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 600);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Pressing down arrow");
            GetComponent<Rigidbody>().AddForce(-transform.forward * Time.deltaTime * 600);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Pressing left arrow");
            GetComponent<Rigidbody>().AddForce(-transform.right * Time.deltaTime * 600);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Pressing right arrow");
            GetComponent<Rigidbody>().AddForce(transform.right * Time.deltaTime * 600);
        }

        //also checks for collision with another rigid body. Player must be in contact
        //with a surface to be able to jump. Uses the hasCollided flag I've created
        //to do the check.
        if (Input.GetKey(KeyCode.Space) && hasCollided == true)
        {
            Debug.Log("Pressing space bar");
            currentPosition = GetComponent<Rigidbody>().position.y;
            if (GetComponent<Rigidbody>().position.y < currentPosition + 4)
                GetComponent<Rigidbody>().AddForce(Vector3.up * 400);
            hasCollided = false;
            currentPosition = GetComponent<Rigidbody>().position.y;
        }

        //Pressing 'A' or 'D' allows the player and the camera to be roated side to side
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
        Debug.Log(hasCollided);
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Checking for collision");
        if (collision.rigidbody)
            hasCollided = true;  //set flag to true if player is in contact with a surface
    }
}
