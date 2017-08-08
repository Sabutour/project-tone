 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class FadeScreen : MonoBehaviour {
 
     private Image FadeScreen;
     public int FadeTime;
     Color color = Color.black;
 
     // Use this for initialization
     void Start () {
         FadeScreen = GameObject.Find("FadeScreen");
         Disable();
     }
     
     // Update is called once per frame
     void Update () {
     }
 
     public void Disable()
     {
         Debug.Log("Disabling GameObject FadeScreen");
         FadeScreen.enabled = false;
     }
 
     public void Enable()
     {
         Debug.Log("Enabling GameObject FadeScreen");
         FadeScreen.enabled = true;
     }
 
     public void FadeIn()
     {
         Debug.Log("FadeIn called");
 
         Enable();
         color.a = 1f;
         FadeScreen.color = color;
 
         FadeScreen.CrossFadeAlpha(0, FadeTime, false);
     }
 
     public void FadeOut()
     {
         Debug.Log("FadeOut called");
 
         Enable();
         color.a = 0f;
         FadeScreen.color = color;
 
         FadeScreen.CrossFadeAlpha(1, FadeTime, false);
     }
 }
