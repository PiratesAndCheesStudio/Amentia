/**
* With this script you can simple test if the save has worked
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class TestLoadScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Load.loadAllInfos ();
		Debug.Log("Player Name" + GameInfo.PlayerName);
		Debug.Log("Player Level" + GameInfo.PlayerLevel);
		Debug.Log("Player Initiative" + GameInfo.Initiative);
		Debug.Log("Player Intelligence" + GameInfo.Intelligence);
		Debug.Log("Player Strength" + GameInfo.Strength);
		Debug.Log("Player Constitution" + GameInfo.Constitution);
		Debug.Log("Player Ac" + GameInfo.Ac);
		Debug.Log("Player Speed" + GameInfo.Speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
