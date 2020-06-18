using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTime : Timer
{
    private int clearMinute;
    private float clearSeconds;
    private Text cleartimeText;
    // Start is called before the first frame update
    void Start()
    {
        //clearスクリプトで保存したタイムを使ってタイムを表示
        clearMinute = Clear.cleartimeM;
        clearSeconds = Clear.cleartimeS;
        this.cleartimeText = this.GetComponent<Text>();
        this.cleartimeText.text = clearMinute.ToString("00") + ":" + ((int)clearSeconds).ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
