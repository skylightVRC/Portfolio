using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Clear : PlayerKeyScore
{
    public PlayerKeyScore playerKeyScore;
    public Timer timer;
    private int score;
    public static int cleartimeM;
    public static float cleartimeS;
    private GameObject Obj;
    FirstPersonController script;

    void Start()
    {
        Obj = GameObject.Find("yume");//ユメちゃん捜索してobjに入れる
    }

    // Update is called once per frame
    void Update()
    {

        score = playerKeyScore.keyscore;//現在の鍵の取得数をscoreに入れる
        
        if (score == NeedScoreM.NeedScore)　//先ほど入れたscoreが必要な鍵の数と一致しているか
        {
            //一致していたら必要な鍵をすべて手に入れたのでsceneクリアに移動
            //クリアタイムが必要なのでパブリックのスタテックに現在の制限時間を代入
            cleartimeM = timer.minutE;
            cleartimeS = timer.secondS;
            FirstPersonController script = Obj.GetComponent<FirstPersonController>();
            script.setCursorLock();//このままいくとCursorがロックされたままなので
            SceneManager.LoadScene("Clear");
        }
    }
}
