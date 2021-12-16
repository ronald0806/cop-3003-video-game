using UnityEngine;

// LO1. Design and implement a class. 
public class Movement : MonoBehaviour
{

    // Enables control over specific given character
    public CharacterController2D controller;

    //LO6. Use object-oriented encapsulation mechanisms such as interfaces and private members.
    // Animator: Sprite animations linked to character
    private Animator animator;

    public float movementSpeed = 0f;

    float horizontalMove = 15f;

    // Jump input set to false as the character is moving
    bool jump = false;
    void Update()
    {
        // LO7. Define and use iterators and other operations on aggregates, including operations that take functions as arguments. 
        // Takes input from left and right arrow keys if they are pressed
        // Input.GetAxisRaw: Returns the value of the virtual axis identified by axisName with no smoothing filtering applied
        horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;

        // Takes input from spacebar key if it's pressed
        // GetButtonDown: Returns true during the frame the user pressed down the virtual button identified by buttonName
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        SetAnimation();
    }


    private void FixedUpdate()
    {
        // Different executions of character's movement (walking and jumping)
        // LO1b. Overload a constructor
        // controller.Move: Supplies the movement of a GameObject with an attached CharacterController component
        // Time.fixedDeltaTime: The interval in seconds at which physics and other fixed frame rate updates (like MonoBehaviour's FixedUpdate) are performed
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


    private void Awake()
    {
        // Takes the animator window component from Unity 
        animator = GetComponent<Animator>();
        // PlayerPrefs.DeleteAll: Removes all keys and values from the preferences. Use with caution
        PlayerPrefs.DeleteAll();

    }

    private void SetAnimation()
    {
        // If the character is moving, then the running sprite animation will execute
        // Mathf.Abs: Returns the absolute value of f
        if (Mathf.Abs(horizontalMove) > 0)
        {

            // animator.SetBool: Sets the value of the given boolean parameter
            animator.SetBool("IsRunning", true);
        }
        // If the character is not moving, then the running sprite animation will not execute
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }
}

// Quality and Security: https://www.sonarsource.com/csharp/