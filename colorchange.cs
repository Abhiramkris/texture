 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class color : MonoBehaviour
{
public GameObject targetObject;
public Button colorChangeButton;
public Color[] colors; // Array of colors to cycle through
private int currentColorIndex = 0;
private void Start()
{
// Add a listener to the button click event
colorChangeButton.onClick.AddListener(ChangeObjectColor);
// Initialize the target object's color
targetObject.GetComponent<Renderer>().material.color = colors[currentColorIndex];
}
private void ChangeObjectColor()
{
// Increment the color index and wrap around if needed
currentColorIndex = (currentColorIndex + 1) % colors.Length;
// Change the target object's color
targetObject.GetComponent<Renderer>().material.color = colors[currentColorIndex];
}
} 
