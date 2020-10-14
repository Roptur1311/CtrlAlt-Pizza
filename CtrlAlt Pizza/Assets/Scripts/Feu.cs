using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace minigame
{
    public class Feu : MonoBehaviour
    {
        public bool fireDone;
        private bool allumette;
        private bool bois;

        public Pate dough;
        public Tomate tomato;
        public Fromage cheese;
        public Chorizo chorizo;
        public Olive olive;
        public Oeuf egg;

        public GameObject RestartButton;

        public LeaderBoardObject leaderbordScript;


        public GameObject globalTimer;
        public float finalTime;

        void Start()
        {
            fireDone = false;
            allumette = false;
            bois = false;

            RestartButton.SetActive(false);
            
        }

        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true && cheese.cheeseDone == true && chorizo.chorizoDone == true && olive.olivePitted == true && egg.eggIsCracked == true)
            {
                if (Input.GetKeyDown(KeyCode.S) && fireDone == false)
                {
                    bois = true;

                    Debug.Log(" Le bois est déposé");
                }

                if (Input.GetKeyDown(KeyCode.D) && fireDone == false)
                {
                    allumette = true;

                    Debug.Log(" Allumette allumée");
                }

                if (allumette == true && bois == true && fireDone == false)
                {
                    fireDone = true;
                    Debug.Log("Le feu est allumé");

                    finalTime = globalTimer.GetComponent<Timer>().timer;
                    Debug.Log(finalTime);

                    RestartButton.SetActive(true);

                    leaderbordScript.LeaderBoardUpdate();

                }
            }
        }

        public void RestartGame()
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
