using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxkurukuru : MonoBehaviour
{
    [Range(0.1f, 0.1f)]
    public Material sky;
    public float speed;
    float rotationRepeatValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame //スカイボックスを回す　くるくる～
    void Update()
    {
        rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + speed, 360f);
        sky.SetFloat("_Rotation", rotationRepeatValue);
    }
}
