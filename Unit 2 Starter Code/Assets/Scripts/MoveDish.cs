using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDish : MonoBehaviour
{
    private float speed = 50f;
    private int outOfBounds = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x < outOfBounds)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log("You Earned A Point");
    }
}
