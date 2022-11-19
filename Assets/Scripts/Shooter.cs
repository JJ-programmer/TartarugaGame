using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject tiroPrefab;
    public GameObject lancamento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tiroPrefab, new Vector3(lancamento.transform.position.x, lancamento.transform.position.y, lancamento.transform.position.z), lancamento.transform.rotation);
        }
    }
}

