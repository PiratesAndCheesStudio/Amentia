/**
* Grog!!!!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseWarriorClass : BaseCharachterClass {

    public BaseWarriorClass() {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "This is a awsome warrior!";
		MainStatBonuses = mainStatBonuses.STRENGHT;
		SecondStatBonuses = secondStatBonuses.STAMINA;
    }

}