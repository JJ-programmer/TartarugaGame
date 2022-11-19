using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTartaruga : MonoBehaviour
{
    public GameObject tartaruga;
    public float velocidade = 1.0f;
    public int morangosColetados;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0.2f, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -0.2f, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-0.2f, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.2f, 0, 0));
        }
        print("foram coletados " + morangosColetados);
    }
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("morango"))
        {
            Destroy(body.gameObject);
            morangosColetados++;
        }
    }
}
