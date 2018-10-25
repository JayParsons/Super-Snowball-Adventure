using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EasyButton : MonoBehaviour {

    public static int health = 10000;

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(EasyButton_Clicked);
        
    }

    private void EasyButton_Clicked()
    {
        //store health in the PlayerPrefs file
        PlayerPrefs.SetInt("easyHealth", 10000);
        PlayerPrefs.Save();

        //Load the next scene
        Debug.Log("Easy button clicked");
        SceneManager.LoadScene("Level1");
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);  //keep game object alive for next scene
    }

    public int GetHealth()
    {
        return health;  //allows other scripts to get player's health
    }
}
