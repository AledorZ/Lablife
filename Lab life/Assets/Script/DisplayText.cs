using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public string Mystring;
    public Text MyText;
    public float fadetime;
    public bool displayinfo;

    // Start is called before the first frame update
    void Start()
    {
        MyText = GameObject.Find("Text").GetComponent<Text>();
        MyText.color = Color.clear;
    }

    // Update is called once per frame
    void Update() => FadeText();
    void OnMouseOver()
    {
        displayinfo = true;
    }
    void OnMouseExit()
    {
        displayinfo = false;
    }

    void FadeText()
    {
        if (displayinfo)
        {
            MyText.text = Mystring;
            MyText.color = Color.Lerp(MyText.color, Color.white, fadetime * Time.deltaTime);
        }
        else
        {
            MyText.color = Color.Lerp(MyText.color, Color.clear, fadetime * Time.deltaTime);
        }
    }
    

    
}
