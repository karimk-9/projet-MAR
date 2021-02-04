using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reaction : MonoBehaviour
{
    public GameObject camera;
    public GameObject piste;
    public static Boolean activation;
    private string score;
    private void OnCollisionEnter(Collision collision)
    {
        camera = GameObject.Find("Main Camera");
        piste = GameObject.Find("Piste");
        //score = GameObject.Find("ski1").GetComponent<Mouvements>().
        switch (collision.gameObject.tag)
        {
            case "Finish":
            {
                print("collision");
                activation = true;
                
          
                
                break;
            } case "MurGauche":
            {
                this.gameObject.SetActive(false);
                print("collision");
                break;
            }
        }
        
    }

    public void OnGUI()
    {
        if (activation)
        {
            GUI.Label(new Rect(10, 10, 100, 20), score);
        }
        
        
    }

    public void setScore(string score)
    {
        if (!activation)
        {
            this.score = score;
        }
    }
}
