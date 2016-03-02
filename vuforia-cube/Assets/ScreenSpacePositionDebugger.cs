using UnityEngine;
using System.Collections;

public class ScreenSpacePositionDebugger : MonoBehaviour {
	public Transform monitoredObject;

	void Update () {
		debugMonitoredObjectSSPosition();
	}

	void debugMonitoredObjectSSPosition() {
		var screenPoint = GetComponent<Camera>().WorldToScreenPoint(monitoredObject.position);

		screenPoint.x /= Screen.width;
		screenPoint.y /= Screen.height;

		Debug.Log("Screen space position of cube: " + screenPoint);
	}
}
