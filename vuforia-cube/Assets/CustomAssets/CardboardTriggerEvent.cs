using UnityEngine;
using System.Collections;

public class CardboardTriggerEvent : MonoBehaviour {

	public Cardboard myCardboard;

	void Start() {
		// Disable screen dimming:
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	} 

	void Update () {
		//True for only one frame
		if(myCardboard.Triggered) {
			Debug.Log("Button was clicked");
			createNewCube ();

		}
	}
	void createNewCube(){
		transform.position += Vector3.right*5; 
	
	}
}
