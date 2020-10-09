using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public Text timerText;

    void Start()
    {
        timer = 0.0f;
    }

    void Update()
    {
        timer = Time.timeSinceLevelLoad;
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer % 60F);
        int milliseconds = Mathf.FloorToInt((timer * 100F) % 100F);

        timerText.text = minutes.ToString ("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        //Debug.Log(minutes + " : " + seconds + " : " + milliseconds);
    }
}
