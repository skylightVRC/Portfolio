using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoPlayUI : MonoBehaviour
{
    public GameObject Howtoplay;　//UI
    private bool howactive = false;　//現在アクティブかどうか

    // Start is called before the first frame update
    void Start()
    {
        howactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick() //アクティブなら非アクティブへ、非アクティブならアクティブへ
    {
        if (howactive == false)
        {
            Howtoplay.SetActive(true);
            howactive = true;
        }
        else if (howactive == true)
        {
            Howtoplay.SetActive(false);
            howactive = false;
        }
        
    }
}
