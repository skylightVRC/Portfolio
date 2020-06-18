using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnLockCursor : MonoBehaviour
{
    
    public GameObject SettingUI;
    public GameObject HowtoPlay;
    private bool UIactive;
    private bool UnLock;
    // Start is called before the first frame update
    void Start()
    {
        UIactive = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        UIactive = SettingUI.activeSelf;
        if (UIactive == true)
        {

        }
        
    }
}
