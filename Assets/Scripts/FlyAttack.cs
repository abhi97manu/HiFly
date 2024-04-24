using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FlyAttack : MonoBehaviour
{
    [SerializeField] GameObject poisonPrefab;
   
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
    {
        GameObject poison = Instantiate(poisonPrefab);
        poison.transform.position = FindAnyObjectByType<Flybehaviour>().transform.position;
    }

}


