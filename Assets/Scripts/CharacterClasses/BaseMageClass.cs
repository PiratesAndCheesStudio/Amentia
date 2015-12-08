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
		MainStatBonuses = mainStatBonuses.INTELLECT;
		SecondStatBonuses = secondStatBonuses.DEXTERITY;
    }
}
