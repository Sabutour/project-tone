using UnityEngine;
using System.Collections;

// This script is to be attatched to the greenBrush GameObject.

public class GreenBrush : MonoBehaviour
{
  public GameObject greenBrush;
  
  void Start()
  {
    greenBrush = GameObject.Find("greenBrush");
  }
 
  void OnCollisionStay2D(Collision2D other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      Debug.Log ("Green Brush Collected!");
      greenBrush.SetActive(false);
      GlobalVariables.CollectedGreenBrush = true;
    }
  }
}