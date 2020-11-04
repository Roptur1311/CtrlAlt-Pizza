using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class Oeuf : MonoBehaviour
    {
        private bool rhythmIsDecided;
        public bool eggIsCracked;
        private bool firstButtonHit;
        private bool secondButtonHit;
        private bool goToSecondTimer;
        private int hitCount = 0;
        private float timer = 0.0f;
        private float secondTimer = 0.0f;
        private float hitTimeGap = 0.0f;
        private float marginError = 0.5f;

        public Pate dough;
        public Tomate tomato;
        public Fromage cheese;
        public Chorizo chorizo;
        public Olive olive;
        public AudioSource eggHitSound;
        public AudioSource eggSyncSound;
        public AudioSource eggCrackSound;

        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true && cheese.cheeseDone == true && chorizo.chorizoDone == true && olive.olivePitted == true)
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

                /*if (Input.GetKeyDown(KeyCode.T) && rhythmIsDecided)
                {
                    Debug.Log(hitTimeGap);
                }*/

                if (goToSecondTimer == true)
                {
                    secondTimer += Time.deltaTime;
                }

                /*if (Input.GetKeyDown(KeyCode.A))
                {
                    Debug.Log(secondTimer);
                }*/

                if (hitCount == 10)
                {
                    eggIsCracked = true;
                    Debug.Log("Egg cracked");
                    hitCount = 0;
                    eggCrackSound.Play();
                }
            }
        }

        IEnumerator Rhythm()
        {

            if (Input.GetKeyDown(KeyCode.P) && !firstButtonHit && !secondButtonHit)
            {
                Debug.Log("First button hit");
                firstButtonHit = true;
                hitCount += 1;
                eggHitSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.Q) && firstButtonHit)
            {
                hitTimeGap = timer;
                Debug.Log("Second button hit");
                hitCount += 1;
                rhythmIsDecided = true;
                eggHitSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.Q) && !firstButtonHit && !secondButtonHit)
            {
                Debug.Log("Second button hit");
                secondButtonHit = true;
                hitCount += 1;
                eggHitSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.P) && secondButtonHit)
            {
                hitTimeGap = timer;
                Debug.Log("First button hit");
                hitCount += 1;
                rhythmIsDecided = true;
                eggHitSound.Play();
            }

            yield return null;

        }

        IEnumerator EggCrack()
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Q) && !goToSecondTimer)
            {
                goToSecondTimer = true;
                eggSyncSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.P) && firstButtonHit && !secondButtonHit && (secondTimer > (hitTimeGap - marginError) && secondTimer < (hitTimeGap + marginError)))
            {
                Debug.Log("First button hit success");
                firstButtonHit = false;
                secondButtonHit = true;
                secondTimer = 0;
                hitCount += 1;
                eggHitSound.Play();
                eggSyncSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.P) && firstButtonHit && !secondButtonHit && (secondTimer > (hitTimeGap + marginError) || secondTimer < (hitTimeGap - marginError)))
            {
                Debug.Log("First button hit fail");
                firstButtonHit = false;
                secondButtonHit = true;
                secondTimer = 0;
                eggHitSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.Q) && secondButtonHit && !firstButtonHit && (secondTimer > (hitTimeGap - marginError) && secondTimer < (hitTimeGap + marginError)))
            {
                Debug.Log("Second button hit success");
                firstButtonHit = true;
                secondButtonHit = false;
                secondTimer = 0;
                hitCount += 1;
                eggHitSound.Play();
                eggSyncSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.Q) && secondButtonHit && !firstButtonHit && (secondTimer > (hitTimeGap + marginError) || secondTimer < (hitTimeGap - marginError)))
            {
                Debug.Log("Second button hit fail");
                firstButtonHit = true;
                secondButtonHit = false;
                secondTimer = 0;
                eggHitSound.Play();
            }

            yield return null;
        }
    }
}