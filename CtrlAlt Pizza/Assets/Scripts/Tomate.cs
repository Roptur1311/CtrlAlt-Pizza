using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using minigame;

namespace minigame
{
    public class Tomate : MonoBehaviour
    {
        private bool p1;
        private bool p2;
        public bool tomatoDone;
        private int playerCount;
        public Pate dough;
        public AudioSource tomato1Sound;
        public AudioSource tomato2Sound;
        public AudioSource tomatoSyncSound;
        public AudioSource tomatoDoneSound;

        public GameObject Pate10;
        public GameObject Tomate1;
        public GameObject Tomate2;
        public GameObject Tomate3;
        public GameObject Tomate4;
        public GameObject Tomate5;
        public GameObject Tomate6;
        public GameObject Tomate7;
        public GameObject Tomate8;
        public GameObject Tomate9;
        public GameObject Tomate10;
        private float timer = 0.0f;


        void Start()
        {
            tomatoDone = false;
            p1 = false;
            p2 = false;
            playerCount = 0;

            Tomate1.SetActive(false);
            Tomate2.SetActive(false);
            Tomate3.SetActive(false);
            Tomate4.SetActive(false);
            Tomate5.SetActive(false);
            Tomate6.SetActive(false);
            Tomate7.SetActive(false);
            Tomate8.SetActive(false);
            Tomate9.SetActive(false);
            Tomate10.SetActive(false);
            Debug.Log("La partie est lancée");
        }


        void Update()
        {
            if (dough.doughDone == true)
            {
                if (Input.GetKeyDown(KeyCode.E) && p2 == false && tomatoDone == false)
                {

                    p1 = true;

                    //Debug.Log("E pressed");
                    tomato1Sound.Play();
                }
                if (timer <= 1.5f && Input.GetKeyDown(KeyCode.R) && p1 == true && p2 == false && tomatoDone == false)
                {
                    //Debug.Log(timer);
                    //Debug.Log("R pressed 2");
                    tomato2Sound.Play();

                    p2 = true;

                }
                else if (timer > 1.5f && p1 == true)
                {
                    p1 = false;
                    timer = 0.0f;
                }




                if (Input.GetKeyDown(KeyCode.R) && p1 == false && tomatoDone == false)
                {

                    p2 = true;
                    Debug.Log("R pressed");
                }
                if (timer <= 1.5f && Input.GetKeyDown(KeyCode.E) && p2 == true && p1 == false && tomatoDone == false)
                {
                    Debug.Log(timer);
                    Debug.Log("E pressed 2");

                    p1 = true;

                }
                else if (timer > 1.5f && p2 == true)
                {
                    p2 = false;
                    timer = 0.0f;
                }

                if (p1 == true || p2 == true)
                {
                    timer += Time.deltaTime;
                }

                if (p1 == true && p2 == true && tomatoDone == false)
                {
                    playerCount += 1;
                    Debug.Log("+1 Tomate");
                    p1 = false;
                    p2 = false;
                    tomatoSyncSound.Play();
                }


                if (playerCount == 1 && tomatoDone == false)
                {
                    Pate10.SetActive(false);
                    Tomate1.SetActive(true);
                }

                if (playerCount == 2 && tomatoDone == false)
                {
                    Tomate1.SetActive(false);
                    Tomate2.SetActive(true);
                }

                if (playerCount == 3 && tomatoDone == false)
                {
                    Tomate2.SetActive(false);
                    Tomate3.SetActive(true);
                }

                if (playerCount == 4 && tomatoDone == false)
                {
                    Tomate3.SetActive(false);
                    Tomate4.SetActive(true);
                }

                if (playerCount == 5 && tomatoDone == false)
                {
                    Tomate4.SetActive(false);
                    Tomate5.SetActive(true);
                }

                if (playerCount == 6 && tomatoDone == false)
                {
                    Tomate5.SetActive(false);
                    Tomate6.SetActive(true);
                }

                if (playerCount == 7 && tomatoDone == false)
                {
                    Tomate6.SetActive(false);
                    Tomate7.SetActive(true);
                }

                if (playerCount == 8 && tomatoDone == false)
                {
                    Tomate7.SetActive(false);
                    Tomate8.SetActive(true);
                }

                if (playerCount == 9 && tomatoDone == false)
                {
                    Tomate8.SetActive(false);
                    Tomate9.SetActive(true);
                }

                if (playerCount == 10 && tomatoDone == false)
                {
                    Tomate9.SetActive(false);
                    Tomate10.SetActive(true);

                    Debug.Log("Bien joué, ce sont de belles tomates");
                    tomatoDone = true;
                    tomatoDoneSound.Play();
                }
            }
        }
    }
}
