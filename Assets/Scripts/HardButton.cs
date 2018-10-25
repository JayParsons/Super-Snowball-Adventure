using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HardButton : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(HardButton_Clicked);
    }

    private void HardButton_Clicked()
    {
        //store health in the PlayerPrefs file
        PlayerPrefs.SetInt("hardHealth", 1000);
        PlayerPrefs.Save();

        //Load the next scene
        Debug.Log("Hard button clicked");
        SceneManager.LoadScene("Level1");
    }
}
