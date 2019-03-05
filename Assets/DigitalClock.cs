using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Timers;

public class DigitalClock : MonoBehaviour
{
    public static Text clockText;
    public Text clock;
    public Text date;
    private static double minutes;
    private static int hours;
    private static DateTime time;
    private bool am;
    private static System.Timers.Timer aTimer;
    private int season;
    private int day;
    private bool dayPassed = false;
    private void Start()
    {
        hours = 11;
        minutes = 50;
        season = 1;
        day = 1;
        am = false;
        SetTimer();
    }

    private void SetTimer()
    {
        aTimer = new System.Timers.Timer(100);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private void OnTimedEvent(System.Object source, ElapsedEventArgs e)
    {
            minutes++;
            if (minutes > 59)
            {
                minutes = 0;
                hours++;
            }
            if(hours == 12 && minutes == 0 && !dayPassed)
            {
                if(am)
                {
                    am = false;
                }
                else
                {
                    am = true;
                }
            }
            if(hours > 12)
            {
                hours = 1;
            }
            if (hours == 12 && minutes == 0 && !am && !dayPassed)
            {
                dayPassed = true;
                am = true;
                day++;
                if (day > 28)
                {
                    day = 1;
                    season++;
                    if (season > 4)
                    {
                        season = 1;
                    }
                }
        }     
    }

    private void FixedUpdate()
    {
        /**
        if (hours < 10)
        {
            if (minutes < 10)
            {
                if (am)
                {
                    clock.text = "0" + hours + ":0" + minutes + "am";
                }
                else
                {
                    clock.text = "0" + hours + ":0" + minutes + "pm";
                }

            }
        }
        else if (minutes < 10)
        {
            {
                if (am)
                {
                    clock.text = hours + ":0" + minutes + "am";
                }
                else
                {
                    clock.text = hours + ":0" + minutes + "pm";
                }

            }
        }
        else  **/
        if (am)
        {
            clock.text = hours + ":" + minutes + "am";
        }
        else
        {
            clock.text = hours + ":" + minutes + "pm";
        }
        if (day < 10)
        {
            date.text = "0" + season + "/0" + day;
            dayPassed = false;
        }
        else
        {
            date.text = "0" + season + "/" + day;
            dayPassed = false;
        }
    }
}

