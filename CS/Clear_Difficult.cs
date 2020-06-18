using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear_Difficult : MonoBehaviour  //クリアした際にどの難易度でクリアしたかUIのテキストに表示させる
{
    private Text clearDiffcult;
    private int Level;


    // Start is called before the first frame update
    void Start()
    {
        Level = NeedScoreM.NeedScore;//必要な鍵の数の取得
    }

    // Update is called once per frame
    void Update()
    {
        //必要な鍵の数で難易度を判断してテキストの変更
        switch (Level)
        {
            case 1:
                this.clearDiffcult = this.GetComponent<Text>();
                this.clearDiffcult.text = "Easy";
                break;
            case 2:
                this.clearDiffcult = this.GetComponent<Text>();
                this.clearDiffcult.text = "Normal";
                break;
            case 3:
                this.clearDiffcult = this.GetComponent<Text>();
                this.clearDiffcult.text = "Hard";
                break;
        }
    }
}
