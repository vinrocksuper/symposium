using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInter : MonoBehaviour
{

    public GameObject curInterObj = null;

    private void Update()
    {
        if(Input.GetButtonDown("Interact") && curInterObj)
        {
            //Does something with the object
            curInterObj.SendMessage("DoInter");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            Debug.Log(other.name);
            curInterObj = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("interObject"))
        {
            if(other.gameObject == curInterObj)
            {
                curInterObj = null;
            }
        }
    }
}
