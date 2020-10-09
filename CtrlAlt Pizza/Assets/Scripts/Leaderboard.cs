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

        private bool saved;

        void Start()
        {
            saved = false;
            listScores = new List<string>();

        }
        
        void Update()
        {
            if (fire.fireDone == true && saved == false)
            {
                time = fire.GetComponent<Feu>().finalTime;
                string scoreTotal;

                int minutes = Mathf.FloorToInt(time / 60F);
                int seconds = Mathf.FloorToInt(time % 60F);
                int milliseconds = Mathf.FloorToInt((time * 100F) % 100F);

                string scoreMin = minutes.ToString();
                string scoreSec = seconds.ToString();
                string scoreMilli = milliseconds.ToString();

                scoreTotal = scoreMin + ":" + scoreSec + ":" + scoreMilli;
                Debug.Log(scoreTotal);

                listScores.Add(scoreTotal);
                listScores.Sort();
                listScores.RemoveAt(10);
            }
        }
    }
}
