using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] Transform targetObj;
    public Vector3 offset;

    Vector3 velo = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = targetObj.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, vec, ref velo, 0.5f);
    }
}
