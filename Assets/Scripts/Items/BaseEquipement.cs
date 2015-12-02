/**
* BaseEquipement class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseEquipement : BaseStatItem {

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

    public EquipementTypes EquipementType {
        get { return equipementType;  }
        set { equipementType = value; }
    }

}
