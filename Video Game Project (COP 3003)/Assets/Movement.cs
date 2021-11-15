using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 1;
    
    
    private void Start()
    {
      
    }

    // Update is called once per frame
    private void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * movementSpeed;
    }

        void Jump()
        {
            if (Input.GetButtonDown("Jump"))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            }


        }
    }

