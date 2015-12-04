/**
* XP stuff
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class XPIncrease {

    private static int xpToGive;
    private static LevelUP levelUp = new LevelUP();

    public static void add() {
        xpToGive = GameInfo.PlayerLevel * 100;
        GameInfo.CurrentXP += xpToGive;
        checkIfPlayerLevelUp();
        Debug.Log(xpToGive);
    }

    private static void checkIfPlayerLevelUp() {
        if (GameInfo.CurrentXP >= GameInfo.RequiredXP) {
            levelUp.levelUpCharacter();
        }
    } 

}
