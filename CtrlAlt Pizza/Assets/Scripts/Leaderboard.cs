using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace minigame
{
    public class Leaderboard : MonoBehaviour
    {
        private List<string> listScores;
        public Feu fire;
        private float time;
        public Text affichage;
        private string scoreTotal;

        private bool saved;

        void Start()
        {
            saved = false;
            listScores = new List<string>() { "00:50:00", "00:55:42", "00:58:36", "00:52:00", "01:05:00", "01:03:52", "01:12:00", "01:30:14", "01:10:00", "02:00:00" };

        }
        
        void Update()
        {
            if (fire.fireDone == true && saved == false)
            {
                time = fire.GetComponent<Feu>().finalTime;

                int minutes = Mathf.FloorToInt(time / 60F);
                int seconds = Mathf.FloorToInt(time % 60F);
                int milliseconds = Mathf.FloorToInt((time * 100F) % 100F);

                string scoreMin = minutes.ToString();
                string scoreSec = seconds.ToString();
                string scoreMilli = milliseconds.ToString();

                scoreTotal = scoreMin + ":" + scoreSec + ":" + scoreMilli;
                Debug.Log(scoreTotal);

                listScores.Add(scoreTotal);
                Debug.Log(listScores[0] + "b");
                listScores.Sort();
                listScores.RemoveAt(10);

                affichage.text = listScores[0].ToString() + "\n" + listScores[1].ToString() + "\n" + listScores[2].ToString() + "\n" + listScores[3].ToString() + "\n" + listScores[3].ToString() + "\n" + listScores[4].ToString() + "\n" + listScores[5].ToString() + "\n" + listScores[6].ToString() + "\n" + listScores[7].ToString() + "\n" + listScores[8].ToString() + "\n" + listScores[9].ToString() + "\n";

                saved = true;
            }
        }
    }
}
