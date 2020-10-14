using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public InputField nameField;

    private string playerName;

    private void Update()
    {
        SubmitName();
    }

    public void SubmitName()
    {
        playerName = nameField.text;       
    }

    public void StartGame()
    {
        if(string.IsNullOrEmpty(nameField.text) == false)
        {
            Debug.Log(playerName);
            PlayerPrefs.SetString("Name" , playerName);
            SceneManager.LoadScene("Game");
        }        
    }
}
