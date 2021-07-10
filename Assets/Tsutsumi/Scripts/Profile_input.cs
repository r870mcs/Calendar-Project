using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile_input : MonoBehaviour
{


    public void Change_Name()
    {
        bool isactive;
        isactive = gameObject.activeInHierarchy;
        Text text_Changed;
        text_Changed = transform.Find("input_name").GetComponent<Text>();
        

        if (isactive)
        {
            gameObject.SetActive(false);
            

        }
        else if (!isactive)
        {
            gameObject.SetActive(true);
        }
    }
}
