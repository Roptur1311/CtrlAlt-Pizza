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
        private string scoreTotal;

        [SerializeField]
        private GameObject fire;

        private void Awake()
        {
            fire = GameObject.FindGameObjectWithTag("feu");
            affichage = GameObject.FindGameObjectWithTag("affichage");
        }

        public void LeaderBoardUpdate()
        {
            //if(fire.fireDone == true)
            //{
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
                listScores.Sort();
                Debug.Log(listScores[0] + "b");
                
                listScores.RemoveAt(10);

                affichage.GetComponent<Text>().text = listScores[0].ToString() + "\n" + listScores[1].ToString() + "\n" + listScores[2].ToString() + "\n" + listScores[3].ToString() + "\n" + listScores[4].ToString() + "\n" + listScores[5].ToString() + "\n" + listScores[6].ToString() + "\n" + listScores[7].ToString() + "\n" + listScores[8].ToString() + "\n" + listScores[9].ToString() + "\n";
            //}            
        }
    }
}
