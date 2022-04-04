using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oyunlar.BallGameGenerator
{

    public class PlayerController : MonoBehaviour
    {
        private Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }

        private void FixedUpdate()
        {
            // Hareket giriþler
            float hInput = Input.GetAxis("Horizontal") * 5f; // donme sol sag
            float vInput = Input.GetAxis("Vertical") * 35f; // iler geri 

            //Vector3 rotation = Vector3.up * hInput;
            //Quaternion acisalDonme = Quaternion.Euler(rotation * Time.fixedDeltaTime);

            //Donme
            //rb.MoveRotation(rb.rotation * acisalDonme);


            // Hareket RB ile
            rb.MovePosition
                (
                this.transform.position
                +
                new Vector3
                (
                    hInput * Time.fixedDeltaTime,
                    0,
                    vInput * Time.fixedDeltaTime
                )
               );


        }



        // Update is called once per frame
        void Update()
        {



        }
    }
}

