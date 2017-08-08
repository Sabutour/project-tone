using UnityEngine;
using System.Collections;

// This script is to be attatched to the blueBrush GameObject.

public class BlueBrush : MonoBehaviour
{
  public GameObject blueBrush;
  
  void Start()
  {
    blueBrush = GameObject.Find("blueBrush");
  }
 
  void OnCollisionStay2D(Collision2D other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      Debug.Log ("Blue Brush Collected!");
      blueBrush.SetActive(false);
      GlobalVariables.CollectedBlueBrush = true;
    }
  }
}
