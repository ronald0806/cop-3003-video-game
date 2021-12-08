using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Movement : MonoBehaviour {

    // Enables control over specific given character
    public CharacterController2D controller;
    
    // Sprite animations linked to character
    private Animator animator;

    float horizontalMove = 40f;

    public float movementSpeed = 0f;
    
    // Jump input set to false as the character is moving
    bool jump = false;
    void Update()
    {
        // Takes input from left and right arrow keys if they are pressed
        horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;

        // Takes input from spacebar key if it's pressed
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        SetAnimation();
    }


    private void FixedUpdate()
    {
        // Different executions of character's movement (walking and jumping) 
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


    private void Awake()
    {
        // Takes the animator window component from Unity 
        animator = GetComponent<Animator>();

    }

    private void SetAnimation()
    {
        // If the character is moving, then the running sprite animation will execute
        if(Mathf.Abs(horizontalMove) > 0)
            {
            animator.SetBool("IsRunning", true);
        }
        // If the character is not moving, then the running sprite animation will not execute
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }
}