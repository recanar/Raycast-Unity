using UnityEngine;

public class Tus : MonoBehaviour
{
    // Tus tasarým
    public Material TusMaterialNormal;
    public Material TusMaterialBasili;
    public KeyCode TusKey;


    // Kup
    public GameObject KupPrefab;
    //private float hiz = 5;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = TusMaterialNormal;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(TusKey))
        {
            GetComponent<Renderer>().material = TusMaterialBasili;
            //KupFirlat();
            KupFirlatSurekli();
        }

        if (Input.GetKeyUp(TusKey))
        {
            GetComponent<Renderer>().material = TusMaterialNormal;
            KupFirlatSurekliIptal();
        }
    }

    private void KupFirlatSurekliIptal()
    {
        CancelInvoke("KupFirlat");
    }

    // Kup firlat
    void KupFirlat()
    {
        GameObject go = Instantiate(KupPrefab, transform);
    }

    void KupFirlatSurekli()
    {
        InvokeRepeating("KupFirlat", 0, 0.1f);
    }
}
