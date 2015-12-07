/**
* Load data
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class Load {

    public static void loadAllInfos() {
        GameInfo.PlayerName     = PlayerPrefs.GetString("AMENTIA_PLAYERNAME");
        GameInfo.PlayerLevel    = PlayerPrefs.GetInt("AMENTIA_PLAYERLEVEL");
        GameInfo.Gold           = PlayerPrefs.GetInt("AMENTIA_GOLD");

		//Try to load the player class
		if (PlayerPrefs.GetString("AMENTIA_PLAYERCLASS") != null ) {
			GameInfo.PlayerClass = (BaseCharachterClass)Serialization.load("AMENTIA_PLAYERCLASS");
        }
    }

}
