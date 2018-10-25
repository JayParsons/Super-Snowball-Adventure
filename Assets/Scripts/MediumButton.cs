using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MediumButton : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(MediumButton_Clicked);
    }

    private void MediumButton_Clicked()
    {
        //store health in the PlayerPrefs file
        PlayerPrefs.SetInt("mediumHealth", 5000);
        PlayerPrefs.Save();

        //Load the next scene
        Debug.Log("Medium button clicked");
        SceneManager.LoadScene("Level1");
    }
}
