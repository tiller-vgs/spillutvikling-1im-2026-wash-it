using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoard:MonoBehaviour
{
    public TMP_InputField CharHolder;
    public string password = "1234";
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
        if (CharHolder.text == password)
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
