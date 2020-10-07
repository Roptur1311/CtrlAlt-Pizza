using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pate : MonoBehaviour
{
    private bool forward;
    private int forwardCounter;
    private bool back;
    private int backCounter;

    private bool doughDone;

    void Start()
    {
        forward = true;
        back = true;

        forwardCounter = 0;
        backCounter = 0;

        doughDone = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && back == true && doughDone == false)
        {
            forward = true;
            back = false;

            forwardCounter = forwardCounter + 1;

            Debug.Log("forwardCounter : " + forwardCounter);
        }

        if (Input.GetKeyDown(KeyCode.Z) && forward == true && doughDone == false)
        {
            back = true;
            forward = false;

            backCounter = backCounter + 1;

            Debug.Log("backCounter : " + backCounter);
        }

        if (forwardCounter == 10 && backCounter == 10 && doughDone == false)/*valeur provisoire*/
        {
            Debug.Log("Pâte étalée");
            doughDone = true;
        }
    }
}
