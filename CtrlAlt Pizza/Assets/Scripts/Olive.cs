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

        public GameObject ChorizoAnim;
        public GameObject Olive1;
        public GameObject Olive2;
        public GameObject Olive3;
        public GameObject Olive4;
        public GameObject Olive5;
        public GameObject Olive6;
        public GameObject Olive7;
        public GameObject Olive8;
        public GameObject Olive9;
        public GameObject Olive10;

        void Start()
        {
            Olive1.SetActive(false);
            Olive2.SetActive(false);
            Olive3.SetActive(false);
            Olive4.SetActive(false);
            Olive5.SetActive(false);
            Olive6.SetActive(false);
            Olive7.SetActive(false);
            Olive8.SetActive(false);
            Olive9.SetActive(false);
            Olive10.SetActive(false);
        }
        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true && cheese.cheeseDone == true && chorizo.chorizoDone == true)
            {
                if (Input.GetKeyDown(KeyCode.O) && !olivePitted)
                {
                    Debug.Log("Olive touchée");
                    hitCount += 1;
                }

                if (hitCount == 1 && !olivePitted)
                {
                    ChorizoAnim.SetActive(false);
                    Olive1.SetActive(true);
                }

                if (hitCount == 2 && !olivePitted)
                {
                    Olive1.SetActive(false);
                    Olive2.SetActive(true);
                }

                if (hitCount == 3 && !olivePitted)
                {
                    Olive2.SetActive(false);
                    Olive3.SetActive(true);
                }

                if (hitCount == 4 && !olivePitted)
                {
                    Olive3.SetActive(false);
                    Olive4.SetActive(true);
                }

                if (hitCount == 5 && !olivePitted)
                {
                    Olive4.SetActive(false);
                    Olive5.SetActive(true);
                }

                if (hitCount == 6 && !olivePitted)
                {
                    Olive5.SetActive(false);
                    Olive6.SetActive(true);
                }

                if (hitCount == 7 && !olivePitted)
                {
                    Olive6.SetActive(false);
                    Olive7.SetActive(true);
                }

                if (hitCount == 8 && !olivePitted)
                {
                    Olive7.SetActive(false);
                    Olive8.SetActive(true);
                }

                if (hitCount == 9 && !olivePitted)
                {
                    Olive8.SetActive(false);
                    Olive9.SetActive(true);
                }

                if (hitCount == 10 && !olivePitted)
                {
                    Olive9.SetActive(false);
                    Olive10.SetActive(true);

                    Debug.Log("L'olive est dénoyautée");
                    hitCount = 0;
                    olivePitted = true;
                }
            }
        }
    }
}
