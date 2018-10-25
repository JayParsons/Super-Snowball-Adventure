using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour {
    private bool clicked = false;

	// Use this for initialization
	void Start () {
        //create onclick listener for the options button on the main menu
        GetComponent<Button>().onClick.AddListener(QuitButton_Clicked);
    }

    private void Update()
    {
        Debug.Log(clicked);

        //Quits the game. This only works if the game is built and run!
        //It will not work if using the play button within the unity editor!
        if (clicked == true)
            Application.Quit();
    }

    private void QuitButton_Clicked()
    {
        Debug.Log("Quit button clicked");
        clicked = true;
    }
}
