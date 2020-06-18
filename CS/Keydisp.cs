using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keydisp : MonoBehaviour
{
    private Text targetText;
    public PlayerKeyScore playerKeyScore;
    private int keyscore;
    private int needkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        //現在の取得した鍵の数と現在の必要な鍵の数取得
        keyscore = playerKeyScore.keyscore;
        needkey = playerKeyScore.needKey;
        //テキストを先ほど取得した鍵の数に変更
        this.targetText = this.GetComponent<Text>(); 
        this.targetText.text = "KeyCount:"+keyscore+"NeedKey"+needkey; 

    }
}
