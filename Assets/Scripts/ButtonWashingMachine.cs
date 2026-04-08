using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonWashingMachine : MonoBehaviour
{
    public void LoadScene(string SceneName)
    {
        Debug.Log("Knapptrykket");
        SceneManager.LoadScene(SceneName);
    }
}