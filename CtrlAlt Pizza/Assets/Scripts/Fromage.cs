using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using minigame;
using System.Security.Cryptography.X509Certificates;

namespace minigame
{
    public class Fromage : MonoBehaviour
    {
        private bool top;
        private int topCounter;
        private bool bottom;
        private int bottomCounter;
        public Pate dough;
        public Tomate tomato;

        public GameObject TomateAnim;
        public GameObject Fromage1;
        public GameObject Fromage2;
        public GameObject Fromage3;
        public GameObject Fromage4;
        public GameObject Fromage5;
        public GameObject Fromage6;
        public GameObject Fromage7;
        public GameObject Fromage8;
        public GameObject Fromage9;
        public GameObject Fromage10;
        
        public AudioSource cheeseUpSound;
        public AudioSource cheeseDownSound;
        public AudioSource cheeseDoneSound;

        public bool cheeseDone;

        void Start()
        {
            top = true;
            bottom = true;

            topCounter = 0;
            bottomCounter = 0;

            Fromage1.SetActive(false);
            Fromage2.SetActive(false);
            Fromage3.SetActive(false);
            Fromage4.SetActive(false);
            Fromage5.SetActive(false);
            Fromage6.SetActive(false);
            Fromage7.SetActive(false);
            Fromage8.SetActive(false);
            Fromage9.SetActive(false);
            Fromage10.SetActive(false);

            cheeseDone = false;
        }

        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true)
            {
                if (Input.GetKeyDown(KeyCode.T) && bottom == true && cheeseDone == false)
                {
                    top = true;
                    bottom = false;

                    topCounter = topCounter + 1;

                    Debug.Log("topCounter : " + topCounter);
                    cheeseUpSound.Play();
                }

                if (Input.GetKeyDown(KeyCode.Y) && top == true && cheeseDone == false)
                {
                    bottom = true;
                    top = false;

                    bottomCounter = bottomCounter + 1;

                    Debug.Log("bottomCounter : " + bottomCounter);
                    cheeseDownSound.Play();
                }

                if (topCounter >= 1 && bottomCounter >= 1 && cheeseDone == false)/*valeur provisoire*/
                {
                    TomateAnim.SetActive(false);
                    Fromage1.SetActive(true);
                }

                if (topCounter >= 2 && bottomCounter >= 2 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage1.SetActive(false);
                    Fromage2.SetActive(true);
                }

                if (topCounter >= 3 && bottomCounter >= 3 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage2.SetActive(false);
                    Fromage3.SetActive(true);
                }

                if (topCounter >= 4 && bottomCounter >= 4 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage3.SetActive(false);
                    Fromage4.SetActive(true);
                }

                if (topCounter >= 5 && bottomCounter >= 5 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage4.SetActive(false);
                    Fromage5.SetActive(true);
                }

                if (topCounter >= 6 && bottomCounter >= 6 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage5.SetActive(false);
                    Fromage6.SetActive(true);
                }

                if (topCounter >= 7 && bottomCounter >= 7 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage6.SetActive(false);
                    Fromage7.SetActive(true);
                }

                if (topCounter >= 8 && bottomCounter >= 8 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage7.SetActive(false);
                    Fromage8.SetActive(true);
                }

                if (topCounter >= 9 && bottomCounter >= 9 && cheeseDone == false)/*valeur provisoire*/
                {
                    Fromage8.SetActive(false);
                    Fromage9.SetActive(true);
                }


                if (topCounter >= 10 && bottomCounter >= 10 && cheeseDone == false)/*valeur provisoire*/
                {

                    Fromage9.SetActive(false);
                    Fromage10.SetActive(true);
                    Debug.Log("Fromage ajouté");
                    cheeseDone = true;
                    cheeseDoneSound.Play();
                }
            }
        }
    }
}
