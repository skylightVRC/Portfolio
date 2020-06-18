using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    
    private Text targetText;
    public PlayerKeyScore playerKeyScore;
    private int addscore=1;
    private int score;
    private int need;
    private GameObject afterText;
    private Text Text;

    // Start is called before the first frame update
    void Start()
    {
        afterText = GameObject.Find("Getafter");
    }

    // Update is called once per frame
    void Update()
    {
        need = NeedScoreM.NeedScore;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "鍵(Clone)")
        {
            Debug.Log("atatta!");
            //playerKeyScore.AddKeyscore(addscore);
            playerKeyScore.keyscore = score + addscore;//鍵取得したら取得した鍵の数を表すスコアを足す
            score = playerKeyScore.keyscore;
            playerKeyScore.needKey = need - 1;//必要な鍵の数を表すneedを減らす
            need = playerKeyScore.needKey;  
            GameObject key = GameObject.Find("鍵(Clone)");
            //発見
            Destroy(key);//オブジェクト破壊
            switch (need)//鍵を取得してまだ鍵が必要ならテキストを変更
            {
                case 0:
                    Debug.Log("case0だよ");
                    break;
                case 2:
                case 1:
                    Text = afterText.GetComponent<Text>();
                    Text.text = "スタート地点に戻ろう";
                    Debug.Log("case2,1実行終了");
                    break;
            }
            
            //鍵破壊
            Debug.Log("取得");
            Debug.Log(score + need);
            Debug.Log("need:"+need);


        }

    }
    
    
}
