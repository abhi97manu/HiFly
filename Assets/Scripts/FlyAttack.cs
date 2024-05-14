using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FlyAttack : MonoBehaviour
{

    
    [SerializeField] GameObject poisonPrefab;

   
    GameObject poison;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
            {
            StingAttack();
        }

       
    }

    public void StingAttack()
    {   poison = Instantiate(poisonPrefab);
        poison.transform.position = this.transform.position;
        poison.transform.rotation = Quaternion.identity;
       
    }

}


