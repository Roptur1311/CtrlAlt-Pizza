using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oeuf : MonoBehaviour
{
    private bool rhythmIsDecided;
    private bool eggIsCracked;
    private bool firstButtonHit;
    private bool secondButtonHit;
    private bool goToSecondTimer;
    private int hitCount = 0;
    private float timer = 0.0f;
    private float secondTimer = 0.0f;
    private float hitTimeGap = 0.0f;
    private float marginError = 0.5f;

    void Update()
    {

        if (!rhythmIsDecided)
        {
            StartCoroutine(Rhythm());
        }

        if (rhythmIsDecided && !eggIsCracked)
        {
            StartCoroutine(EggCrack());
        }

        if ((!firstButtonHit && secondButtonHit) || (firstButtonHit && !secondButtonHit))
        {
            timer += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.T) && rhythmIsDecided)
        {
            Debug.Log(hitTimeGap);
        }

        if (goToSecondTimer == true)
        {
            secondTimer += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(secondTimer);
        }

        if (hitCount == 10)
        {
            eggIsCracked = true;
            Debug.Log("Egg cracked");
            hitCount = 0;
        }       
    }

    IEnumerator Rhythm()
    {

        if (Input.GetKeyDown(KeyCode.P) && !firstButtonHit && !secondButtonHit)
        {
            Debug.Log("First button hit");
            firstButtonHit = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && firstButtonHit)
        {
            hitTimeGap = timer;
            Debug.Log("Second button hit");
            hitCount += 1;
            rhythmIsDecided = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && !firstButtonHit && !secondButtonHit)
        {
            Debug.Log("Second button hit");
            secondButtonHit = true;
        }

        if (Input.GetKeyDown(KeyCode.P) && secondButtonHit)
        {
            hitTimeGap = timer;
            Debug.Log("First button hit");
            hitCount += 1;
            rhythmIsDecided = true;
        }      

        yield return null;

    }

    IEnumerator EggCrack()
    {
        if (Input.GetKeyDown(KeyCode.P) && firstButtonHit && !secondButtonHit)
        {
            Debug.Log("First button hit");
            goToSecondTimer = true;
            firstButtonHit = false;
            secondButtonHit = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && secondButtonHit && !firstButtonHit)
        {
            Debug.Log("Second button hit");
            goToSecondTimer = true;
            firstButtonHit = true;
            secondButtonHit = false;
        }



        yield return null;
    }
}