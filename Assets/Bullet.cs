using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Eðer engel ise enge ve kendisi yok olur
        if (other.gameObject.tag == "engel")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            // diðer durumlarda sadece kendisi yok olur.
            Destroy(gameObject);
        }


    }
}
