/**
* BasePotion class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BasePotion : BaseItem {

    public enum PotionTypes {
        HEALTH,
        MANA,
        INTELLECT,
        DEXTERITY,
		STRENGTH,
		AGILLITY
    }

    private PotionTypes potionType;

	public BasePotion(Dictionary<string, string> itemsDictionary) : base(itemsDictionary){}

    //Getter setter
    public PotionTypes PotionType {
        get { return potionType; }
        set { potionType = value; }
    }

}
