using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomate : MonoBehaviour
{
    private bool p1;
    private bool p2;
    private bool fin;
    private int playerCount;

    private float timer = 0.0f;
  

    void Start()
    {
        fin = false;
        p1 = false;
        p2 = false;
        playerCount = 0;
        
        Debug.Log("La partie est lancé");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && p2 == false && fin == false)
        {
            
            p1 = true;
            Debug.Log("E pressed");            
        }
        if (timer <= 1.5f && Input.GetKeyDown(KeyCode.R) && p1 == true  && p2 == false && fin == false)
        {
            Debug.Log(timer);
            Debug.Log("R pressed 2");

            p2 = true;
            
        }
        else if (timer > 1.5f && p1 == true)
        {
            p1 = false;
            timer = 0.0f;
            Debug.Log("putain ca marche pas !");
        }




        if (Input.GetKeyDown(KeyCode.R) && p1 == false && fin == false)
        {
            
            p2 = true;
            Debug.Log("R pressed");                       
        }
        if (timer <= 1.5f && Input.GetKeyDown(KeyCode.E) && p2 == true && p1 == false && fin == false)
        {
            Debug.Log(timer);
            Debug.Log("E pressed 2");

            p1 = true;
            
        }
        else if (timer > 1.5f && p2 == true)
        {
            p2 = false;
            timer = 0.0f;
            Debug.Log("putain ca marche pas !");
        }

        if (p1 == true || p2 == true)
        {
            timer += Time.deltaTime;
        }   
        
        if (p1 == true && p2 == true && fin == false)
        {
            playerCount += 1;
            Debug.Log("+1 Tomate");
            p1 = false;
            p2 = false;
        }

        if (playerCount == 10 && fin == false)
        {
            Debug.Log("Bien joué, ce sont de belles tomates");
            fin = true;
        }
    }
}
