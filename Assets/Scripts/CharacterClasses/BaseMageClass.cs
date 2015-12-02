/**
* Class for our mage friends
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharachterClass {

    public BaseMageClass() {
        CharacterClassName = "Mage";
        CharacterClassDescription = "This is a awsome Mage!";
        Initiative = 10;
        Strength = 3;
        Constitution = 10;
        Intelligence = 15;
        Ac = 10;
        Speed = 10;
    }
}
