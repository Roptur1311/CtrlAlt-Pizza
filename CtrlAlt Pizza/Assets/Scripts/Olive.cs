using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class Olive : MonoBehaviour
    {
        public bool olivePitted;
        private int hitCount = 0;
        public Pate dough;
        public Tomate tomato;
        public Fromage cheese;
        public Chorizo chorizo;
        public AudioSource oliveTouchSound;
        public AudioSource olivePitSound;

        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true && cheese.cheeseDone == true && chorizo.chorizoDone == true)
            {
                if (Input.GetKeyDown(KeyCode.O) && !olivePitted)
                {
                    Debug.Log("Olive touchée");
                    hitCount += 1;
                    oliveTouchSound.Play();
                }
                if (hitCount == 10 && !olivePitted)
                {
                    Debug.Log("L'olive est dénoyautée");
                    hitCount = 0;
                    olivePitted = true;
                    olivePitSound.Play();
                }
            }
        }
    }
}
