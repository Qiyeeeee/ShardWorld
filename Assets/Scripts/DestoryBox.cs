using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBox : MonoBehaviour
{
    private float hight;
    // Start is called before the first frame update
    void Start()
    {
        hight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string ground = "Cube";
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains(ground))
        {
            //ContactPoint2D contact = collision.contacts[0];
            //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            //Vector3 pos = contact.point;
            
            if(hight- transform.position.y>=2f)
                   Destroy(transform.gameObject);
        }
    }
    }
