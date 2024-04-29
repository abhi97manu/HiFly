using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrgonFly : MonoBehaviour
{

    float positionRand;
    float CountDown = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        CountDown -= 1 * Time.deltaTime;

        if ((CountDown<0))
        {
            StartCoroutine(ChangePos());
            CountDown = 2.0f;
        }
       
        
    }

    IEnumerator ChangePos()
    {
       
      
        yield return new WaitForSeconds(1);
        positionRand = Mathf.Sin(Time.time);
        transform.position = new Vector3(transform.position.x, positionRand *2, 0);

    }
}
