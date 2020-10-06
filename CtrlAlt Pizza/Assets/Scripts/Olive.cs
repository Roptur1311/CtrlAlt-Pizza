using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olive : MonoBehaviour
{
    private int hitCount = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            hitCount += 1;
        }
        if (hitCount == 10)
        {
            Debug.Log("L'olive est dénoyautée");
            hitCount = 0;
        }
    }
}
