using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class NectorScript : MonoBehaviour
{
    [SerializeField] GameObject BeePlayer;
    int health;
    Camera cam;
    float maxCount = 4.0f;
    bool beingHeld;
    float countDown = 0.0f;
    bool healthInc;


        Flybehaviour flybehaviour;
    void Start()
    {
        cam = Camera.main;
        flybehaviour = FindAnyObjectByType<Flybehaviour>();
        countDown = maxCount;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        Vector2 dist = BeePlayer.transform.position - transform.position;

        

        if (Input.GetMouseButton(1))
        {
           
         if (dist.magnitude < 1f)
            {
               BeePlayer.GetComponent<FlyMovement>().on_nector = true;
                BeePlayer.transform.parent = this.gameObject.transform;

                countDown -= 1* Time.deltaTime;
                //Debug.Log(countDown);

                if (countDown <= 0)
                {
                   // countDown = maxCount;
                    this.GetComponent<ParticleSystem>().Stop();

                }
                else
                {
                    this.GetComponent<ParticleSystem>().Play();
                    flybehaviour.health += 10*Time.deltaTime;

                }
                Debug.Log(countDown);

                //}
                //else
                //{
                //    healthInc = true;
                //}

                //  Debug.Log("Maximum Count :" + (countDown - Time.time));
            }

          
         
           
        }


        else
        {
            BeePlayer.GetComponent<FlyMovement>().on_nector = false;
            BeePlayer.transform.parent = null;
            healthInc = false;
            this.GetComponent<ParticleSystem>().Stop();

        }

       
    }

  




}
