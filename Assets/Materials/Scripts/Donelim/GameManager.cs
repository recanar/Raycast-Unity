using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] dondururObjects;
    private GameObject go;
    private GameObject so;

    // Start is called before the first frame update
    void Start()
    {
            go = Instantiate(dondururObjects[0]);
            so = Instantiate(dondururObjects[1]);
    }

    // Update is called once per frame
    void Update()
    {
        go.transform.Rotate(Vector3.left, 15f * Time.deltaTime);
        so.transform.Rotate(Vector3.right, 10f * Time.deltaTime);
        Debug.DrawLine(Vector3.zero, so.transform.position, Color.red, 3f );
    }
}
