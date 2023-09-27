using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private float horizontal;
    private float speed = 60f;
    private int boundary = 70;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        // this will move our ship left / right based on user input 
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontal * speed);

        // limit shipto not come out of camera view
        if(transform.position.x < -boundary)
        {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        if(transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
        // this will create a projectile each time the spacebar is pressed 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 offset = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
            Instantiate(projectilePrefab, offset, transform.rotation);
        }

    }

    //this will destroy the ship and meteor when they collide 
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        // display a game over 
        Debug.Log("Game Over!");
    }
}
