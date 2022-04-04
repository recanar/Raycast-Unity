using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerKeyboard : MonoBehaviour
{
    public GameObject tusPrefab;
    public Material TusDefaultMaterial;
    private GameObject go;

    KeyCode[] klayveTuslar =
    {
        KeyCode.A,
        KeyCode.S,
        KeyCode.D
    };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            go = Instantiate(tusPrefab,transform.position + new Vector3(2 * i,0,0), Quaternion.identity);
            go.GetComponent<Tus>().TusMaterialNormal = TusDefaultMaterial; 
        }



    }

    // Update is called once per frame
    void Update()
    {
        // ?
        
    }
}
