using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcDesign : MonoBehaviour
{
    public GameObject prefab;

    public int xFac;
    public int zFac;
    private GameObject go;

    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            // z    
            for (int j = 0; j < 4; j++)
            {
                // x
                // kübün transform position x y z 
                go = Instantiate(prefab, new Vector3(j * xFac, 1, i * zFac), Quaternion.Euler(
                    new Vector3(0, 45, 0)
                   )
                );

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
