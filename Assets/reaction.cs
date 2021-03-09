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
    private int width, height;
    private Rect rect;
    private GUIStyle labelStyle;
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
            width = Screen.width;
            height = Screen.height;
            rect = new Rect(10, 10, width - 20, height - 20);
            labelStyle = new GUIStyle(GUI.skin.GetStyle("label"));
            labelStyle.alignment = TextAnchor.MiddleCenter;

            labelStyle.fontSize = 12 * (width / 200);
            
            
            GUI.Label(rect, score, labelStyle);
           
        }
        
        
    }

    public void setScore(string score)
    {
        if (!activation)
        {
            this.score = "Score :"+ score+ " secondes";
        }
    }
}
