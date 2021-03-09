using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider bc;
    public CameraMouvement scriptCamera;
    private int width, height;
    private Rect rect;
    private GUIStyle labelStyle;
    public static string currentTime;
    private string score;

    
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

            bc.material.dynamicFriction = 0.7f;
            
           


            // On diminue la friction si l'user appuye sur espace = propulsion
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bc.material.dynamicFriction = 0.0f;
            rb.AddForce(transform.forward * 2000.0f);
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
    
    

    void Awake()
    {
        width = Screen.width;
        height = Screen.height;
        rect = new Rect(10, 10, width - 20, height - 20);
    }

    void OnGUI()
    {

        labelStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        labelStyle.alignment = TextAnchor.UpperCenter;

        labelStyle.fontSize = 12 * (width / 200);
        
        // Obtain the current time.
        currentTime = Time.time.ToString("f6");
        GameObject.Find("ski1").GetComponent<reaction>().setScore(currentTime);
       
        currentTime = "Temps écoulé : " + currentTime + " secondes";

        // Display the current time.
        if (!reaction.activation)
        {
            GUI.Label(rect, currentTime, labelStyle);
        }

    }
}
