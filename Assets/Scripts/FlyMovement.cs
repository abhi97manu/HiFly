using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    [SerializeField] GameObject FlyPrefab;
    [SerializeField] float dashPower;
    [SerializeField] float dashDuration;


    private Vector3 InitPos;
    private Vector3 dir;
    private bool isDashing;

   

    Vector3 defaultPos = new Vector3(-3.28410888f, 0.384784341f, -0.000777338573f);
    public float steps;

    public bool flipped;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //if (isDashing)
        //{
        //    return;
        //}
        if (Input.GetMouseButtonDown(0))
        {
            InitPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dir = new Vector3(InitPos.x, InitPos.y, 0f) - FlyPrefab.transform.position;
            if (FlyPrefab.transform.position.x < InitPos.x)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().flipX = false ;
                flipped = false;
            }
            else
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().flipX = true;
                flipped = true;
            }
            {
                StartCoroutine(DashAttack());

                //FlyPrefab.transform.position += dir.normalized * dashPower * Time.deltaTime * Time.timeScale;
                Debug.Log(InitPos);
            }

        }
      

    }

    IEnumerator DashAttack()
    {
      //  isDashing = true;
        while (Vector2.Distance(transform.position, InitPos) > 0.5f)
        {
            //FlyPrefab.GetComponent<Rigidbody2D>().velocity = dir.normalized * dashPower * Time.deltaTime;
            FlyPrefab.transform.Translate(dir.normalized * dashPower * Time.deltaTime);
            yield return new WaitForSeconds(dashDuration);

        }

     //   isDashing = false;
        // StartCoroutine(BackToOrig());
    }

}
