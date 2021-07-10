using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Profile_change : MonoBehaviour
{

    private Text Button_tex;
    private void Start()
    {
        Button_tex = transform.Find("Text").gameObject.GetComponent<Text>();
    }

    public void Change_Button()
    {
        if (Button_tex.text == "変更")
        {
            Button_tex.text = "保存";
        }
        else if(Button_tex.text == "保存")
        {
            Button_tex.text = "変更";
        }
        else
        {
            Debug.LogError("予期しないエラーです。");
        }
    }
}
