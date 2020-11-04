using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

namespace minigame
{
    public class Pate : MonoBehaviour
    {
        private bool forward;
        private int forwardCounter;
        private bool back;
        private int backCounter;
        public AudioSource pateSound;
        public AudioSource winSound;

        public GameObject Pate1;
        public GameObject Pate2;
        public GameObject Pate3;
        public GameObject Pate4;
        public GameObject Pate5;
        public GameObject Pate6;
        public GameObject Pate7;
        public GameObject Pate8;
        public GameObject Pate9;
        public GameObject Pate10;
        public bool doughDone;

        void Start()
        {
            forward = true;
            back = true;

            forwardCounter = 0;
            backCounter = 0;

            doughDone = false;

            Pate1.SetActive(false);
            Pate2.SetActive(false);
            Pate3.SetActive(false);
            Pate4.SetActive(false);
            Pate5.SetActive(false);
            Pate6.SetActive(false);
            Pate7.SetActive(false);
            Pate8.SetActive(false);
            Pate9.SetActive(false);
            Pate10.SetActive(false);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A) && back == true && doughDone == false)
            {
                forward = true;
                back = false;

                forwardCounter = forwardCounter + 1;

                Debug.Log("forwardCounter : " + forwardCounter);
                pateSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.Z) && forward == true && doughDone == false)
            {
                back = true;
                forward = false;

                backCounter = backCounter + 1;

                Debug.Log("backCounter : " + backCounter);
                pateSound.Play();
            }


            if (forwardCounter >= 1 && backCounter >= 1 && doughDone == false)/*valeur provisoire*/
            {
                Pate1.SetActive(true);
            }

            if (forwardCounter >= 2 && backCounter >= 2 && doughDone == false)/*valeur provisoire*/
            {
                Pate1.SetActive(false);
                Pate2.SetActive(true);
            }

            if (forwardCounter >= 3 && backCounter >= 3 && doughDone == false)/*valeur provisoire*/
            {
                Pate2.SetActive(false);
                Pate3.SetActive(true);
            }

            if (forwardCounter >= 4 && backCounter >= 4 && doughDone == false)/*valeur provisoire*/
            {
                Pate3.SetActive(false);
                Pate4.SetActive(true);
            }

            if (forwardCounter >= 5 && backCounter >= 5 && doughDone == false)/*valeur provisoire*/
            {
                Pate4.SetActive(false);
                Pate5.SetActive(true);
            }

            if (forwardCounter >= 6 && backCounter >= 6 && doughDone == false)/*valeur provisoire*/
            {
                Pate5.SetActive(false);
                Pate6.SetActive(true);
            }

            if (forwardCounter >= 7 && backCounter >= 7 && doughDone == false)/*valeur provisoire*/
            {
                Pate6.SetActive(false);
                Pate7.SetActive(true);
            }

            if (forwardCounter >= 8 && backCounter >= 8 && doughDone == false)/*valeur provisoire*/
            {
                Pate7.SetActive(false);
                Pate8.SetActive(true);
            }

            if (forwardCounter >= 9 && backCounter >= 9 && doughDone == false)/*valeur provisoire*/
            {
                Pate8.SetActive(false);
                Pate9.SetActive(true);
            }


            if (forwardCounter >= 10 && backCounter >= 10 && doughDone == false)/*valeur provisoire*/
            {
                Debug.Log("Pâte étalée");
                Pate9.SetActive(false);
                Pate10.SetActive(true);
                doughDone = true;
                winSound.Play();
            }
        }
    }
}
