using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cat;
    private float distanceX;
    private float distanceY;
    // Use this for initialization
    void Start()
    {
        distanceX = transform.position.x - cat.position.x;

        distanceY = transform.position.y - cat.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(
            cat.position.x + distanceX,
            cat.position.y +distanceY,
            transform.position.z);
    }
}
