using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class dia1 : MonoBehaviour
{
    public int dia10 = 10;
    private int diamond;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("diamond");
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (diamond >= dia10)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}