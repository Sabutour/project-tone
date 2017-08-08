using UnityEngine;
using System.Collections;

// This is a version of the CBridgeActivator script designed to be used with the first CBridgeActivator on Level 1

public class CBridgeActivator1Level1 : MonoBehaviour
{
	public bool blueBridgeActive = false;
	public bool redBridgeActive = false;
	public bool greenBridgeActive = false;
	
	public GameObject blueBridge;
	public GameObject redBridge;
	public GameObject greenBridge;

	// Use this for initialization
	void Start()
	 
	  // This sets up the script to know which object in the scene is the Blue Bridge, and disable it.
		blueBridge = GameObject.Find("blueBridge");
		blueBridge.SetActive(false);

	  // This sets up the script to know which object in the scene is the Red Bridge, and disable it.
		redBridge = GameObject.Find("redBridge");
		redBridge.SetActive(false);
		
	  // This sets up the script to know which object in the scene is the Green Bridge, and disable it.
		greenBridge = GameObject.Find("greenBridge");
		redBridge.SetActive(false);
	}

  // This section of the script continually checks to see if a variable controlling the on/off state of a bridge has been switched and, if so, turns on the corresponding bridge colour GameObject.
	void Update() {
		if (blueBridgeActive == true)
		{
			blueBridge.SetActive (true);
		}
		else if (blueBridgeActive == false)
		{
			blueBridge.SetActive (false);
		}


		if (redBridgeActive == true)
		{
			redBridge.SetActive (true);
		}
		else if (redBridgeActive == false)
		{
			redBridge.SetActive (false);
		}

		
		if (greenBridgeActive == true)
		{
		  greenBridge.SetActive (true);
		}
		else if (greenBridgeActive == false)
		{
		  greenBridge.SetActive (false);
		}
	}

	void OnCollisionStay2D(Collision2D  other) //
	{
		Debug.Log("Entered Collider");
		if (other.gameObject.CompareTag("Player"))
		{
		  if (GlobalVariables.CollectedBlueBrush == true)
		  {
		    Debug.Log("Player Detected");
			  if (Input.GetKeyDown(KeyCode.Alpha1) && redBridgeActive == false && greenBridgeActive == false)
			  {
				  Debug.Log ("'1' Pressed. Blue Bridge Extended.");
				  blueBridgeActive = !blueBridgeActive;
			  }
		  }
		  
		  
			else if (GlobalVariables.CollectedRedBrush == true)
			{
			  else if (Input.GetKeyDown(KeyCode.Alpha2) && blueBridgeActive == false && greenBridgeActive)
			  {
				  Debug.Log ("'2' Pressed. Red Bridge Extended.");
				  redBridgeActive = !redBridgeActive;
			  }
			}
			
			
			else if (GlobalVariables.CollectedGreenBrush == true)
			{
			  else if (Input.GetKeyDown(KeyCode.Alpha3) && blueBridgeActive == false && redBridgeActive == false)
			  {
			    Debug.Log("'2' Pressed. Green Bridge Extended.")
			    greenBridgeActive = !greenBridgeActive;
			  }
			}
		}
	}
}