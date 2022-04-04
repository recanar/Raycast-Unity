using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private Ray ray;
    RaycastHit hitdata;
    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 5);
        if (Physics.Raycast(transform.position, transform.forward, out hitdata, 5))
        {
            Debug.Log("isin");
            Debug.Log(hitdata.distance+" - "+hitdata.point+" - "+ hitdata.normal);
        }   
        transform.Rotate(Vector3.up/5);
    }
}
