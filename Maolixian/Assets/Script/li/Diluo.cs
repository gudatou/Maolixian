using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diluo : MonoBehaviour
{

    public float starttime = 0;
    public float addTime = 1.5f;
    public GameObject Water;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        starttime += Time.deltaTime;
        if (starttime >= addTime)
        {
            if (Water)
            {
                Vector2 water = new Vector2(transform.position.x - 0.05f, transform.position.y + 0.23f);
                Instantiate(Water, water, Quaternion.identity);
            }
            starttime = 0;

        }
    }
}