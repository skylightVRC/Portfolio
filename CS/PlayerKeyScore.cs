using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerKeyScore : MonoBehaviour
{
    //プレイヤーの鍵の数を管理する場所
    private int NeedKey;
    public int needKey
    {
        get { return this.NeedKey; }
        set { this.NeedKey = value; }
    }
    private int KeyScore=0;
    public int keyscore
    {
        get { return this.KeyScore; }
        set { this.KeyScore = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        needKey = NeedScoreM.NeedScore;
        Debug.Log("needkey" + NeedKey);
    }

    // Update is called once per frame
    void Update()
    {
        if (NeedKey == 0)//必要な鍵の数が0になったらクリアに移行
        {
            SceneManager.LoadScene("Clear");
        }
    }

    //getkeyの役目
    /*public void AddKeyscore(int amount)
    {
        KeyScore += amount;

        Debug.Log("現在のスコアは" + KeyScore);
    }*/

    /*public int getKeyScore()
    {
        return KeyScore;
    }
    public void setKeyScore(int x)
    {
        KeyScore += x;
    }*/

}
