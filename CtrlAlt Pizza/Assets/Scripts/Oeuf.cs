using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oeuf : MonoBehaviour
{
    private bool eggIsCracked;
    private bool firstButtonHit;
    private bool secondButtonHit;
    private int hitCount = 0;
    private int hitTimeGap;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !firstButtonHit && !eggIsCracked)
        {
            Debug.Log("First button hit");
            firstButtonHit = true;
            secondButtonHit = false;
            hitCount += 1;
        }
        if (Input.GetKeyDown(KeyCode.Q) && !secondButtonHit && !eggIsCracked)
        {
            Debug.Log("Second button hit");
            secondButtonHit = true;
            firstButtonHit = false;
            hitCount += 1;
        }
        if (hitCount == 10)
        {
            eggIsCracked = true;
            Debug.Log("Egg cracked");
            hitCount = 0;
        }
    }
}
