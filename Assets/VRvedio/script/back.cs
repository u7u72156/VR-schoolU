using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class back : MonoBehaviour {



	void Awake()
	{

		StartCoroutine(LoadDevice("Cardboard"));
	   
	}

	// Update is called once per frame
	void Update () {
		if (VRSettings.loadedDeviceName == "None")
		{

			StartCoroutine(LoadDevice("Cardboard"));

		}
        if (Input.GetKeyDown(KeyCode.Escape))
        {



            StartCoroutine(LoadDevice("None"));
            Application.LoadLevel("VR-view");

        }

    }
    IEnumerator LoadDevice(string newDevice)
    {
        VRSettings.LoadDeviceByName(newDevice);
        yield return null;
        VRSettings.enabled = true;
    }
}
