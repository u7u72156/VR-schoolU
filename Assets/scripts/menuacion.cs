using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuacion : MonoBehaviour {

    // Use this for initialization
    Appscence gameManager;
    void Awake()
    {
        gameManager = FindObjectOfType<Appscence>();
    }
    public void MENU_ACTION_GotoPage(string sceneName) {
         

    SceneManager.LoadScene(sceneName);

    
}


    public void exitbt()
    {


        Application.Quit();

    }

}


