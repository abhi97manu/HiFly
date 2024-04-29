using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waspAttack : MonoBehaviour
{
    [SerializeField] GameObject PoisonStingPrefab;
    FlyMovement PlayerBee;
    GameObject sting;
    float CountDown = 2.0f;
    float StingLifeTime = 4.0f;
    bool Init = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBee = FindObjectOfType<FlyMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(CountDown);
        if((transform.position.magnitude - PlayerBee.transform.position.magnitude) <=4) {
            CountDown -= 1*  Time.deltaTime;
            
            if (CountDown <= 0)
            {
                Attack();
                Init = true;
                StartCoroutine(StingAttack());
                CountDown = 2.0f;

            }
            //else if (CountDown < 0 ) {
            //    Init = false;
            //    CountDown = 2.0f;
            //}


        }

       
            
      
    }

    void Attack()
    {
       sting  = Instantiate( PoisonStingPrefab );
        // sting.transform.position =  PoisonStingPrefab.transform.position;
       



    }

    IEnumerator StingAttack()
    {
        if (Init)
        {
            sting.transform.position = Vector2.MoveTowards(this.transform.position, PlayerBee.transform.position, 500 * Time.deltaTime);
            StingLifeTime -= 1 * Time.deltaTime;

            if (StingLifeTime == 0)
            {
                
            }

            else if (StingLifeTime < 0)
            {
                Destroy(sting);
                StingLifeTime = 4.0f;
            }

        }

       
        yield return new WaitForSeconds(1);
       
    }
}
