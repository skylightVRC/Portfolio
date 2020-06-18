using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDifficult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()//必要な鍵の数を減らす(0にならないように)
    {
        if (NeedScoreM.NeedScore > 1)
        {
            NeedScoreM.NeedScore--;
            Debug.Log(NeedScoreM.NeedScore);
        }
    }
}
