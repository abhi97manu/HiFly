using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FlyAttack : MonoBehaviour
{

    
    [SerializeField] GameObject poisonPrefab;
    [SerializeField] Slider AttackSlider;


    public int Attackcount = 0;
    
    GameObject poison;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackSlider.value = Attackcount;
        if (Input.GetKeyDown(KeyCode.Space))
            {
           if(Attackcount >= 100)
            {
                StingAttack();
                Attackcount = 0;
            }
        }

       
       
    }

    public void StingAttack()
    {  
        
       
        poison = Instantiate(poisonPrefab);
        poison.transform.position = this.transform.position;
        poison.transform.rotation = Quaternion.identity;
       
    }



}


