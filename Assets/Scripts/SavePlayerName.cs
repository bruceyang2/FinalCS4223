using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SavePlayerName : MonoBehaviour
{
    public InputField nameInputField;

    public void SaveName()
    {
        GameManager.Instance.playerName = nameInputField.text; // Store the name in GameManager
        SceneManager.LoadScene("Game"); // Load the Game scene
    }
}
