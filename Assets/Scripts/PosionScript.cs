using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosionScript : MonoBehaviour
{

    [SerializeField] int poisonSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.right * poisonSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.collider.name == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
