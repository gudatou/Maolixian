using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public Transform[] paths;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name =="spring")
        {

        }
        Hashtable args = new Hashtable();
        args.Add("speed", 3.0f);
        args.Add("path", iTweenPath.GetPath("MyPath"));
        iTween.MoveTo(gameObject,args);
    }
}
