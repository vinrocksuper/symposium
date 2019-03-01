using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Timers;

public class DigitalClock : MonoBehaviour
{
    public static Text clockText;
    public Text text;
    public bool showSeconds;
    private static double minutes;
    private static int hours;
    private static DateTime time;
    private static bool am;
    private static System.Timers.Timer aTimer;
    private void Start()
    {
        hours = 6;
        minutes = 0;
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
        text.text = hours + ":" + minutes;
    }
}
    




   /** private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
       
        
}

    private void FixedUpdate()
    {
        if (DateTime.Now > time)
        {
            time = DateTime.Now;
            minutes+= 1/60;
            if (minutes > 60)
            {
                minutes = 0;
                hours++;
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
            UpdateText();
        }
    }
    private void UpdateText()
    {
        
    }


}**/
    