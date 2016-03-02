using UnityEngine;
using System.Collections;

public class RuntimeComponentAttacher : MonoBehaviour {
	public GameObject[] gameObjects;
	public System.Type componentType;

	void Start () {
		componentType = typeof(RemoveMaskOutBehaviourAndDisableRenderingOnStart);
		foreach(var gameObject in gameObjects)
		{
			//gameObject.AddComponent(component.GetType());
			gameObject.AddComponent(componentType);
		}
	}
}
