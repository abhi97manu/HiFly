using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flybehaviour : MonoBehaviour
{

    public float health =0;
    private int maxHealth = 100;
    public Slider healthBar;
    public bool gainedHealth;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health/100;
     
    }
}
