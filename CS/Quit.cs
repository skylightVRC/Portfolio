using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Quit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()//クリックしたらゲームを終了する
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }
}
