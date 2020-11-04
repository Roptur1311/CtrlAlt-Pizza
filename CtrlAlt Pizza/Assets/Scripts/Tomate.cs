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
        public AudioSource tomatoSound1;
        public AudioSource tomatoSound2;
        public AudioSource tomatoSoundSync;
        public AudioSource tomatoSoundDone;

        private float timer = 0.0f;


        void Start()
        {
            tomatoDone = false;
            p1 = false;
            p2 = false;
            playerCount = 0;

            Debug.Log("La partie est lancée");
        }


        void Update()
        {
            if (dough.doughDone == true)
            {
                if (Input.GetKeyDown(KeyCode.E) && p2 == false && tomatoDone == false)
                {

                    p1 = true;
                    Debug.Log("E pressed");
                    tomatoSound1.Play();
                }
                if (timer <= 1.5f && Input.GetKeyDown(KeyCode.R) && p1 == true && p2 == false && tomatoDone == false)
                {
                    Debug.Log(timer);
                    Debug.Log("R pressed 2");
                    tomatoSound2.Play();

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
                    tomatoSound2.Play();
                }
                if (timer <= 1.5f && Input.GetKeyDown(KeyCode.E) && p2 == true && p1 == false && tomatoDone == false)
                {
                    Debug.Log(timer);
                    Debug.Log("E pressed 2");
                    tomatoSound1.Play();

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
                    tomatoSoundSync.Play();
                }

                if (playerCount == 10 && tomatoDone == false)
                {
                    Debug.Log("Bien joué, ce sont de belles tomates");
                    tomatoDone = true;
                    tomatoSoundDone.Play();
                }
            }
        }
    }
}
