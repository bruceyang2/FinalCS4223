using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerName : MonoBehaviour
{
    public Text nameText;

    void Start()
    {
        nameText.text = "Player: " + GameManager.Instance.playerName;
    }
}
