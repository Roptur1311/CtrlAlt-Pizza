using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oeuf : MonoBehaviour
{
    private bool rhythmIsDecided;
    private bool eggIsCracked;
    private bool firstButtonHit;
    private bool secondButtonHit;
    private int hitCount = 0;
    private float timer = 0.0f;
    private float hitTimeGap = 0.0f;

    void Start()
    {        
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !firstButtonHit && !secondButtonHit && !eggIsCracked && !rhythmIsDecided)
        {          
            Debug.Log("First button hit");
            firstButtonHit = true;            
        }       

        if (Input.GetKeyDown(KeyCode.Q) && firstButtonHit && !eggIsCracked && !rhythmIsDecided)
        {
            hitTimeGap = timer;
            Debug.Log("Second button hit");
            hitCount += 1;
            rhythmIsDecided = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && !firstButtonHit && !secondButtonHit && !eggIsCracked && !rhythmIsDecided)
        {
            Debug.Log("Second button hit");
            secondButtonHit = true;           
        }

        if (Input.GetKeyDown(KeyCode.P) && secondButtonHit && !eggIsCracked && !rhythmIsDecided)
        {
            hitTimeGap = timer;
            Debug.Log("First button hit");
            hitCount += 1;
            rhythmIsDecided = true;
        }

        if (firstButtonHit || secondButtonHit)
        {
            timer += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.T) && rhythmIsDecided)
        {
            Debug.Log(hitTimeGap);
        }

        /*if (!rhythmIsDecided)
        {
            StartCoroutine(Rhythm());
        }*/

        if (hitCount == 10)
        {
            eggIsCracked = true;
            Debug.Log("Egg cracked");
            hitCount = 0;
        }       
    }

    IEnumerator Rhythm()
    {      
        if (Input.GetKeyDown(KeyCode.P) && !firstButtonHit && !eggIsCracked)
        {
            timer += Time.deltaTime;
            Debug.Log("First button hit");
            firstButtonHit = true;
            secondButtonHit = false;

            if (Input.GetKeyDown(KeyCode.Q) && !secondButtonHit && !eggIsCracked)
            {
                hitTimeGap = timer;
                Debug.Log("Second button hit");
                secondButtonHit = true;
                firstButtonHit = false;
                rhythmIsDecided = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && !secondButtonHit && !eggIsCracked)
        {
            timer += Time.deltaTime;
            Debug.Log("Second button hit");
            secondButtonHit = true;
            firstButtonHit = false;
            if (Input.GetKeyDown(KeyCode.P) && !secondButtonHit && !eggIsCracked)
            {
                hitTimeGap = timer;
                Debug.Log("First button hit");
                firstButtonHit = true;
                secondButtonHit = false;
                rhythmIsDecided = true;
            }
        }               
        yield return null;
    }
}