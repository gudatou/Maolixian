using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float force = 50.0f;
    private Rigidbody2D rd;
    //public Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {

        rd = this.GetComponent<Rigidbody2D>();
        //di = GameObject.FindGameObjectsWithTag("Che");
        //dir = di.position.y - transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rd.AddForce(new Vector3(0, force, 0));
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        
    //}

}
