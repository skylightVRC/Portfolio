using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )//スペース押したらゲームシーンに移行
        {
            SceneManager.LoadScene("Game");
        }   
    }
}
