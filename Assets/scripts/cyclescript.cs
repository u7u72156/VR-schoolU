using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclescript : MonoBehaviour {
   
    // Use this for initialization
    void Start()
    {

    }
    public void Changecycle(GameObject nextcycle) {

        StartCoroutine(Recycle(nextcycle));


    }
    IEnumerator Recycle(GameObject nextcycle) {
        for (float i = 0; i <= 1f; i += Time.deltaTime)
        {

            Debug.Log(i + "second");
            yield return 0;


        }
        nextcycle.SetActive(false);
        {
        }
    }


}
	
	// Update is called once per frame


