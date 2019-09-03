using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cat;
    private float distanceX;
    // Use this for initialization
    void Start()
    {
        distanceX = transform.position.x - cat.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            cat.position.x + distanceX,
            transform.position.y,
            transform.position.z);
    }
}
