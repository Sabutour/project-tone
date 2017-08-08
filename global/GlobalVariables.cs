using UnityEngine;
using System.Collections;

// This script keeps track of variables that have to be called from any level.
// It is to be kept identical across Unity Scenes.

public class GlobalVariables : MonoBehaviour {

	static public bool CollectedRedBrush = false; // Whether or not the player has the Red Brush.
	
	static public bool CollectedGreenBrush = false; // Whether or not the player has the Green Brush.
	
	static public bool CollectedBlueBrush = false; // Whether or not the player has the Blue Brush.

	static public int CurrentLevel; // Keeps track of the current loaded Unity Scene.

}
