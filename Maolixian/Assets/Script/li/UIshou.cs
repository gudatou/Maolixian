using UnityEngine;
using System.Collections;
using UnityEngine.UI;//注意这个不能少
//using UnityEditor.Sprites ;
public class UIshou : MonoBehaviour
{
    //public GameObject Gmenue;
    public GameObject btnObj;
    public GameObject caidan;
    public Sprite expan;
    public Sprite back;
    Button btn;
    bool isshow = true;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void handle_Click()
    {
        caidan.SetActive(isshow);
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            isshow = !isshow;
            caidan.SetActive(isshow);
            if (isshow)
            {
                btn.GetComponent<Image>().sprite = expan;
            }
            else
            {
                btn.GetComponent<Image>().sprite = back;
            }
        });
    }
}
