using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUI : MonoBehaviour
{
    public GameObject settingUI;
    private bool howactive;

    // Start is called before the first frame update
    void Start()
    {
        howactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()//クリックしたらUIをアクティブにする、アクティブなら非アクティブにする
    {
        if (howactive == false)
        {
            settingUI.SetActive(true);
            howactive = true;
        }
        else if (howactive == true)
        {
            settingUI.SetActive(false);
            howactive = false;
        }
    }
}
