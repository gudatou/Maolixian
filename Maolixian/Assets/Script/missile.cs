using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0F;
    public bool reverse = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate = new Vector3(xPosition, 0, 0);
        transform.Translate(Vector3.left * Time.deltaTime * speed );
        if (reverse == false)
        {
            gameObject.transform.rotation =  Quaternion.Euler(new Vector3(0, 180, 0));
            transform.Translate(Vector3.left * Time.deltaTime * -speed, Space.World);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Black Cat"))
        {
            Debug.Log("1");
        }
    }
}
