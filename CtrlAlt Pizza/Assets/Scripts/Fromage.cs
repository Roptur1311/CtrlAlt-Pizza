using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        public bool cheeseDone;

        void Start()
        {
            top = true;
            bottom = true;

            topCounter = 0;
            bottomCounter = 0;

            cheeseDone = false;
        }

        void Update()
        {
            if (dough.doughDone == false && tomato.tomatoDone == true)
            {
                if (Input.GetKeyDown(KeyCode.T) && bottom == true && cheeseDone == false)
                {
                    top = true;
                    bottom = false;

                    topCounter = topCounter + 1;

                    Debug.Log("topCounter : " + topCounter);
                }

                if (Input.GetKeyDown(KeyCode.Y) && top == true && cheeseDone == false)
                {
                    bottom = true;
                    top = false;

                    bottomCounter = bottomCounter + 1;

                    Debug.Log("bottomCounter : " + bottomCounter);
                }

                if (topCounter == 10 && bottomCounter == 10 && cheeseDone == false)/*valeur provisoire*/
                {
                    Debug.Log("Fromage ajouté");
                    cheeseDone = true;
                }
            }
        }
    }
}
