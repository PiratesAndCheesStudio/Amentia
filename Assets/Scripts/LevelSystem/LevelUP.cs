/**
* Level up!!!!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class LevelUP {

    public int maxLevel = 50;

    public void levelUpCharacter() {
        //if the player levels up than he will keep the
        // overload of the xp back
        //EG: 100 LVL2 => Player becomes 120 he will now have 20 XP and is LVL2
        if (GameInfo.CurrentXP > GameInfo.RequiredXP) {
            GameInfo.CurrentXP -= GameInfo.RequiredXP;
        } else {
            GameInfo.CurrentXP = 0;
        }

        if (GameInfo.PlayerLevel < maxLevel) {
            GameInfo.PlayerLevel += 1;
        }
        else {
            GameInfo.PlayerLevel = maxLevel;
        }

        determineRequiredXP();
    }

    private void determineRequiredXP() {
        //Demo of determine ou xp
        int temp = (GameInfo.PlayerLevel * 1000) + 250;
        GameInfo.RequiredXP = temp;
    }

}
