using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedScoreM : MonoBehaviour
{
    //NeedScoreを持っているコード
    //nextとbackのUIで難易度を制御して最終的なスコアがここに記載される
    //sceneを変更しても使用できるようにパブリックのスタテックにしている
    public static int NeedScore;
    // Start is called before the first frame update
    void Start()
    {
        NeedScore = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
