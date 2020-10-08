using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class Feu : MonoBehaviour
    {
        public bool feu;
        private bool allumette;
        private bool bois;

        void Start()
        {
            feu = false;
            allumette = false;
            bois = false;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S) && feu == false)
            {
                bois = true;

                Debug.Log(" Le bois est déposé");
            }

            if (Input.GetKeyDown(KeyCode.D) && feu == false)
            {
                allumette = true;

                Debug.Log(" Allumette allumée");
            }

            if (allumette== true && bois == true && feu == false)
            {
                feu = true;
                Debug.Log("Le feu est allumé");
            }
        }
    }
}
