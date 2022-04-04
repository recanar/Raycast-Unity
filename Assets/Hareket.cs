using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //// Transform ile hareket ettirme
        // position (property) bilgisi güncelleyerek 
        //transform.position  = new Vector3(transform.position.x + speed * Input.GetAxis("Horizontal") * Time.deltaTime ,transform.position.y,transform.position.z + speed * Input.GetAxis("Vertical") * Time.deltaTime);
        ////Debug.Log(Time.deltaTime);

        // Transform Translate (metot) ile 
        transform.Translate(
            new Vector3(
                Input.GetAxis("Horizontal") * speed, 
                Input.GetAxis("Vertical") * speed, 
                Input.GetAxis("Zaxis") * speed) 
            * Time.deltaTime
           );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //
        }
    }
}
