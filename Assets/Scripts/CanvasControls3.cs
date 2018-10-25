using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasControls3 : MonoBehaviour {

    public GUIStyle style = new GUIStyle();

    // Use this for initialization
    void Start()
    {
        //iterate through all of the child objects of my caption
        //game object to make them all inactive
        gameObject.SetActive(true);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        for (int i = 0; i < 1; i++)
        {
            gameObject.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        }

        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Wait()
    {
        //display all of the text stored as child objects of my caption
        //game object in a staggered fashion.
        for (int i = 0; i < 1; i++)
        {
            gameObject.transform.GetChild(0).GetChild(i).gameObject.SetActive(true);
            yield return new WaitForSecondsRealtime(5);
            gameObject.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        }

        //make the caption dissapear once all text is displayed and load
        //the next scene
        GameObject sm = GameObject.Find("MessageCaption3");
        Destroy(sm);
        SceneManager.LoadScene("Menu");
    }
}
