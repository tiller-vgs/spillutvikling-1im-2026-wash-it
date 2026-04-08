using NUnit.Framework;
using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Licensplate : MonoBehaviour
{
    public Text counterText;
    public string Registration;
    public string[] Letters= {"A", "B", "C", "D", "E", "F", "G", "H"};
    public int Numbers;

    public void Start()
    {
        Numbers = RandomNumberGenerator.GetInt32(100, 999);
        Registration = Letters[RandomNumberGenerator.GetInt32(0, 8)] + Letters[RandomNumberGenerator.GetInt32(0, 8)] + " " + (Numbers);
    }
    public void Update()
    {
        counterText.text = Registration.ToString();
    }
}