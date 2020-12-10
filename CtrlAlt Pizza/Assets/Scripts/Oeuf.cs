using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        private int failHitCount = 0;
        private float timer = 0.0f;
        private float secondTimer = 0.0f;
        private float hitTimeGap = 0.0f;
        private float marginError = 0.8f;

        public Pate dough;
        public Tomate tomato;
        public Fromage cheese;
        public Chorizo chorizo;
        public Olive olive;
        public AudioSource eggHitSound;
        public AudioSource eggSyncSound;
        public AudioSource eggCrackSound;

        public GameObject LastOlive;
        public GameObject OeufAnim1;
        public GameObject OeufAnim2;
        public GameObject OeufAnim3;
        public GameObject OeufAnim4;
        public GameObject OeufAnim5;
        public GameObject OeufAnim6;
        public GameObject OeufAnim7;
        public GameObject OeufAnim8;
        public GameObject OeufAnim9;
        public GameObject OeufAnim10;

        /*public LeaderBoardObject leaderbordScript;

        public GameObject tableau;


        public GameObject globalTimer;
        public float finalTime;
        public AudioSource matchSound;
        public AudioSource fireSound;

        public GameObject timer;
        public GameObject RestartButton;*/


        void Start()
        {
            OeufAnim1.SetActive(false);
            OeufAnim2.SetActive(false);
            OeufAnim3.SetActive(false);
            OeufAnim4.SetActive(false);
            OeufAnim5.SetActive(false);
            OeufAnim6.SetActive(false);
            OeufAnim7.SetActive(false);
            OeufAnim8.SetActive(false);
            OeufAnim9.SetActive(false);
            OeufAnim10.SetActive(false);

            /*tableau.SetActive(false);

            RestartButton.SetActive(false);*/
            
        }
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

                if (failHitCount == 3)
                {
                    failHitCount = 0;
                    hitTimeGap = 0;
                    rhythmIsDecided = false;
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

                if (hitCount == 1)
                {
                    LastOlive.SetActive(false);
                    OeufAnim1.SetActive(true);
                }

                if (hitCount == 2)
                {
                    OeufAnim1.SetActive(false);
                    OeufAnim2.SetActive(true);
                }

                if (hitCount == 3)
                {
                    OeufAnim2.SetActive(false);
                    OeufAnim3.SetActive(true);
                }

                if (hitCount == 4)
                {
                    OeufAnim3.SetActive(false);
                    OeufAnim4.SetActive(true);
                }

                if (hitCount == 5)
                {
                    OeufAnim4.SetActive(false);
                    OeufAnim5.SetActive(true);
                }

                if (hitCount == 6)
                {
                    OeufAnim5.SetActive(false);
                    OeufAnim6.SetActive(true);
                }

                if (hitCount == 7)
                {
                    OeufAnim6.SetActive(false);
                    OeufAnim7.SetActive(true);
                }

                if (hitCount == 8)
                {
                    OeufAnim7.SetActive(false);
                    OeufAnim8.SetActive(true);
                }

                if (hitCount == 9)
                {
                    OeufAnim8.SetActive(false);
                    OeufAnim9.SetActive(true);
                }

                if (hitCount == 10)
                {
                    OeufAnim9.SetActive(false);
                    OeufAnim10.SetActive(true);

                    eggIsCracked = true;
                    Debug.Log("Egg cracked");
                    hitCount = 0;
                    eggCrackSound.Play();

                    /*finalTime = globalTimer.GetComponent<Timer>().timer;
                    Debug.Log(finalTime);

                    RestartButton.SetActive(true);

                    tableau.SetActive(true);

                    timer.SetActive(false);

                    leaderbordScript.LeaderBoardUpdate();*/
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
                failHitCount++;
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
                failHitCount++;
                eggHitSound.Play();
            }

            yield return null;
        }

        /*public void RestartGame()
        {
            dough.doughDone = false;
            tomato.tomatoDone = false;
            cheese.cheeseDone = false;
            chorizo.chorizoDone = false;
            olive.olivePitted = false;
            eggIsCracked = false;

            SceneManager.LoadScene("StartScene");
        }*/
                }
            }