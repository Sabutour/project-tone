using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script it to be attached to an empty GameObject in each scene. It is a high-priority script that controls and manages the UI elements on screen at any time.

namespace UnityStandardAssets._2D
{
  public class UIElementTracker : MonoBehaviour
  {
      
    public GameObject redBrushUIElement;
    public GameObject greenBrushUIElement;
    public GameObject blueBrushUIElement;
      
    Color InActiveUIElement = new Color(d3,d3,d3,0.8); //All inactive UI elements will be set to this grey, transluscent color.
    Color ActiveUIElement = new Color(00,00,00,1); //All active UI elements will be their original color and fully opaque.
      
    //Use this for initialisation.
    void Start()
    {
        
      redBrushUIElement = GameObject.Find("redBrushUIElement");
      redBrushUIElement.GetComponent<MeshRenderer>().material.color = InActiveUIElement;

      greenBrushUIElement = GameObject.Find("greenBrushUIElement");
      greenBrushUIElement.GetComponent<MeshRenderer>().material.color = InActiveUIElement;
      
      blueBrushUIElement = GameObject.Find("blueBrushUIElement");
      blueBrushUIElement.GetComponent<MeshRenderer>().material.color = InActiveUIElement;
        
    }
      
    //This section of the script continuously updates to check if any changes to the UI need to be made.
    void Update()
    {
        
      if (GlobalVariables.CollectedRedBrush == true)
      {
        blueBrushUIElement.GetComponent<MeshRenderer>().material.color = ActiveUIElement;
      }
        
      if (GlobalVariables.CollectedGreenBrush == true)
      {
        greenBrushUIElement.GetComponent<MeshRenderer>().material.color = ActiveUIElement;
      }
        
      if (GlobalVariables.CollectedBlueBrush == true)
      {
        blueBrushUIElement.GetComponent<MeshRenderer>().material.color = ActiveUIElement;
      }
    }
  }
}
