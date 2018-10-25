using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour {

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        //This is used to move this particular cube platform left and right
        //in an automatic fashion.
        GetComponent<Rigidbody>().AddForce(transform.right * Time.deltaTime * 40);
        yield return new WaitForSecondsRealtime(2);
        GetComponent<Rigidbody>().AddForce(-transform.right * Time.deltaTime * 40);
        
    }
}
