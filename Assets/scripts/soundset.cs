using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Newclasstest
{
    public class soundset : MonoBehaviour
    {
        public static int a = 1;
        public static int en_a = 0;
        public GameObject[] chsound;
        public GameObject[] ensound;
        // Use this for initialization
        void Start()
        {
            if (a == 1)
            {
                for (int i = 0; i < chsound.Length; i++)
                 if (chsound[i]!=null)  chsound[i].SetActive(true);
            }
            else if( a == 0)
            {
                for (int i = 0; i < chsound.Length; i++)
                    if (chsound[i] != null) chsound[i].SetActive(false);
            }

            if (en_a == 1)
            {
                for (int i = 0; i < ensound.Length; i++)
                    if (ensound[i] != null) ensound[i].SetActive(true);
            }   
            else if (en_a == 0)
            {
                for (int i = 0; i < ensound.Length; i++)
                    if (ensound[i] != null)  ensound[i].SetActive(false);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
