using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chufaqi : MonoBehaviour
{
    private Rigidbody2D rid;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("car");
        rid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            Destroy(collision.GetComponent<BoxCollider2D>());
            Destroy(collision.GetComponent<Rigidbody2D>());
        }
    }
}
