using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text Score;
    private cat d = null;
    public Sprite PlaySprite;
    public Sprite PauseSprite;
    private bool paused = false;
    public Button BtnPlayOrPause;
    // Use this for inq`itialization
    void Start()
    {
        //Score.text = "100";
        d = GameObject.FindGameObjectWithTag("Black Cat").GetComponent<cat>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = d.Count.ToString();
    }

    public void PlayOrPauseGame()
    {
        //切换游戏暂停的状态
        paused = !paused;
        //实现暂停或游戏
        Time.timeScale = paused ? 0 : 1;
        //按钮图片的切换
        BtnPlayOrPause.image.sprite = !paused ? PauseSprite : PlaySprite;


    }
}