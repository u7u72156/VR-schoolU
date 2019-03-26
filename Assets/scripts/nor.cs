using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Newclasstest
{
    public class nor : MonoBehaviour
    {
        


       
        public GameObject ChtextBt_On;
        public GameObject ChtextBt_Off;
        public GameObject Chsoundgameob;
        public GameObject ChsoundBt_On;
        public GameObject ChsoundBt_Off;
        public GameObject EntextBt_On;
        public GameObject EntextBt_Off;
        public GameObject Ensoundgameob;
        public GameObject EnsoundBt_On;
        public GameObject EnsoundBt_Off;

        public GameObject Chview;
        public GameObject Enview;
        public GameObject Chbt;
        public GameObject Enbt;
        // Use this for initialization
        void Start()
        { 
            if (ScenceManerge.Sc_chtext == 1)
            {
                ChtextBt_On.active = true;
                ChtextBt_Off.active = false;
                if (ScenceManerge.Sc_chsound == 1)
                {
                    ChsoundBt_On.active = true;
                    ChsoundBt_Off.active = false;
                }
                else if (ScenceManerge.Sc_chsound == 0)
                {
                    ChsoundBt_On.active = false;
                    ChsoundBt_Off.active = true;
                }

            }
            else if (ScenceManerge.Sc_entext == 0)
            {
                EntextBt_On.active = false;
                EntextBt_Off.active = true;
                Ensoundgameob.active = false;
            }
            if (ScenceManerge.Sc_entext == 1)
            {
                EntextBt_On.active = true;
                EntextBt_Off.active = false;
                if (ScenceManerge.Sc_ensound == 1)
                {
                    EnsoundBt_On.active = true;
                    EnsoundBt_Off.active = false;
                }
                else if (ScenceManerge.Sc_ensound == 0)
                {
                    EnsoundBt_On.active = false;
                    EnsoundBt_Off.active = true;
                }

            }
            else if (ScenceManerge.Sc_entext == 0)
            {
                EntextBt_On.active = false;
                EntextBt_Off.active = true;
                Ensoundgameob.active = false;
            }

            if (ScenceManerge.chview == 1)
            {

                Chview.active = true;
                Chbt.active = true;
                Enview.active = false;
                Enbt.active = false;
            }
            else if (ScenceManerge.chview == 0) {

                Chview.active = false;
                Chbt.active = false;
                Enview.active = true;
                Enbt.active = true;
            }

        }

        // Update is called once per frame
        void Update()
        {
           

        

        }
        
        public void chtexton() {

            ob.a = 1;
            ob.en_a = 0;
            ScenceManerge.Sc_chtext = 1;
        }
        public void chtextoff() {
            ob.a = 0;
            ob.en_a = 0;
            ScenceManerge.Sc_chtext = 0;
           
        }
        public void chsoundon()
        {

            soundset.a = 1;
            soundset.en_a = 0;
            ScenceManerge.Sc_chsound = 1;
        }
        public void chsoundoff()
        {
            soundset.a = 0;
            soundset.en_a = 0;
            ScenceManerge.Sc_chsound = 0;
        }
        public void entexton()
        {
            ob.en_a = 1;
            ob.a = 0;
            ScenceManerge.Sc_entext = 1;
        }

        public void entextoff()
        {
            ob.en_a = 0;
            ob.a = 0;
            ScenceManerge.Sc_entext = 0;
        }
        public void ensoundon()
        {
            soundset.en_a = 1;
            soundset.a = 0;
            ScenceManerge.Sc_ensound = 1;
        }
        public void ensoundoff()
        {
            soundset.en_a = 0;
            soundset.a = 0;
            ScenceManerge.Sc_ensound = 0;
        }

        public void chtextsoundon() {

            ob.a = 1;
            soundset.a = 1;
            ob.en_a = 0;
            soundset.en_a = 0;
            ScenceManerge.chview = 1;
        }
        public void entextsoundon()
        {

            ob.a = 0;
            soundset.a = 0;
            ob.en_a = 1;
            soundset.en_a = 1;
            ScenceManerge.chview = 0;
        }
    }
}
