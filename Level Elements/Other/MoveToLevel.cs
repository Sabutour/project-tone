using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// This script is to be attatched to a GameObject that, when it collides with
// the player, loads a specific level.

public class MoveToLevel : MonoBehaviour {

  private Image FadeScreen; // This saves an image called FadeScreen (A blank, black image) to the variable 'FadeScreen'.
  public int FadeTime;  // The length of time it will take the FadeScreen to appear or disappear.
  Color color = Color.black;

  void Start();
  {
    FadeScreen = GameObject.Find("FadeScreen");
  }

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.tag == "Player")
		{
		  
		  FadeOut();
		  
		  if (GlobalVariables.CurrentLevel == 1)
		  { // Move from Level 1 to Level 2.
				SceneManager.LoadScene("scene2");
		  }
		  
			else if (GlobalVariables.CurrentLevel == 2)
			{ // Move from Level 2 to Level 1. (Change to Level 3 once created.)
				SceneManager.LoadScene("scene1");
			}
			
			else if (GlobalVariables.CurrentLevel == 3)
			{ // Move from Level 3 to Level 4.
				SceneManager.LoadScene("scene4");
			}
			
			else if (GlobalVariables.CurrentLevel == 4)
			{ // Move from Level 4 to Level 5.
				SceneManager.LoadScene("scene5");
			}
			
			else if (GlobalVariables.CurrentLevel == 5)
			{ // Move from Level 5 to Level 6.
				SceneManager.LoadScene("scene6");
			}
			
			else if (GlobalVariables.CurrentLevel == 6)
			{ // Move from Level 6 to Level 7.
				SceneManager.LoadScene("scene7");
			}
			
			else if (GlobalVariables.CurrentLevel == 7)
			{ // Move from Level 7 to Level 8.
				SceneManager.LoadScene("scene7");
			}
			
			else if (GlobalVariables.CurrentLevel == 8)
			{ // Move from Level 8 to Level 9.
				SceneManager.LoadScene("scene9");
			}
			
			else if (GlobalVariables.CurrentLevel == 9)
			{ // Move from Level 9 to Level 10.
				SceneManager.LoadScene("scene10");
			}
			
			else if (GlobalVariables.CurrentLevel == 10)
			{ // Move from Level 10 to Level 11.
				SceneManager.LoadScene("scene11");
			}
			
			else if (GlobalVariables.CurrentLevel == 11)
			{ // Move from Level 11 to Level 12.
				SceneManager.LoadScene("scene12");
			}
			
			FadeIn();
		}
	}
	
     public void FadeIn()
     {
         Debug.Log("FadeIn called");
         color.a = 1f;
         FadeScreen.color = color;
         FadeScreen.CrossFadeAlpha(0, FadeTime, false);
     }
 
     public void FadeOut()
     {
         Debug.Log("FadeOut called");
         color.a = 0f;
         FadeScreen.color = color;
         FadeScreen.CrossFadeAlpha(1, FadeTime, false);
     }
	
}
