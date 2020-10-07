using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feu : MonoBehaviour
{
    private bool feu;

    void Start()
    {
        feu = true;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
                feu = false;

                Debug.Log(" Le feu est prêt à être allumé");
        }

        if (Input.GetKeyDown(KeyCode.D) && feu == false)
        {
                Debug.Log("Le feu est allumé");
        }
    }
}
