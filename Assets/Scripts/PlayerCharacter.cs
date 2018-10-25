using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    public int health;
    public GUIStyle style = new GUIStyle();
    private Transform finishLine1;
    private Transform finishLine2;

    // Use this for initialization
    void Start()
    {
        //checks the PlayerPrefs file (which stores global information)
        //to determine which difficulty option the player has chosen
        //from the options menu. If the player skips the options screen,
        //the player's health is set to 10000, which is the same as the 
        //easy difficulty setting.
        if (PlayerPrefs.HasKey("easyHealth"))
            health = PlayerPrefs.GetInt("easyHealth");
        else if (PlayerPrefs.HasKey("mediumHealth"))
            health = PlayerPrefs.GetInt("mediumHealth");
        else if (PlayerPrefs.HasKey("hardHealth"))
            health = PlayerPrefs.GetInt("hardHealth");
        else
            health = 10000;  //default to easy difficulty

        //clear the PlayerPrefs file so it is clean for the next time
        //the game is run.
        PlayerPrefs.DeleteAll();  
    }

    // Update is called once per frame
    void Update()
    {
        //The player's health gradually decreases each frame.
        //This is done in place of enemy damage since I couldn't get enemy movement
        //working properly.
        health--;  

        //This checks if the player is within a certain distance to the flag pole
        //in each level which is the goal that allows the player to advance to
        //the next level.
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            finishLine1 = GameObject.Find("FlagPole").transform;
            if (Vector3.Distance(GetComponent<Rigidbody>().position, finishLine1.position) <= 3)
                SceneManager.LoadScene("Level2");
        }

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            finishLine2 = GameObject.Find("FlagPole2").transform;
            if (Vector3.Distance(GetComponent<Rigidbody>().position, finishLine2.position) <= 3)
                SceneManager.LoadScene("Level3");
        }
    }

    private void OnGUI()
    {
        //Check if character has lost all their health or fallen to their death. 
        //Kick the game back to the menu if they have.
        if (GetComponent<Rigidbody>().position.y < -20 || health <= 0)
        {
            style.fontSize = 50;

            GUI.Label(new Rect(450, 250, 500, 50), "You have died!", style);
            StartCoroutine(Wait());

        }
    }

    private IEnumerator Wait()
    {
        //put in a 5 second pause between the death message and the menu load
        //to allow the player time to read the death message.
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("Menu");
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int h)
    {
        health = h;
    }
}
