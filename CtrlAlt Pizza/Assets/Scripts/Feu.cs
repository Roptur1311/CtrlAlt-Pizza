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

        public Pate dough;
        public Tomate tomato;
        public Fromage cheese;
        public Chorizo chorizo;
        public Olive olive;
        public Oeuf egg;

        public GameObject RestartButton;

        public GameObject Fire;
        public GameObject OeufAnim10;

        public LeaderBoardObject leaderbordScript;

        public GameObject tableau;


        public GameObject globalTimer;
        public float finalTime;
        public AudioSource matchSound;
        public AudioSource fireSound;

        public GameObject timer;

        void Start()
        {
            fireDone = false;
            allumette = false;

            Fire.SetActive(false);

            tableau.SetActive(false);

            RestartButton.SetActive(false);
            
        }

        void Update()
        {
            if (dough.doughDone == true && tomato.tomatoDone == true && cheese.cheeseDone == true && chorizo.chorizoDone == true && olive.olivePitted == true && egg.eggIsCracked == true)
            {                
                if (Input.GetKeyDown(KeyCode.S) && fireDone == false)
                {
                    allumette = true;

                    Debug.Log(" Allumette allumée");
                    matchSound.Play();
                }

                if (allumette == true && fireDone == false)
                {
                    fireDone = true;
                    Debug.Log("Le feu est allumé");
                    fireSound.Play();

                    OeufAnim10.SetActive(false);
                    Fire.SetActive(true);

                    finalTime = globalTimer.GetComponent<Timer>().timer;
                    Debug.Log(finalTime);

                    RestartButton.SetActive(true);

                    tableau.SetActive(true);

                    timer.SetActive(false);

                    leaderbordScript.LeaderBoardUpdate();

                }
            }
        }

        public void RestartGame()
        {
            dough.doughDone = false;
            tomato.tomatoDone = false;
            cheese.cheeseDone = false;
            chorizo.chorizoDone = false;
            olive.olivePitted = false;
            egg.eggIsCracked = false;
            fireDone = false;

            allumette = false;

            SceneManager.LoadScene("StartScene");
        }
    }
}
