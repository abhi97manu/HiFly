using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrgonFly : MonoBehaviour
{

    float positionRand;
    float CountDown = 2.0f;

    Flybehaviour bee;
    // Start is called before the first frame update
    void Start()
    {
        bee = FindAnyObjectByType<Flybehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = this.transform.position - bee.GetComponent<Transform>().position;
        CountDown -= 1 * Time.deltaTime;

        if ((CountDown<0) && dist.magnitude < 10.5)
        {
            StartCoroutine(ChangePos());
            CountDown = 2.0f;
        }
       
        
    }

    IEnumerator ChangePos()
    {
       
      
        yield return new WaitForSeconds(1);
        positionRand = Mathf.Sin(Time.time);
        this.transform.position = new Vector3(transform.position.x, positionRand *2, 0);

    }
}
