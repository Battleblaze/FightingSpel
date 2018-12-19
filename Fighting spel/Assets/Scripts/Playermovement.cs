using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public GameObject Spelare1;
    int maxspeed = 100;
    private Rigidbody2D rb;
    public float speed;
    public float jump;
	
	void Start ()
	{
	    rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {

	   
	}


    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground" && (Input.GetKey(KeyCode.UpArrow)))
        {
            Debug.Log("Jadååå");
            rb.AddForce(Vector2.up * jump);

        }


        if (coll.gameObject.tag == "Ground")
        {
            Vector2 v = rb.velocity;
            v.x = 0;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                v.x = -speed;
            }

            rb.velocity = v;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                v.x = speed;
            }

            rb.velocity = v;


            if (Input.GetKey(KeyCode.UpArrow))
            {

            }

        }
    }
}
