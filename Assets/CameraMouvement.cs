using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvement : MonoBehaviour
{
    public GameObject corps;

    public Rigidbody rbCamera;

    public Boolean declenchement;

    // Start is called before the first frame update
    void Start()
    {
       corps =  GameObject.Find("corps");
       rbCamera = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(corps.transform);
        if (declenchement)
        {
            rbCamera.AddForce(corps.transform.position - gameObject.transform.position);
            rbCamera.AddForce(-rbCamera.velocity * 0.8f);
        }

    }
}
