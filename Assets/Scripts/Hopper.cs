using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Hopper : MonoBehaviour
{
    FlyMovement fly;

    float velocity = 2.0f;
    float gravityAcc = 0.5f;
    float timer = 0;
    Vector3 InitPos;
    Vector3 currentPos;
    Vector3 hop;
    void Start()
    {
        InitPos = transform.position;
        currentPos = Vector3.zero;
        fly = FindAnyObjectByType<FlyMovement>();
       
    }

    // Update is called once per frame
    void Update()
    { 
        float dist = this.transform.position.x - fly.transform.position.x;

      if(dist <5.0f ) {
            HoppingFunc();

        }
           
          
        
        if ((transform.position.y <= -5.5f))
        {

            Destroy(this.gameObject);
        }
            //currentPos = transform.position;

        //    InitPos = new Vector3(transform.position.x, -3.4f, 0); ;
        //    HoppingFunc();
        //}
      

    }

    void HoppingFunc()
    {

        
        timer += 1f * Time.deltaTime;
            hop = new Vector3(-velocity * Mathf.Cos(45f * Mathf.Deg2Rad) * timer, (velocity * Mathf.Sin(45f * Mathf.Deg2Rad) * timer) - (0.5f * gravityAcc * timer * timer), 0);
        Debug.Log(timer);
        this.transform.position = InitPos + hop;
        
    }
}
