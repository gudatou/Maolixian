﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera3 : MonoBehaviour
{
    public GameObject Keyingwave;
    private Transform m_Transform;
    private Transform cat_Transform;

    public float StartTime;
    public float EndTime;
    private float time;

    private Vector3 normalPos;

    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        cat_Transform = GameObject.FindGameObjectWithTag("Black Cat").GetComponent<Transform>();
        normalPos = m_Transform.position;
    }

    void Update()
    {
        createKW();
    }

    void LateUpdate()
    {
        if (cat_Transform.position.y > 9)
        {

            Vector3 nextPos = new Vector3(cat_Transform.position.x + 2, 9, cat_Transform.position.z - 10);
            m_Transform.position = Vector3.Lerp(m_Transform.position, nextPos, Time.deltaTime * 2);
        }
        if (cat_Transform.position.y < -36)
        {

            Vector3 nextPos = new Vector3(cat_Transform.position.x + 2, -38, cat_Transform.position.z - 10);
            m_Transform.position = Vector3.Lerp(m_Transform.position, nextPos, Time.deltaTime * 2);
        }
        if (cat_Transform.position.y > -36 && cat_Transform.position.y < 9)
        {

            Vector3 nextPos = new Vector3(cat_Transform.position.x + 2, cat_Transform.position.y, cat_Transform.position.z - 10);
            m_Transform.position = Vector3.Lerp(m_Transform.position, nextPos, Time.deltaTime * 5);
        }
    }

    void FixedUpdate()
    {
        time++;
        if (this.GetComponent<Camera>().orthographicSize >= 2 && StartTime <= time && time <= EndTime)
        {
            this.GetComponent<Camera>().orthographicSize -= 0.04f;
        }
        else if (this.GetComponent<Camera>().orthographicSize <= 5 && time >= EndTime)
        {
            this.GetComponent<Camera>().orthographicSize += 0.04f;
        }
    }
    private void createKW()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mp = Input.mousePosition;
            Vector3 keyW = Camera.main.ScreenToWorldPoint(mp);
            Vector3 newW = new Vector3(keyW.x, keyW.y, 0);
            GameObject KW = Instantiate(Keyingwave, newW, Quaternion.identity);
        }
    }
}
