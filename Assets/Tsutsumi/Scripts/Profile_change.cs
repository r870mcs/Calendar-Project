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
        if (Button_tex.text == "�ύX")
        {
            Button_tex.text = "�ۑ�";
        }
        else if(Button_tex.text == "�ۑ�")
        {
            Button_tex.text = "�ύX";
        }
        else
        {
            Debug.LogError("�\�����Ȃ��G���[�ł��B");
        }
    }
}
