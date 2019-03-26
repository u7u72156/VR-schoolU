using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Newclasstest
{
    public class ob : MonoBehaviour
    {

        // Use this for initialization

        public static int a = 1;
        public static int en_a=0;

       
        public GameObject[] Chtext;
        public GameObject[] Entext;
        void Start()
        {

            if (a == 1)
            {
                for (int i = 0; i < Chtext.Length; i++)
                    if (Chtext[i] != null) Chtext[i].SetActive(true);
            }
            else if(a == 0 )
            {
                for (int i = 0; i < Chtext.Length; i++)
                    if (Chtext[i] != null) Chtext[i].SetActive(false);
            }


            if (en_a == 1)
            {
                for (int i = 0; i < Entext.Length; i++)
                    if (Entext[i] != null) Entext[i].SetActive(true);

            }
            else if (en_a == 0)
            {
                for (int i = 0; i < Entext.Length; i++)
                    if (Entext[i] != null) Entext[i].SetActive(false);

            }

        }



        // Update is called once per frame
        void Update()
        {



        }


    }
}



