using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
namespace Newclasstest
{
    public class VRviewmanager : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

            StartCoroutine(LoadDevice("None"));
        }

        // Update is called once per frame
        void Update()
        {
           
        }
        IEnumerator LoadDevice(string newDevice)
        {
            VRSettings.LoadDeviceByName(newDevice);
            yield return null;
            VRSettings.enabled = true;
        }
    }
}