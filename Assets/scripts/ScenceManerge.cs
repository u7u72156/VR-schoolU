using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
namespace Newclasstest
{
    public class ScenceManerge : MonoBehaviour
    {
        public static int Sc_chtext = 1;
        public static int Sc_chsound = 1;
        public static int Sc_entext = 1;
        public static int Sc_ensound = 1;
        public static int chview = 1;



        // Use this for initialization
        void Awake()
        {
        
            StartCoroutine(LoadDevice("Cardboard"));
        }

        // Update is called once per frame
        void Update()
        {
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
}