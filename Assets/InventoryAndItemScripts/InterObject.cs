using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterObject : MonoBehaviour
{
    public bool inventory; //if true can be stored in inventory
    public bool farmable; //true if farmable
    public DigitalClock dc;
    public GameManager gm;
    public void DoInter()
    {
        //Make item disappear
        if (inventory)
        {
            gameObject.SetActive(false);
        }
        else if (farmable)
        {

        }
        else
        {
            dc.restart();
            gm.UpdateTime();
        }
    }


}
