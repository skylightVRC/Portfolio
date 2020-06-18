using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator animator;
    private const string key_isRun = "isRun";
    private const string key_isJump = "isJump";
    private const string key_isWalk = "isWalk";
    private const string key_isWait = "isWait";
    



    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            // WaitからWalkに遷移する
            this.animator.SetBool(key_isRun, true);
            this.animator.SetBool(key_isWalk, false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // WaitからWalkに遷移する
            this.animator.SetBool(key_isWalk, true);
            this.animator.SetBool(key_isRun, false);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            // WalkからWaitに遷移する
            this.animator.SetBool(key_isWalk, false);
            this.animator.SetBool(key_isWait, true);

        }

        
        if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.LeftShift))
        {
            // WalkからWaitに遷移する
            this.animator.SetBool(key_isRun, false);
           // this.animator.SetBool(key_isWait, true);
        }

        // Wait or Run からJumpに切り替える処理
        // スペースキーを押下している
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Wait or RunからJumpに遷移する
            this.animator.SetBool(key_isJump, true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            // JumpからWait or Runに遷移する
            this.animator.SetBool(key_isJump, false);
            this.animator.SetBool(key_isWait, true);
        }
        
        

    }

    
}
