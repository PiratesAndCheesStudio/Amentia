using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		BaseRace race = new BaseRace();
		Debug.Log("Race Name;" + race.RaceName);
		Debug.Log("Race Decs;" + race.RaceDesc);
		Debug.Log(race.HasStaminaBonus);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
