/**
* Class for our mage friends
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseMageClass : BaseCharachterClass {

    public BaseMageClass() {

		//Charinfo
        CharacterClassName 			= "Mage";
        CharacterClassDescription 	= "This is a awsome Mage!";

		// Stats
		Stamina 	= 12;
		Intellect 	= 12;
		Strength 	= 8;
		Agillity 	= 5;
		Dexterity 	= 3;
		Trading 	= 5;
		Luck 		= 5;
		Crit 		= 2;
    }
}
