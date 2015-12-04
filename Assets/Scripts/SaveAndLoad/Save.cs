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
        PlayerPrefs.SetInt("AMENTIA_INITIATIVE", GameInfo.Initiative);
        PlayerPrefs.SetInt("AMENTIA_STRENGTH", GameInfo.Strength);
        PlayerPrefs.SetInt("AMENTIA_CONSTITUTION", GameInfo.Constitution);
        PlayerPrefs.SetInt("AMENTIA_INTELLIGENCE", GameInfo.Intelligence);
        PlayerPrefs.SetInt("AMENTIA_AC", GameInfo.Ac);
        PlayerPrefs.SetInt("AMENTIA_SPEED", GameInfo.Speed);
        if (GameInfo.EquipmentOne != null) {
            Serialization.save("AMENTIA_GEARITEM1", GameInfo.EquipmentOne);
        }
        Debug.Log("SAVE DONE!");
    }

}
