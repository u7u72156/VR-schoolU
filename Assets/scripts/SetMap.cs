using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class SetMap : Loadingscencecontrol
{
    public void Load(GameObject _sender)
    {
        int index = _sender.name.IndexOf("(");

        var str = _sender.name.Substring(index+1, _sender.name.Length - index-1);

        str = str.Substring(0, str.Length - 1);

        PlayerPrefs.SetInt("mapsync", int.Parse(str));
        LoadScreen(2);
    }
}
