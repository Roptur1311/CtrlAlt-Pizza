using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chorizo : MonoBehaviour
{
    private bool left;
    private int leftCounter;
    private bool right;
    private int rightCounter;

    private bool chorizoDone;

    void Start()
    {
        left = true;
        right = true;

        leftCounter = 0;
        rightCounter = 0;

        chorizoDone = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U) && right == true && chorizoDone == false)
        {
            left = true;
            right = false;

            leftCounter = leftCounter + 1;

            Debug.Log("leftCounter : " + leftCounter);
        }

        if (Input.GetKeyDown(KeyCode.I) && left == true && chorizoDone == false)
        {
            right = true;
            left = false;

            rightCounter = rightCounter + 1;

            Debug.Log("rightCounter : " + rightCounter);
        }

        if (leftCounter == 10 && rightCounter == 10 && chorizoDone == false)/*valeur provisoire*/
        {
            Debug.Log("Chorizo ajouté");
            chorizoDone = true;
        }
    }
}
