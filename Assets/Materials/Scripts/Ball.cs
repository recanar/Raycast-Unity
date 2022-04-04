using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(new Vector3(0f, 1, 0), 45); 

        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.green;
        
        Physics.gravity = new Vector3(1, -1, 0);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.drag = 0.3f;
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime); // saniyede "speed" derece dön
    }

    private void OnMouseDown()
    {
        Debug.Log("Kliklendi");

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Çakýþma - Collison;");

    }



}
