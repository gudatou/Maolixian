using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float force = 10.0f;
    private Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rd.AddForce(new Vector3(0, force, 0));
        }
    }

}
