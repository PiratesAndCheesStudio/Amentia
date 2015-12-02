/**
* BaseWeapon class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

    public enum WeaponTypes {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD
    }

    private WeaponTypes weaponType;

    //Getter setter
    public WeaponTypes WeaponType {
        get { return weaponType; }
        set { weaponType = value; }
    }

}
