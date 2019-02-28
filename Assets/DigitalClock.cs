using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class DigitalClock : MonoBehaviour
{
    public Text clockText;
    public bool showSeconds;
    private int hours;
    private int minutes;
    private DateTime time;
    private bool am;
    // Use this for initialization
    /**
    void Start()
    {
        seconds = -1;
        minutes = -1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time = DateTime.Now;
        if (showSeconds)
        {
            if (seconds != time.Second)
            {
                UpdateText();
                seconds = time.Second;
            }
        }
        else
        {
            if (minutes != time.Minute)
            {
                UpdateText();
                minutes = time.Minute;
            }
        }
    }
    void UpdateText()
    {
        clockText.text = time.Hour.ToString("D2") + ":" + time.Minute.ToString("D2");
        if (showSeconds)
        {
            clockText.text += ":" + time.Second.ToString("D2");
        }
    }**/
    private void Start()
    {
        hours = 6;
        minutes = 0;
        am = true;
    }
    private void FixedUpdate()
    {
        if(DateTime.Now > time)
        {
            time = DateTime.Now;
            minutes++;
            if(minutes > 60)
            {
                minutes = 0;
                hours++;
                if(hours > 12)
                {
                    hours = 1;
                    if(am)
                    {
                        am = false;
                    }
                    else
                    {
                        am = true;
                    }
                }
            }
            UpdateText();
        }
    }
    private void UpdateText()
    {
        clockText.text = hours + ":" + minutes;
    }
}