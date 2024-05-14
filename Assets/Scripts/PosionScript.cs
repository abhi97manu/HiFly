using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosionScript : MonoBehaviour
{

    [SerializeField] int poisonSpeed = 10;
    FlyMovement fly;

    float timerCount = 2f;
    // Start is called before the first frame update
    void Start()
    {
        fly = FindAnyObjectByType<FlyMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fly.flipped !=true)
       this.GetComponent<Rigidbody2D>().velocity = Vector2.right * poisonSpeed * Time.deltaTime;
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.left * poisonSpeed * Time.deltaTime;
        }

        timerCount -= Time.deltaTime;
        if (timerCount <= 0)
        {
            Destroy(gameObject);
            timerCount = 2f;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.collider.name == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
