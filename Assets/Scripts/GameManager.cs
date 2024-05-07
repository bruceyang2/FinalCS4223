using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance

    public string playerName; // To store player's name across scenes

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Prevents destruction on loading a new scene
        }
        else
        {
            Destroy(gameObject); // Ensures only one instance exists
        }
    }
}
