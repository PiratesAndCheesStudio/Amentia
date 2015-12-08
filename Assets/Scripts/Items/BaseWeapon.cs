/**
* BaseWeapon class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseWeapon : BaseItem {

    public enum WeaponTypes {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD
    }

    private WeaponTypes weaponType;

	public BaseWeapon(Dictionary<string, string> itemsDictionary) : base(itemsDictionary){}

    //Getter setter
    public WeaponTypes WeaponType {
        get { return weaponType; }
        set { weaponType = value; }
    }

}
