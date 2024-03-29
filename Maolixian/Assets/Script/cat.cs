﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float force = 20.0f;
    private Rigidbody2D rd;
    private PolygonCollider2D co;
    private BoxCollider2D box;
    public float JumpHeight = 1.0f;
    private float MaxJumpHeight;
    //public Vector3 dir;
    private bool isDead = false;
    //private bool isJump = false;
    private bool grounded = false;
    private Transform tran;
    private float CurrentHeight;
    public bool canJump = false;
    private bool JetActive = false;


    public LayerMask TheGround;
    // Start is called before the first frame update
    public int Count = 0;
    public AudioClip pick_gem;
    private Animator anim = null;

    private Transform groundCheckPoint = null;

    void Start()
    {
        box = this.GetComponentInChildren<BoxCollider2D>();
        rd = this.GetComponent<Rigidbody2D>();
        co = this.GetComponent<PolygonCollider2D>();
        anim = GetComponent<Animator>();
        groundCheckPoint = transform.Find("GroundCheckPoint");
        //di = GameObject.FindGameObjectsWithTag("Che");
        //dir = di.position.y - transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        JetActive = Input.GetButton("Fire1");
        MaxJumpHeight = CurrentHeight + 2.0f;
     }

    private void FixedUpdate()
    {
        if (transform.position.y >= MaxJumpHeight)
        {
            canJump = false;
            //isJump = true;
        }
        if (grounded == true)
        {
            canJump = true ;
        }


         if (JetActive && canJump)
         {
             rd.AddForce(new Vector2(0, force));
             //isJump = true;
             anim.SetBool("grounded",false);
         }
         else
        {
            anim.SetBool("Grounded", grounded);
        }
        GroundStateCheck();
        // if(isJump == true)
        //{
        //    anim.SetBool("ground",isgrounded);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            CurrentHeight = transform.position.y;

            canJump = true;
            grounded = true;
            anim.SetBool("Grounded", grounded);
        }
        if (collision.gameObject.CompareTag("hinge"))
        {
            canJump = true;
            grounded = true;
            anim.SetBool("Grounded", grounded);
        }
    }



    private void GroundStateCheck()
    {
        grounded = Physics2D.OverlapCircle(groundCheckPoint.position, 0.1f, TheGround);
        //jetPack.emission.enabled = false;
        anim.SetBool("Grounded", grounded);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
       


        if(collision.gameObject.CompareTag("missile"))
        {
            Debug.Log("1");
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            canJump = false;
            Destroy(co);
            force = 0.0f;
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("bat"))
        {
            Debug.Log("ADASDSAD");
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            canJump = false;
            Destroy(co);
            force = 0.0f;
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("frame"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            canJump = false;
            Destroy(co);
            force = 0.0f;
            //Destroy(rd);
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("ball"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            canJump = false;
            Destroy(co);
            force = 0.0f;
            //Time.timeScale = 0;
        }
        //if (collision.gameObject.CompareTag("Death level"))
        //{

        //}
        //if (collision.gameObject.CompareTag("ball"))
        //{

        //}


    }
}
