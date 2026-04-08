using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoard:MonoBehaviour
{
    public TMP_InputField CharHolder;
    //public Licensplate class
    public void AddChar(string c)
    {
        CharHolder.text += c;
    }
    public void Clearevent()
    {
        CharHolder.text = "";
    }
    public void Enterevent()
    {
        if (CharHolder.text == Licensplate.Registration)
        {
            Debug.Log("Success");
            CharHolder.text = "";
        }
        else
        {
            Debug.Log("Failed");
        }
    }
}
