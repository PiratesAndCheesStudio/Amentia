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
		Debug.Log("Player Stamina" + GameInfo.PlayerClass.Stamina);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
