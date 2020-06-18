using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLevel : MonoBehaviour
{
    private Text targetText;
    private int Level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Level = NeedScoreM.NeedScore;//必要な鍵の数を取得


        switch (Level)//必要な鍵の数で難易度を判断して難易度をテキストに表示
        {
            case 1:
                this.targetText = this.GetComponent<Text>();
                this.targetText.text = "Easy";
                break;
            case 2:
                this.targetText = this.GetComponent<Text>();
                this.targetText.text = "Normal";
                break;
            case 3:
                this.targetText = this.GetComponent<Text>();
                this.targetText.text = "Hard";
                break;
        }
    }
}
