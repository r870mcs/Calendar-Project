using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Profile_name : MonoBehaviour
{
    Text name_text;

    public void Sync_name(Text Changed_text)
    {
        name_text = this.gameObject.GetComponent<Text>();
    }
}
