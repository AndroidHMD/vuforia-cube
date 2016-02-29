using UnityEngine;
using System.Collections;

public class PlayerCountDebugger : MonoBehaviour {
	void Update () {
		string str = "Connected players: ";

		foreach (var player in PhotonNetwork.playerList)
		{
			str += "[" + player.name + ", " + player.ID + "]";
		}

		Debug.Log(str);
	}
}