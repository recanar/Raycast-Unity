using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject BallPrefab;

    // Start is called before the first frame update

    public void CreateBall()
    {
        GameObject go = Instantiate(BallPrefab, gameObject.transform.position, Quaternion.identity);

        Debug.Log(go.transform.position);

        go.GetComponent<Rigidbody>().AddForce(-Vector3.forward * 2, ForceMode.Impulse);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
