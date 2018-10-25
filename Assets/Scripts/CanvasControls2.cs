using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControls2 : MonoBehaviour {

    public GUIStyle style = new GUIStyle();

    // Use this for initialization
    void Start()
    {
        //iterate through all of the child objects of my caption
        //game object to make them all inactive
        gameObject.SetActive(true);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            gameObject.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        }

        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        //used to display the player's health
        style.fontSize = 26;
        style.fontStyle = FontStyle.BoldAndItalic;

        GameObject sm = GameObject.Find("Snowman2");
        PlayerCharacter smGT;
        smGT = sm.GetComponent<PlayerCharacter>();

        if (smGT.GetHealth() > 0)
            GUI.Label(new Rect(100, 0, 500, 50), smGT.GetHealth().ToString(), style);
        else
            GUI.Label(new Rect(100, 0, 500, 50), "0", style);

        Debug.Log(smGT.GetHealth().ToString());
    }

    private IEnumerator Wait()
    {
        //display all of the text stored as child objects of my caption
        //game object in a staggered fashion.
        for (int i = 0; i < 3; i++)
        {
            gameObject.transform.GetChild(0).GetChild(i).gameObject.SetActive(true);
            yield return new WaitForSecondsRealtime(5);
            gameObject.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        }

        //make the caption dissapear once all text is displayed
        GameObject sm = GameObject.Find("MessageCaption2");
        Destroy(sm);
    }
}
