using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirlayanKup : MonoBehaviour
{
    Rigidbody rb;
    private float hiz = 4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * hiz * Time.deltaTime);
        //rb.AddForce(Vector3.up);
        rb.velocity = Vector3.up * hiz;

    }
}
