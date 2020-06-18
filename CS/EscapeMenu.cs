using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    public GameObject Menu;
    private bool howactive;
    private GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        UI = null;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//escapeボタンでメニューUIの表示
        {
            if (howactive == false)
            {
                //Cursor.visible = true;
                Menu.SetActive(true);
                howactive = true;
            }
            else if (howactive == true)//メニューがアクティブなら非アクティブへ
            {
                //Cursor.visible = false;
                if(UI = GameObject.Find("Setting"))//もし設定のUIがアクティブなら非アクティブにして次開く際に初期の状態になるようにする
                {
                    UI.SetActive(false);
                }

                if (UI = GameObject.Find("Howtoplay"))//もし遊び方のUIアクティブなら非アクティブにして次開く際に初期の状態になるようにする
                {
                    UI.SetActive(false);
                }
                Menu.SetActive(false);
                howactive = false;
            }
        }
    }
}
