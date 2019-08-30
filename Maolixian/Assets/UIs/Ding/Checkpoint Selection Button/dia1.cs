using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dia1 : MonoBehaviour
{
    public int dia10 = 10;
    private int coin;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("coin");
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (coin >= dia10)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}