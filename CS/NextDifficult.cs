using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextDifficult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()//ボタンを押したら必要な鍵の数を足す(4以上にならないように)
    {
        if (NeedScoreM.NeedScore < 3)
        {
            NeedScoreM.NeedScore++;
            Debug.Log(NeedScoreM.NeedScore);
        }
    }
}
