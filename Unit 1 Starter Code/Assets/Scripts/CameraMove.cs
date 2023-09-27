using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject car;
    private Vector3 offset = new Vector3(0, 5, -12);

    // Update is called once per frame
    void LateUpdate()
    {
        // this will allow my camera to follow my car at some offset value 
        transform.position = car.transform.position + offset;
    }
}
