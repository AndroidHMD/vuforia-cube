using UnityEngine;
using System.Collections;

public class PositionDebugger : MonoBehaviour {
	void Update () {
		Debug.Log("Camera position: " + gameObject.transform.position);
		Debug.Log("Cardboard position: " + GameObject.FindGameObjectWithTag("MainCamera").transform.position);

		Debug.Log("Camera rotation: " + gameObject.transform.rotation);
	}
}