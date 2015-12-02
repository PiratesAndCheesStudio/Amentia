/**
* BaseStatItem class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

    //Stats
    private int strength;
    private int intelligence;

    public int Strength {
        get { return strength; }
        set { strength = value; }
    }

    public int Intelligence {
        get { return intelligence; }
        set { intelligence = value; }
    }
}
