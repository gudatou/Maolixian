﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR : MonoBehaviour
{
    public float Speed = 0;
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
        if (Cat.transform.position.y - Car.transform.position.y < 1.5)
        {
            forword = true;
        }
        if(forword == true)
        {
            Speed = 5f;
        }

    }
    void Update()
    {
        transform.Translate(new Vector3(Speed, 0, 0) * Time.deltaTime);
            //Car.transform.position += Vector3.left * Time.deltaTime;
        
    }
    //private void FixedUpdate()
    //{
    //    if(Cat.transform.position.y-Car.transform.position.y<1.5)
    //    {
    //        forword = true;
    //    }
       
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
