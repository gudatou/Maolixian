using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR : MonoBehaviour
{
    public float Speed = 1.0f;
    private Rigidbody2D rig = null;
    public bool forword = false;
    public GameObject Car;
    public GameObject Cat;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Transform Car = transform.Find("chezhengxiang");
        GameObject[] Cat = GameObject.FindGameObjectsWithTag("Black Cat");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        

    }
    void Update()
    {
        //if (Cat.transform.position.y - Car.transform.position.y < -1.5)
        //{
        //    transform.Translate(new Vector3(Speed, 0, 0) * Time.deltaTime);
        //}
        //transform.Translate(new Vector3(Speed, 0, 0) * Time.deltaTime);
        //Car.transform.position += Vector3.left * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        if(collision.gameObject.CompareTag("Black Cat"))
           {
            transform.Translate(new Vector3(Speed, 0, 0));
        }
        //if (Cat.transform.position.y - Car.transform.position.y < -1.5)
        //{
        //    forword = true;
        //}

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //if (forword == true)
        //{
        //    Speed = 5f;
        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

}
