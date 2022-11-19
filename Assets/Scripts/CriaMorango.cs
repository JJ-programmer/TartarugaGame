using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMorango : MonoBehaviour
{

    public GameObject morango;
    // Start is called before the first frame update
    void Start()
    {
        CriaCircunferencia();
    }

    void CriaCircunferencia()
    {
        float y, x;
        float raio = 2.5f;

        for (double teta = 0; teta < Math.PI; teta += 0.3)
        {

            //circunferência
            x = (float)(raio * Math.Cos(teta));
            y = (float)(raio * Math.Sin(teta));

            Instantiate(morango, new Vector3(x, y, -2), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
