using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeVur : MonoBehaviour
{
    public bool impulse;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        if(impulse)
        {
        rb.AddForce(Vector3.right, ForceMode.Impulse);
        }
        else
        {
        rb.AddForce(Vector3.right);
        }
    }

    private void FixedUpdate()
    {
        //rb.AddForce(Vector3.down * 9.81f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
