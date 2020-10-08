using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class Olive : MonoBehaviour
    {
        public bool olivePitted;
        private int hitCount = 0;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O) && !olivePitted)
            {
                Debug.Log("Olive touchée");
                hitCount += 1;
            }
            if (hitCount == 10 && !olivePitted)
            {
                Debug.Log("L'olive est dénoyautée");
                hitCount = 0;
                olivePitted = true;
            }
        }
    }
}
