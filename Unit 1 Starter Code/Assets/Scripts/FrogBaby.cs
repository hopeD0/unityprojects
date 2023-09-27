using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogBaby : MonoBehaviour
{
    private float horizontalInput;
    private float forwardMovement;
    private float speed = 20f;
    private float turnSpeed = 40f;

 
    // Update is called once per frame
    void Update()
    {
        // This gets the user input, left, right, forward, and back
        horizontalInput = Input.GetAxis("Horizontal");
        forwardMovement = Input.GetAxis("Vertical");

        // this line will move my car forward and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardMovement);

        //this will rotate my car left and right 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // transform.Translate(Vector3.right * Time.deltaTime * 10 * horizontalInput);
    }
}
