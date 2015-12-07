/**
* Save data
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class Save {

    public static void saveAllInfos() {
        PlayerPrefs.SetInt("AMENTIA_PLAYERLEVEL", GameInfo.PlayerLevel);
        PlayerPrefs.SetString("AMENTIA_PLAYERNAME", GameInfo.PlayerName);
        PlayerPrefs.SetInt("AMENTIA_GOLD", GameInfo.Gold);
        if (GameInfo.PlayerClass != null) {
			Serialization.save("AMENTIA_PLAYERCLASS", GameInfo.PlayerClass);
        }
        Debug.Log("SAVE DONE!");
    }

}
