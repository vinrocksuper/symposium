using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontal = 0f;
    bool jump = false;
    public float speed = 400f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jump = false;
        horizontal = Input.GetAxisRaw("Horizontal") * speed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            Debug.Log("space was pressed");
        }
    }

    //Move character
    void FixedUpdate()
    {
        controller.Move(horizontal*Time.fixedDeltaTime,false,jump);
    }
}
