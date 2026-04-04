using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float StartTime;
    public Text timer;

    void Update()
    {
        StartTime -= Time.deltaTime * 1;
        int seconds = (int)(StartTime % 60);
        int minutes = (int)(StartTime / 60) % 60;
        int hours = (int)(StartTime / 3600) % 24;
        string timerstr = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

        timer.text = timerstr;
    }
}
