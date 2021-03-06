﻿/**
* BaseEquipement class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseEquipement : BaseItem {

    public enum EquipementTypes {
        HEAD,
        CHEAST,
        SHOULDERS,
        LEGS,
        FEET,
        NECK,
        RING,
        EARRING
    }

    private EquipementTypes equipementType;

	public BaseEquipement(Dictionary<string, string> itemsDictionary) : base(itemsDictionary){}

    public EquipementTypes EquipementType {
        get { return equipementType;  }
        set { equipementType = value; }
    }

}
