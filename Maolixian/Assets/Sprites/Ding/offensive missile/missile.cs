using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rig;
    public float speed = 5.0f;

    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.AddForce(new Vector3(speed, 0,0));
    }
}
