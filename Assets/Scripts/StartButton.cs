using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //create onclick listener for the start button on the main menu
        GetComponent<Button>().onClick.AddListener(StartButton_Clicked);
	}
	
    private void StartButton_Clicked()
    {
        Debug.Log("Start button clicked");
        SceneManager.LoadScene("Level1");
    }
}
