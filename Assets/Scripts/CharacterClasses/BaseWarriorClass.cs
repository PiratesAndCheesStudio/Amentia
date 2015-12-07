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

		// Stats
		Stamina 	= 13;
		Intellect 	= 6;
		Strength 	= 10;
		Agillity 	= 5;
		Dexterity 	= 3;
		Trading 	= 5;
		Luck 		= 5;
		Crit 		= 2;
    }

}