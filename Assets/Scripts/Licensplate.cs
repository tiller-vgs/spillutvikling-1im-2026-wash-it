using UnityEngine;
using UnityEngine.UI;

public class Licensplate : MonoBehaviour
{
    public Text counterText;
    public static string Registration;

    public void Update()
    {
        Registration = "AB 123";
        counterText.text = Registration.ToString();
    }
}