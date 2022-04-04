using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oyunlar.PlayerDesign
{
    public class PlayerController : MonoBehaviour
    {
        // Bullet
        
        public GameObject bulletPrefab;
        public Transform shootingPoint;

        private Rigidbody rb;

        [SerializeField] // Attributes 
        private float factor;
        private bool jumping;
        private bool canMove;

        // Yere basma isinde kullaniliyor
        private Vector3 yerNokta;

        // hareket input'lar
        private float xInput; // horizontal
        private float zInput; // vertical

        // Hareket hýzlar
        private float xSpeed;
        private float zSpeed;


        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();

            factor = 5f;
            jumping = false;
            canMove = true;
            // canJump;

            yerNokta = new Vector3(0, 1, 0);
            transform.position = new Vector3(0, 1, 0);

            xSpeed = 5f;
            zSpeed = xSpeed;

        }

        // Update is called once per frame
        void Update()
        {
            Jump();
            Movement();
            Shooting();
        }

        // FixedUpdate is called once per frame
        private void FixedUpdate()
        {
            if (jumping)
            {
                rb.AddForce(Vector3.up * factor, ForceMode.Impulse);
                jumping = false;
            }
        }

        private void Shooting()
        {
            if(bulletPrefab != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    // Instantiate
                    Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
                }
            }
        }

        private void Movement()
        {
            if (canMove)
            {
                // Input manager ile
                xInput = Input.GetAxis("Horizontal");
                zInput = Input.GetAxis("Vertical");

                transform.Translate(Vector3.forward * zInput * zSpeed * Time.deltaTime);
                transform.Translate(Vector3.right * xInput * xSpeed * Time.deltaTime);
            }
        }

        private void Jump()
        {
            if (YereBasiyor())
            {
                if (Input.GetKeyDown(KeyCode.Space) && !jumping)
                {
                    jumping = true;
                }
            }
        }

        private bool YereBasiyor()
        {
            return transform.position.y <= yerNokta.y;
        }

        private void OnTriggerEnter(Collider other)
        {
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "engel")
            {
                Debug.Log("Puan kazandýn...");
                Destroy(collision.gameObject);
            }
        }
    }
}

// Transform ile jump iki konumlu + havada kalýþ
//// Update is called once per frame
//void Update()
//{
//    if (Input.GetKeyDown(KeyCode.Space) && !jumping)
//    {
//        jumping = true;
//        transform.Translate(Vector3.up * maxJump);
//        Invoke("JumpDown", jumpTime);
//    }

//    //if(Input.GetKeyUp(KeyCode.Space))
//    //{
//    //    //transform.Translate(Vector3.down * maxJump * Time.deltaTime);
//    //    //transform.position = baslangicPos;
//    //}

//}

//private void JumpDown()
//{
//    transform.position = baslangicPos;
//    jumping = false;
//}


// Transform ile jump + max jump kendi düþer 
//private float maxJump; // maksimum sicrama
//private float maxSeviye;
//private float stepJump;
//private float jumpTime;
//private Vector3 baslangicPos;
//private bool jumping;

//// Start is called before the first frame update
//void Start()
//{
//    maxJump = 3f;
//    maxSeviye = 6f;
//    jumpTime = 1f;
//    stepJump = 0.04f;
//    baslangicPos = GetComponent<Transform>().position; // baslangic pozisyonu 

//}

//// Update is called once per frame
//void Update()
//{
//    if (Input.GetKey(KeyCode.Space) && !MaksErisildi() && !jumping)
//    {
//        transform.Translate(Vector3.up * stepJump);
//    }

//    else
//    {
//        jumping = true;
//        if (transform.position.y >= 1)
//        {
//            transform.position = new Vector3(0, transform.position.y - 0.02f, 0);
//        }
//        else
//        {
//            jumping = false;
//        }
//    }
//}

//private void JumpDown()
//{
//    transform.position = baslangicPos;
//    jumping = false;
//}

//private bool MaksErisildi()
//{
//    return transform.position.y >= maxSeviye;
//}
//    }