using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Oyunlar.BallGameGenerator
{

    public class GameController : MonoBehaviour
    {
        // Generator
        public GameObject generatorPrefab;
        public Vector3 baslangic;
        public GameObject baslangicNoktasi;

        public int generatorSayisi;
        public Material[] materyaller;

        // Player
        public GameObject playerPrefab;

        // Start is called before the first frame update
        void Start()
        {
            CreateGenerators();
            CreatePlayer();
            //TestTriggerGenerators();
        }

        private void TestTriggerGenerators()
        {
            Generator[] gens = baslangicNoktasi.GetComponentsInChildren<Generator>();
            Debug.Log(gens.Length);
            foreach (Generator generator in gens)
            {
                generator.CreateBall();
            }
        }

        private void CreatePlayer()
        {
            Instantiate(playerPrefab, new Vector3(baslangic.x, baslangic.y, baslangic.z - 4), Quaternion.identity);
        }

        private void CreateGenerators()
        {
            int generatorGenislik = 1;
            int aralik = 1;

            for (int i = 0; i < generatorSayisi; i++)
            {
                Vector3 delta = new Vector3(baslangic.x + (generatorGenislik + aralik) * i, baslangic.y, baslangic.z);

                GameObject generatorObject = Instantiate(generatorPrefab, delta, Quaternion.identity, baslangicNoktasi.transform);

                //generatorObject.GetComponentInChildren<Generator>().CreateBall();

                generatorObject.tag = "generator";

                // material deðiþikliði
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TestTriggerGenerators();
                Debug.Log("Generated");
            }

        }
    }

}
