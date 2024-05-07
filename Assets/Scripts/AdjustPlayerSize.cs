using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustPlayerSize : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's Transform
    public Slider sizeSlider;         // Reference to the slider UI

    void Start()
    {
        // Initialize the slider event
        sizeSlider.onValueChanged.AddListener(ChangePlayerSize);
    }

    // Method to adjust the player's size
    private void ChangePlayerSize(float size)
    {
        if (playerTransform != null)
        {
            // Set the player's scale based on the slider's value
            playerTransform.localScale = new Vector3(size, size, size);
        }
    }

    void OnDestroy()
    {
        // Remove listener when the script is destroyed
        sizeSlider.onValueChanged.RemoveListener(ChangePlayerSize);
    }
}
