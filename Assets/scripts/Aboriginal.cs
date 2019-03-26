using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aboriginal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void ChangeaAbo(GameObject nextabo)
    {

        StartCoroutine(Reaabor(nextabo));


    }
    IEnumerator Reaabor(GameObject nextabo)
    {

        for (float i = 0; i <= 2f; i += Time.deltaTime)
        {

            Debug.Log(i + "second");
            yield return 0;


        }
        nextabo.SetActive(true);
        {
        }
    }

}
