using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float MovementSpeed = 1;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

        // Left and Right arrow Keys
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}
