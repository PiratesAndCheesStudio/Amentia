/**
* BasePotion class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

    public enum PotionTypes {
        HEALTH,
        MANA,
        INTELLECT,
        SPEED
    }

    private PotionTypes potionType;

    //Getter setter
    public PotionTypes WeaponType {
        get { return potionType; }
        set { potionType = value; }
    }

}
