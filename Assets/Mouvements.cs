using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider bc;
    public CameraMouvement scriptCamera;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = gameObject.GetComponent<BoxCollider>();
        scriptCamera = GameObject.Find("Main Camera").GetComponent<CameraMouvement>();

    }

    // Update is called once per frame
    void Update()
    {
        // On augmente la friction si l'user appuye sur espace =  freinage


        if (Input.GetKeyDown("space"))
        {

            bc.material.dynamicFriction = 1.0f;
            
           


            // On diminue la friction si l'user appuye sur espace = propulsion
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bc.material.dynamicFriction = 0.0f;
            rb.AddForce(transform.forward * 1000.0f);
            scriptCamera.declenchement = true;
        }       
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           
            rb.AddForce(transform.right * 1000.0f);
         
           
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(transform.right * - 1000.0f);
        }
    }
}
