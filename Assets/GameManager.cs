using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public DigitalClock dc;
    public Text date;
    void Update()
    {

        if (dc.hours == 12 && dc.am && dc.minutes == 0)
        {
            if(dc.day< 10)
            {
                date.text = dc.season + "/0" + dc.day;
            }
            else
            {
                date.text = dc.season + "/" + dc.day;
            }
            
        }
    }
    public void UpdateTime()
    {
        if (dc.day < 10)
        {
            date.text = dc.season + "/0" + dc.day;
        }
        else
        {
            date.text = dc.season + "/" + dc.day;
        }
    }
}
