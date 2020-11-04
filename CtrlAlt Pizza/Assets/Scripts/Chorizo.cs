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
        public AudioSource chorizoLeftSound;
        public AudioSource chorizoRightSound;
        public AudioSource chorizoDoneSound;

        public bool chorizoDone;

        void Start()
        {
            left = true;
            right = true;

            leftCounter = 0;
            rightCounter = 0;

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
                    chorizoLeftSound.Play();
                }

                if (Input.GetKeyDown(KeyCode.I) && left == true && chorizoDone == false)
                {
                    right = true;
                    left = false;

                    rightCounter = rightCounter + 1;

                    Debug.Log("rightCounter : " + rightCounter);
                    chorizoRightSound.Play();
                }

                if (leftCounter >= 10 && rightCounter >= 10 && chorizoDone == false)/*valeur provisoire*/
                {
                    Debug.Log("Chorizo ajouté");
                    chorizoDone = true;
                    chorizoDoneSound.Play();
                }
            }
        }
    }
}
