using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ShooterInimigo : MonoBehaviour
{
    public GameObject PrefabIni;
    public GameObject lancamentoInimigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.Random prob = new System.Random(); 
        if(prob.NextDouble() <0.01)
        {

            Instantiate(PrefabIni, new Vector3(lancamentoInimigo.transform.position.x, lancamentoInimigo.transform.position.y, lancamentoInimigo.transform.position.z), lancamentoInimigo.transform.rotation);
        }
    }
}
