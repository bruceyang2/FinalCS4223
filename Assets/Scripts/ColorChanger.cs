using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Renderer playerRenderer; 
    public Dropdown colorDropdown;


    public void OnDropdownValueChanged()
    {

        Color selectedColor = Color.green; 
        switch (colorDropdown.value)
        {
            case 0:
                selectedColor = Color.green;
                break;
            case 1:
                selectedColor = Color.red;
                break;
            case 2:
                selectedColor = Color.magenta;
                break;
            case 3:
                selectedColor = Color.blue;
                break;
        }

        // Change the player's color to the selected color
        ChangeColor(selectedColor);
    }

    // Helper method to change the player's color
    private void ChangeColor(Color newColor)
    {
        if (playerRenderer != null)
        {
            playerRenderer.material.color = newColor;
        }
    }
}
