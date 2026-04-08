using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timeElapsed = 0f;
    public bool isRunning = true;

    public Text timerText; // assign in Inspector

    void Update()
    {
        if (isRunning)
        {
            timeElapsed += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Call this when player finishes
    public void StopTimer()
    {
        isRunning = false;
        Debug.Log("Final Time: " + timeElapsed);
    }
}
