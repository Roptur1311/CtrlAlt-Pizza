using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace minigame
{
    [CreateAssetMenu(fileName = "New Leaderboard", menuName = "Leaderboard", order = 51)]
    public class LeaderBoardObject : ScriptableObject
    {

        [SerializeField]
        private List<string> listScores = new List<string>();

        [SerializeField]
        private float time;

        [SerializeField]
        private GameObject affichage;

        [SerializeField]
        private GameObject tempsPerso;

        [SerializeField]
        private string scoreTotal;

        [SerializeField]
        private GameObject fire;

        [SerializeField]
        private string playerName;

        public void LeaderBoardUpdate()
        {
            fire = GameObject.FindGameObjectWithTag("feu");
            affichage = GameObject.FindGameObjectWithTag("affichage");
            tempsPerso = GameObject.FindGameObjectWithTag("tempsPerso");

            playerName = PlayerPrefs.GetString("Name");

            Debug.Log(playerName);

            if (fire.GetComponent<Feu>().fireDone == true)
            {
                time = fire.GetComponent<Feu>().finalTime;
                
                int minutes = Mathf.FloorToInt(time / 60F);
                int seconds = Mathf.FloorToInt(time % 60F);
                int milliseconds = Mathf.FloorToInt((time * 100F) % 100F);

                string scoreMin = minutes.ToString("00");
                string scoreSec = seconds.ToString("00");
                string scoreMilli = milliseconds.ToString("00");

                tempsPerso.GetComponent<Text>().text = scoreMin + ":" + scoreSec + ":" + scoreMilli;

                scoreTotal = scoreMin + ":" + scoreSec + ":" + scoreMilli + "   " + playerName;
                Debug.Log(scoreTotal);

                listScores.Add(scoreTotal);
                listScores.Sort();
                Debug.Log(listScores[0] + "b");
                
                listScores.RemoveAt(10);

                affichage.GetComponent<Text>().text = listScores[0].ToString() + "\n" + "\n" + listScores[1].ToString() + "\n" + "\n" + listScores[2].ToString() + "\n" + "\n" + listScores[3].ToString() + "\n" + "\n" + listScores[4].ToString() + "\n" + "\n" + listScores[5].ToString() + "\n" + "\n" + listScores[6].ToString() + "\n" + "\n" + listScores[7].ToString() + "\n" + "\n" + listScores[8].ToString() + "\n" + "\n" + listScores[9].ToString() + "\n";

                
            }
            
        }
    }
}
