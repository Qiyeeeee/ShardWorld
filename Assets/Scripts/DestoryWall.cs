using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerController.speed = 15;
        }
        else
        {
            playerController.speed = 8;
        }
    }
    private string wall = "wall";
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains(wall))
        {
            //ContactPoint2D contact = collision.contacts[0];
            //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            //Vector3 pos = contact.point;

            if (playerController.speed >= 10f)
                Destroy(collision.gameObject);
        }
    }
}
