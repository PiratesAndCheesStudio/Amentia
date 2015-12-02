/**
* BaseItem class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseItem {

    //Basic item stuff
    private string itemName;
    private string itemDescription;
    private int itemID;
    //Id for spelleffect
    private int spellEffect;

    //If you need a new item type add this here
    public enum ItemTypes {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        CHEST
    }
    private ItemTypes itemType;

    //Getter and setter
    public string ItemName {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemID {
        get { return itemID; }
        set { itemID = value; }
    }

    public ItemTypes ItemType {
        get { return itemType; }
        set { itemType = value; }
    }

    public int SpellEffectID {
        get { return spellEffect; }
        set { spellEffect = value; }
    }

}
