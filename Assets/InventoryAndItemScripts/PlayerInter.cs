using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInter : MonoBehaviour
{

    public GameObject curInterObj = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject") && Input.GetButtonUp("Interact"))
        {
            Debug.Log(other.name);
            curInterObj = other.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("interObject") && Input.GetButtonUp("Interact"))
        {
            Debug.Log(other.name);
            curInterObj = other.gameObject;
        }
    }
}
