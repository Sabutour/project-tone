using UnityEngine;
using System.Collections;

// This script is to be attatched to the redBrush GameObject.

public class RedBrush : MonoBehaviour
{
  public GameObject redBrush;
  
  void Start()
  {
    redBrush = GameObject.Find("redBrush");
  }
 
  void OnCollisionStay2D(Collision2D other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      Debug.Log ("Red Brush Collected!");
      redBrush.SetActive(false);
      GlobalVariables.CollectedRedBrush = true;
    }
  }
}