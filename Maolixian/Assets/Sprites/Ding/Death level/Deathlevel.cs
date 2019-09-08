using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathlevel : MonoBehaviour
{
    public Transform death;
    public GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cat = GameObject.Find("cat");
        death = GetComponent<Transform>();
        cat  = cat.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        death.transform.parent = cat.transform;
    }
}
