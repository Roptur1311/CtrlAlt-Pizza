using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class Chorizo : MonoBehaviour
    {
        private bool left;
        private int leftCounter;
        private bool right;
        private int rightCounter;
        public Pate dough;
        public Tomate tomato;
        public Fromage cheese;

        public GameObject FromageAnim;
        public GameObject Chorizo1;
        public GameObject Chorizo2;
        public GameObject Chorizo3;
        public GameObject Chorizo4;
        public GameObject Chorizo5;
        public GameObject Chorizo6;
        public GameObject Chorizo7;
        public GameObject Chorizo8;
        public GameObject Chorizo9;
        public GameObject Chorizo10;

        public bool chorizoDone;

        void Start()
        {
            left = true;
            right = true;

            leftCounter = 0;
            rightCounter = 0;


            Chorizo1.SetActive(false);
            Chorizo2.SetActive(false);
            Chorizo3.SetActive(false);
            Chorizo4.SetActive(false);
            Chorizo5.SetActive(false);
            Chorizo6.SetActive(false);
            Chorizo7.SetActive(false);
            Chorizo8.SetActive(false);
            Chorizo9.SetActive(false);
            Chorizo10.SetActive(false);

            chorizoDone = false;
        }

        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true && cheese.cheeseDone == true)
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

                if (leftCounter >= 1 && rightCounter >= 1 && chorizoDone == false)/*valeur provisoire*/
                {
                    FromageAnim.SetActive(false);
                    Chorizo1.SetActive(true);
                }

                if (leftCounter >= 2 && rightCounter >= 2 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo1.SetActive(false);
                    Chorizo2.SetActive(true);
                }

                if (leftCounter >= 3 && rightCounter >= 3 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo2.SetActive(false);
                    Chorizo3.SetActive(true);
                }

                if (leftCounter >= 4 && rightCounter >= 4 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo3.SetActive(false);
                    Chorizo4.SetActive(true);
                }

                if (leftCounter >= 5 && rightCounter >= 5 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo4.SetActive(false);
                    Chorizo5.SetActive(true);
                }

                if (leftCounter >= 6 && rightCounter >= 6 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo5.SetActive(false);
                    Chorizo6.SetActive(true);
                }

                if (leftCounter >= 7 && rightCounter >= 7 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo6.SetActive(false);
                    Chorizo7.SetActive(true);
                }

                if (leftCounter >= 8 && rightCounter >= 8 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo7.SetActive(false);
                    Chorizo8.SetActive(true);
                }

                if (leftCounter >= 9 && rightCounter >= 9 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo8.SetActive(false);
                    Chorizo9.SetActive(true);
                }

                if (leftCounter >= 10 && rightCounter >= 10 && chorizoDone == false)/*valeur provisoire*/
                {
                    Chorizo9.SetActive(false);
                    Chorizo10.SetActive(true);

                    Debug.Log("Chorizo ajouté");
                    chorizoDone = true;
                }
            }
        }
    }
}
