using UnityEngine;
using System.Collections;

public class RemoveMaskOutBehaviourAndDisableRenderingOnStart : MonoBehaviour {
	void Start () {
		//gameObject.GetComponent<Vuforia.MaskOutBehaviour>().enabled = false;
		//gameObject.GetComponent<MeshRenderer>().enabled = false;

		Destroy(gameObject.GetComponent<Vuforia.MaskOutBehaviour>());
		Destroy(gameObject.GetComponent<MeshRenderer>());
	}
}
