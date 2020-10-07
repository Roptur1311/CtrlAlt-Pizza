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
        if (Input.GetKeyDown(KeyCode.E) && fin == false)
        {
            timer = 0.0f;
            p1 = true;
            Debug.Log("E pressed");
            timer += Time.deltaTime;
            Debug.Log(timer);

            
            Debug.Log("En attente de p2");

            if (timer <= 1.5f && Input.GetKeyDown(KeyCode.R) && p1 && fin == false)
            {
                Debug.Log(timer);
                Debug.Log("R pressed");

                p2 = true;
                timer = 0.0f;
            }
        }

       


        if (Input.GetKeyDown(KeyCode.R) && fin == false)
        {
            timer = 0.0f;
            p2 = true;
            Debug.Log("R pressed");
            timer += Time.deltaTime;
            Debug.Log(timer);


            Debug.Log("En attente de p1");

            if (timer <= 1.5f && Input.GetKeyDown(KeyCode.E) && p2 && fin == false)
            {
                Debug.Log(timer);
                Debug.Log("E pressed");

                p1 = true;
                timer = 0.0f;
            }
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
