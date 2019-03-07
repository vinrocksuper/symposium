using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterObject : MonoBehaviour
{
    public bool inventory; //if true can be stored in inventory
    public bool farmable; //true if farmable

    public void DoInter()
    {
        //Make item disappear
        gameObject.SetActive(false);

    }


}
