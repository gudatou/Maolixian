﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fanhuizhucaidan : MonoBehaviour
{
    // Start is called before the first frame update\
    //public void OnStartGame(int MainScence)
    //{
    //    Application.LoadLevel(1 - 1);
    //}
    public void OnStartGame(int SenceNumber)
    {
        Application.LoadLevel(SenceNumber);
    }
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);


    }
    public void OnClick()
    {
        SceneManager.LoadScene("Main");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
