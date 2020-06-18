using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : PlayerKeyScore
{
    //使う鍵のオブジェクトとスポーン地点に使う空のオブジェクト
    public GameObject Key;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    public GameObject spawnPoint5;
    public GameObject spawnPoint6;
    public GameObject spawnPoint7;
    public GameObject spawnPoint8;
    public GameObject spawnPoint9;
    public GameObject spawnPoint10;

    //何個目の鍵のスポーンが終わったかどうか判断するためのbool
    private bool Firstspawn = false;
    private bool Secondspawn = false;
    private bool Thirdspawn = false;
    public bool Fs
    {
        get { return this.Firstspawn;  }
        private set { this.Firstspawn=value; }
    }
    public bool Ss
    {
        get { return this.Secondspawn; }
        set { this.Secondspawn = value; }
    }
    public bool Ts
    {
        get { return this.Thirdspawn; }
        set { this.Thirdspawn = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        //最初の鍵のスポーン
        KeyobjSpawn();
        Firstspawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void KeyobjSpawn()//ランダムに数値を出してランダムな位置に鍵をスポーンさせる
    {
        int SPvalue = Random.Range(1, 10);

        if (SPvalue == 1)
        {
            Instantiate(Key, spawnPoint1.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 2)
        {
            Instantiate(Key, spawnPoint2.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 3)
        {
            Instantiate(Key, spawnPoint3.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 4)
        {
            Instantiate(Key, spawnPoint4.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 5)
        {
            Instantiate(Key, spawnPoint5.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 6)
        {
            Instantiate(Key, spawnPoint6.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 7)
        {
            Instantiate(Key, spawnPoint7.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 8)
        {
            Instantiate(Key, spawnPoint8.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 9)
        {
            Instantiate(Key, spawnPoint9.transform.position, Quaternion.identity);
        }
        else if (SPvalue == 10)
        {
            Instantiate(Key, spawnPoint10.transform.position, Quaternion.identity);
        }
    }
    //セットとゲット、最初のスポーンは確定なのでget、他は後から変更をするのでset
    public void setSecondSpawn(bool x)
    {
        Secondspawn = x;
    }
    public void setThirdSpawn(bool y)
    {
        Thirdspawn = y;
    }
    public bool getFirstSpawn()
    {
        return Firstspawn;
    }
}
