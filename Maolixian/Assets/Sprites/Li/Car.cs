using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 5f;
    public float Force = 60f;
    public BoxCollider2D b2 = null;
    private bool grounded = false;
    //private bool  
    // Start is called before the first frame update
    void Start()
    {
        b2 = GetComponent<BoxCollider2D>();
        GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        ///if(b2=null)
        //{


        //}
        //Transform(transform.position.x*speed);//
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
