using UnityEngine;
using System.Collections;

public class CBridgeActivator2Level1 : MonoBehaviour
{

	public bool blueBridge2Active = false;
	public GameObject blueBridge2;

	// Use this for initialization
	void Start() {
		blueBridge2 = GameObject.Find("blueBridge2");
		blueBridge2.SetActive(false);
	}

	void Update() {
		if (blueBridge2Active == true) {
			blueBridge2.SetActive (true);
		} else if (blueBridge2Active == false) {
			blueBridge2.SetActive (false);
		}
	}

	void OnCollisionStay2D(Collision2D  other)
	{
		Debug.Log("Entered Collider");
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Player Detected");
			if (Input.GetKeyDown(KeyCode.E))
			{
				Debug.Log ("E Pressed. Bridge Extended.");
				blueBridge2.SetActive(true);
				blueBridge2Active = !blueBridge2Active;
			}
		}
	}
}
