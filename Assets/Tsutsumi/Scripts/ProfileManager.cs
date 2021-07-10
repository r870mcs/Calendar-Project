using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProfileManager : MonoBehaviour
{
    private Text Pname;
    private Text Pinput;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Pname = transform.Find("Profile_name").gameObject.GetComponent<Text>();
        Pinput = transform.Find("Profile_input").transform.Find("input_name").gameObject.GetComponent<Text>();
        Pname.text = Pinput.text;
    }
}
