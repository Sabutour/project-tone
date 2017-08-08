using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script it to be attached to any GameObject that restarts the level, such as a Killzone.

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other) // When something enters the collider of this object.
        {
            if (other.tag == "Player") // If the object that entered the collider was the player.
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name); // Reload the current level.
            }
            
            // Level 3 contains the red brush. If the player dies on this level, they lose the red brush.
            if (GlobalVariables.CurrentLevel == 3) {
              GlobalVariables.CollectedRedBrush == false;
            }
            
            // Level 6 contains the green brush. If the player dies on this level, they lose the green brush.
            else if (GlobalVariables.CurrentLevel == 6) {
              GlobalVariables.CollectedGreenBrush == false;
            }
            
            // Level 9 contains the blue brush. If the player dies on this level, they lose the blue brush.
            else if (GlobalVariables.CurrentLevel == 9) {
              GlobalVariables.CollectedBlueBrush == false;
            }
        }
    }
}
