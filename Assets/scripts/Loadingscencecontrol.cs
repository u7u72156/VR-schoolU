﻿using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadingscencecontrol : MonoBehaviour {

    public GameObject loadingScreenObj;
    public Slider slider;
    AsyncOperation async;

    // Use this for initialization

 
    public void LoadScreen(int lvl) {

        StartCoroutine(LoadingScreen(lvl));

    }
    IEnumerator LoadingScreen(int lvl) {
        loadingScreenObj.SetActive(true);
        async = SceneManager.LoadSceneAsync(lvl);
        async.allowSceneActivation = false;


        while (async.isDone == false)
        {
            slider.value = async.progress;
            if (async.progress ==0.9f)
            {
                slider.value = 1f;
                async.allowSceneActivation = true;
        }

            yield return null;

        }
      
    }

}
