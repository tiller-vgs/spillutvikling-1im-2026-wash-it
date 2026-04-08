using NUnit.Framework;
using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Licensplate : MonoBehaviour
{
    public Text counterText;
    public static string Registration;

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