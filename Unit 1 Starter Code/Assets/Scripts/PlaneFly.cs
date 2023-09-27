using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFly : MonoBehaviour
{
    private float horizontalInput;
    private float forwardMovement;
    private float upOrDown;
    private float speed = 10f;
    private float turnSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardMovement = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.Translate(Vector3.right * Time.deltaTime * 10 * horizontalInput);
        // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * forwardMovement);
    }
}
