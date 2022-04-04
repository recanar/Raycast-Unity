using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupCakisma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider box = GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Kliklendi");

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Çakýþma - Collison;");

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(" Trigger : Çakýþma - Collison;");

    }




}
