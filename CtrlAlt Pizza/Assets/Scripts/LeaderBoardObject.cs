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

        /*[SerializeField]
        private GameObject egg;*/



        public void LeaderBoardUpdate()
        {
            fire = GameObject.FindGameObjectWithTag("feu");
            //egg = GameObject.FindGameObjectWithTag("egg");
            affichage = GameObject.FindGameObjectWithTag("affichage");
            tempsPerso = GameObject.FindGameObjectWithTag("tempsPerso");

            playerName = PlayerPrefs.GetString("Name");

            if (PlayerPrefs.HasKey("Highscores") == false)
            {
                listScores = new List<string>() { "00:50:00 George", "00:55:42 Antoine", "00:58:36 Louise", "00:52:00 Tom", "01:05:00 Clara", "01:03:52 Lisa", "01:12:00 Aurélien", "01:30:14 Emma", "01:10:00 Kevin", "02:00:00 Steve" };
                for (int h = 0; h < listScores.Count; h++)
                {                   
                    PlayerPrefs.SetString("Highscores" + h, listScores[h]);
                }

                PlayerPrefs.SetString("Highscores", "0");
                PlayerPrefs.Save();
                Debug.Log("saved");
            }

            for (int i = 0 ;  i < listScores.Count ; i++)
            {
                listScores[i] = PlayerPrefs.GetString("Highscores" + i);
            }

            Debug.Log(playerName);

            if (fire.GetComponent<Feu>().fireDone == true /*egg.GetComponent<Oeuf>().eggcracked == true*/)
            {
                time = fire.GetComponent<Feu>().finalTime;
                //time = egg.GetComponent<Oeuf>().finalTime;
                
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

                for (int j = 0; j < listScores.Count; j++)
                {
                    PlayerPrefs.SetString("Highscores" + j, listScores[j]);
                }

                PlayerPrefs.Save();
            }
            
        }
    }
}
