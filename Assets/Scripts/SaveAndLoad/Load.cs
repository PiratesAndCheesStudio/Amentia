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
        GameInfo.Initiative     = PlayerPrefs.GetInt("AMENTIA_INITIATIVE");
        GameInfo.Intelligence   = PlayerPrefs.GetInt("AMENTIA_INTELLIGENCE");
        GameInfo.Strength       = PlayerPrefs.GetInt("AMENTIA_STRENGTH");
        GameInfo.Constitution   = PlayerPrefs.GetInt("AMENTIA_CONSTITUTION");
        GameInfo.Ac             = PlayerPrefs.GetInt("AMENTIA_AC");
        GameInfo.Speed          = PlayerPrefs.GetInt("AMENTIA_SPEED");
    }

}
