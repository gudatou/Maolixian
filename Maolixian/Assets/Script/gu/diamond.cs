﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DD;
    public int Count = 0;
    public AudioClip pick_gem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

       Vector2 diamond = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        Instantiate(DD, diamond, Quaternion.identity);
       DD.SetActive(true);
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            AudioSource.PlayClipAtPoint(pick_gem, collision.transform.position);
            Destroy(gameObject);
            collision.gameObject.GetComponent<cat>().Count++;
            print(Count);
        }
    }

}
