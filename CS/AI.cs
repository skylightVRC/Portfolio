using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour//追いかけるためのスクリプト、実際そこまで細かく理解はしてないが
{
    public NavMeshAgent player;
    public GameObject target;//標的

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            player.destination = target.transform.position;
        }
    }
}
