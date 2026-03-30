using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoard : MonoBehaviour
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
        bool correct = CharHolder.text == password;
        Debug.Log(correct ? "Success" : "Failed");
        Clearevent();
    }
}