using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public float totalTime;
    int seconds;

    // Use this for initialization
    void Start()
    {

    }
    public void TimeCountTextshow(float _time)
    {
        totalTime = _time;
        seconds = (int)totalTime;

        timerText.text = seconds.ToString();
        if (totalTime <= 1)

        {
            timerText.text = "GAME OVER";
        }
    }


}
