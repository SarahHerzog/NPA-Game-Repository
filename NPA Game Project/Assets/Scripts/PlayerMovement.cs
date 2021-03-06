﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public variables
    public float movementForce = 10f;
    public float jumpForce = 1000f;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {

        // Condition: When the player presses a button...
        if (Input.GetKey(KeyCode.D) == true)
        {
            // Action: Apply a force (move the player)

            // Get the Rigidbody component off our player so 
            // we can use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.right * movementForce);
        }

        // Condition: When the player presses A...
        if (Input.GetKey(KeyCode.A) == true)
        {
            // Action: Apply a force (move the player)

            // Get the Rigidbody component off our player so 
            // we can use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.left * movementForce);
        }


        // Condition: When the player first presses space bar
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            // Action: Apply a force (push the player up)
            
            // Get the Rigidbody component off our player so 
            // we can use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.up * jumpForce);

        }



    }
}
