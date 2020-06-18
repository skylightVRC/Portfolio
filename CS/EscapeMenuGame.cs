using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenuGame : MonoBehaviour
{
    public GameObject Menu;
    private bool howactive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//ゲームシーン用に別に用意したメニュー表示スクリプト Cursorの表示非表示をする
        {
            if (howactive == false)
            {
                Cursor.visible = true;
                Menu.SetActive(true);
                howactive = true;
            }
            else if (howactive == true)
            {
                Cursor.visible = false;
                Menu.SetActive(false);
                howactive = false;
            }//必要なスクリプトかどうか怪しい
        }
    }
}
