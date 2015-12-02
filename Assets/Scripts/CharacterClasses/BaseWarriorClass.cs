/**
* Grog!!!!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharachterClass {

    public BaseWarriorClass() {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "This is a awsome warrior!";
        Initiative = 10;
        Strength = 15;
        Constitution = 5;
        Intelligence = 6;
        Ac = 15;
        Speed = 10;
    }

}