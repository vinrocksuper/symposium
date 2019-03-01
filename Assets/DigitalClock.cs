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
    private static bool am;
    private static System.Timers.Timer aTimer;
    private int season;
    private int day;
 
    private void Start()
    {
        hours = 6;
        minutes = 0;
        season = 1;
        day = 1;
        am = true;
        SetTimer();
    }

    private void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
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
            if (hours > 12)
            {
                hours = 1;
                if (am)
                {
                    am = false;
                }
                else
                {
                    am = true;
                }
            }     
    }

    private void FixedUpdate()
    {
        if (minutes < 10)
        {
            clock.text = hours + ":0" + minutes;
        }
        else
        {
            clock.text = hours + ":" + minutes;
        }
    }
}