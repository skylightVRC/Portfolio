using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameOver : MonoBehaviour
{
    public GameObject Target;
    FirstPersonController script;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Custaちゃんに触れてしまったら
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject == Target)
        {
            FirstPersonController script = GetComponent<FirstPersonController>();
            script.setCursorLock();
            //Cursorロックを外してゲームオーバーシーンへ移行
            SceneManager.LoadScene("GameOver");
        }
    }
}
