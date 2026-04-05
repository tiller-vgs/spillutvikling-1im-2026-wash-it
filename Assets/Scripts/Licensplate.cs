using UnityEngine;
using UnityEngine.UI;

public class Licensplate : MonoBehaviour
{
    public Text counterText;
    public string Registration;

    public void Update()
    {
        Registration = "AB 123";
        counterText.text = Registration.ToString();
    }
}