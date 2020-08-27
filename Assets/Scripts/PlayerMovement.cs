﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;



    



    


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //좌우 
        animator.SetFloat("xSpeed", Mathf.Abs(horizontalMove));






       

        

    }


    
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        
    }

    
}