using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShooter : MonoBehaviour
{

    public float velocidade = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(velocidade * Time.deltaTime, 0));
    }

    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("morango"))
        {
            Destroy(body.gameObject);

        }
    }
}
