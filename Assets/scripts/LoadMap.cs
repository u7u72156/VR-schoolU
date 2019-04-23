using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMap : MonoBehaviour {

   // Use this for initialization
    void Start () {
        var list = new List<GameObject>();
        //string str = "Sphere " + (PlayerPrefs.GetInt("mapsync")+1).ToString();

        for (int i = 1; i < 55; i++)
        {
            try
            {
                var g = GameObject.Find("Sphere " + i.ToString());
                if (g!=null)
                list.Add(g);
            }
            catch (Exception)
            {
                //ing
            }


        }

        foreach (var item in list)
        {
            item.SetActive(false);
        }
        int p = PlayerPrefs.GetInt("mapsync");

        //if (p==0) p=

        list[p].SetActive(true);
        //.SetActive(true);
    }

        // Update is called once per frame

}
