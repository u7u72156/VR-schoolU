// Run in split-screen mode

using System.Collections;
using UnityEngine;
using UnityEngine.VR;

public class VR: MonoBehaviour
{

    private void Start()
    {
        if (VRSettings.loadedDeviceName == "None")
        {
			
            StartCoroutine(LoadDevice("Cardboard"));

        }
    }
    private void Update()
    {
       
      
    }
    public void ToogleVR()
    {       if (VRSettings.loadedDeviceName == "Cardboard")
        {

            StartCoroutine(LoadDevice("None"));

        }
        else
        {
           
            StartCoroutine(LoadDevice("Cardboard"));
            
        }
    }
    IEnumerator LoadDevice(string newDevice)
    {
        VRSettings.LoadDeviceByName(newDevice);
        yield return null;
        VRSettings.enabled = true;
    }
}