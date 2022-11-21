using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInimigo : MonoBehaviour
{
    public float speed;

    public float distance;

    bool isRigth = true;

    public Transform groundCheck;
    // Update is called once per frame
    void Update()
    {
        float MHS = (float)(5.69 * Mathf.Cos(speed * Time.time));

        transform.position = new Vector3(MHS, -1.21f, -1);

        RaycastHit2D ground = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);

        if (ground.collider == false) 
        {
            if (isRigth == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRigth = false;
            }
            else 
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRigth = true;
            }
        }
    }
}
