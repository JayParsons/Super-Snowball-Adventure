using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //create onclick listener for the options button on the main menu
        GetComponent<Button>().onClick.AddListener(OptionsButton_Clicked);
    }

    private void OptionsButton_Clicked()
    {
        Debug.Log("Options button clicked");
        SceneManager.LoadScene("OptionsMenu");
    }
}
