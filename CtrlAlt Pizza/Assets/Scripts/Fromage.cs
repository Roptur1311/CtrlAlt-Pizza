using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fromage : MonoBehaviour
{
    private bool top;
    private int topCounter;
    private bool bottom;
    private int bottomCounter;

    void Start()
    {
        top = true;
        bottom = true;

        topCounter = 0;
        bottomCounter = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && bottom == true)
        {
            top = true;
            bottom = false;

            topCounter = topCounter + 1;

            Debug.Log("topCounter : " + topCounter);
        }

        if (Input.GetKeyDown(KeyCode.Y) && top == true)
        {
            bottom = true;
            top = false;

            bottomCounter = bottomCounter + 1;

            Debug.Log("bottomCounter : " + bottomCounter);
        }

        if (topCounter == 10 && bottomCounter == 10)/*valeur provisoire*/
        {
            Debug.Log("Fromage ajouté");
        }
    }
}
