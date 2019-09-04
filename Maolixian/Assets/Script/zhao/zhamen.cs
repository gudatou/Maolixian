using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class zhamen : MonoBehaviour
{
    public int a = 0;
    public Sprite red;
    public Sprite green;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            GetComponent<SpriteRenderer>().sprite = green;
            a = 1;
        }
    }
}