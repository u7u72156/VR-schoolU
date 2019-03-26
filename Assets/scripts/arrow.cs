using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {
   
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public void Changearrow(GameObject nextarrow)
    {

        StartCoroutine(Rearrow(nextarrow));


    }
    IEnumerator Rearrow(GameObject nextarrow) {

        for (float i = 0; i <= 1f; i += Time.deltaTime)
        {

            Debug.Log(i + "second");
            yield return 0;


        }
        nextarrow.SetActive(true);
        {
        }
    }

}

