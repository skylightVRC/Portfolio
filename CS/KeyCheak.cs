using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeyCheak : MonoBehaviour
{
    public PlayerKeyScore playerKeyScore;
    public KeySpawn keySpawn;
    private bool fs;
    private bool ss;
    private bool ts;
    private int keyscorE;
    private GameObject afterText;
    private Text Text;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        afterText = GameObject.Find("Getafter");//セットテキストで使う
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        /*Debug.Log("現在のスコアは"+keyscorE);
        Debug.Log("現在のfsは"+fs+"現在のssは"+ss);*/
        
        fs = keySpawn.Fs;
        ss = keySpawn.Ss;
        ts = keySpawn.Ts;
        keyscorE = playerKeyScore.keyscore;
        if(other.gameObject.name=="Foot_L")//足にあるコライダー
        {
            if (keyscorE == 1)//鍵の数が1なら次の鍵を出現させる
            {
                if (ss == false)
                {
                    ss = keySpawn.Ss = true;//trueにすることで二回目の鍵のスポーンはもうしましたよという意味
                    keySpawn.KeyobjSpawn();//鍵出現
                    setText();//setText実行
                }

            }
            else if (keyscorE == 2)//鍵の数が2なら次の鍵を出現させる
            {
                if (ts == false)
                {
                    ts = keySpawn.Ts = true;//三回目の鍵のスポーンはしましたよ
                    keySpawn.KeyobjSpawn();//鍵出現
                    setText();
                }

            }
        }
    }
    private void setText()//テキストを変更する、5秒後にsetspaceを実行する　
    {
        Text = afterText.GetComponent<Text>();
        Text.text = "鍵が出現したよ";
        Invoke("setspace", 5);//テキストが消えるように見えるが空白というだけ、トリックさ^^
        //Debug.Log("InvokeFinish");
    }
    void setspace()//テキストを空白にする
    {
        Text.text = " 　";
        Debug.Log(Time.time);
    }
}
