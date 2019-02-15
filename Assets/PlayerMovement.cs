using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontal = 0f;
    public float speed = 400f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * speed;
    }

    //Move character
    void FixedUpdate()
    {
        controller.Move(horizontal*Time.fixedDeltaTime,false,false);
    }
}
