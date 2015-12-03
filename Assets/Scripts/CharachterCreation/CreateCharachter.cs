/**
* This is the script for the character creation
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class CreateCharachter : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isMage;
    private bool isWarrior;
    private string playerName = "Enter Name";

	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        playerName = GUILayout.TextArea(playerName, 15);
        isMage      = GUILayout.Toggle(isMage, "Mage");
        isWarrior   = GUILayout.Toggle(isWarrior, "Warrior");

        if (GUILayout.Button("Create")) {
            if (isMage) {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarrior) {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }

            newPlayer.PlayerName = playerName;
            newPlayer.PlayerLevel = 1;
            newPlayer.Initiative = newPlayer.PlayerClass.Initiative;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Constitution = newPlayer.PlayerClass.Constitution;
            newPlayer.Ac = newPlayer.PlayerClass.Ac;
            newPlayer.Speed = newPlayer.PlayerClass.Speed;
			saveNewCharachterInfos();
            Save.saveAllInfos();
            Debug.Log("Player Class" + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Name" + newPlayer.PlayerName);
            Debug.Log("Player Initiative" + newPlayer.Initiative);
            Debug.Log("Player Intelligence" + newPlayer.Intelligence);
            Debug.Log("Player Strength" + newPlayer.Strength);
            Debug.Log("Player Constitution" + newPlayer.Constitution);
            Debug.Log("Player Ac" + newPlayer.Ac);
            Debug.Log("Player Speed" + newPlayer.Speed);
        }

		if (GUILayout.Button ("Load")) {
			Application.LoadLevel("scene2");
		}
    }

	//This saves all char infos to our game object
	//IMPORTANT!
	//DO ONY CALL THIS FUNCTION IF WE HAVE A NEWPLAYER OBJECT
	//WITH ALL THE DATA!!!!
	private void saveNewCharachterInfos() {
		GameInfo.PlayerName 	= newPlayer.PlayerName;
		GameInfo.PlayerLevel 	= newPlayer.PlayerLevel;
		GameInfo.Initiative 	= newPlayer.Initiative;
		GameInfo.Intelligence 	= newPlayer.Intelligence;
		GameInfo.Strength 		= newPlayer.Strength;
		GameInfo.Constitution 	= newPlayer.Constitution;
		GameInfo.Ac 			= newPlayer.Ac;
		GameInfo.Speed 			= newPlayer.Speed;
	}
}
