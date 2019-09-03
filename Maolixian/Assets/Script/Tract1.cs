using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tract1 : MonoBehaviour
{
    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            rig.velocity = new Vector2(0,0);
        }
    }
}
