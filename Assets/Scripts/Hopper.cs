using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Hopper : MonoBehaviour
{
    float velocity = 2.0f;
    float gravityAcc = 0.5f;
    Vector3 InitPos;
    Vector3 currentPos;
    Vector3 hop;
    void Start()
    {
        InitPos = transform.position;
        currentPos = Vector3.zero;
       
    }

    // Update is called once per frame
    void Update()
    {
        HoppingFunc();
        if ((transform.position.y <= -3.5f))
        {
            //currentPos = transform.position;

            InitPos = new Vector3(transform.position.x, -3.4f, 0); ;
            HoppingFunc();
        }
      

    }

    void HoppingFunc()
    {
        Debug.Log(InitPos);
         hop = new Vector3(-velocity * Mathf.Cos(45f * Mathf.Deg2Rad) * Time.time, (velocity * Mathf.Sin(45f * Mathf.Deg2Rad) * Time.time) - (0.5f * gravityAcc * Time.time * Time.time), 0);
        
        transform.position = hop + InitPos ;
    }
}
