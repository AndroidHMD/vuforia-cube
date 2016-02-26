using UnityEngine;
using System.Collections;

public class PositionDebugger : MonoBehaviour {
	void Update () {
		Debug.Log("Camera position: " + gameObject.transform.position);
	}
}