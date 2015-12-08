/**
* BaseItem class watch what your doing here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
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

	public BaseItem(Dictionary<string, string> itemsDictionary) {
		itemName 	= itemsDictionary["item_name"];
		itemID 		= int.Parse(itemsDictionary["id"]);
		itemType	= (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes), itemsDictionary["item_type"].ToString());
	}

	//Stats
	private int strength;
	private int intelligence;
	private int crit;
	private int stamina;
	private int dexterity;
	
	public int Strength {
		get { return strength; }
		set { strength = value; }
	}
	
	public int Intelligence {
		get { return intelligence; }
		set { intelligence = value; }
	}
	
	public int Crit {
		get { return crit; }
		set { crit = value; }
	}
	
	public int Stamina {
		get {return stamina;}
		set {stamina = stamina;}
	}
	
	public int Dexterity {
		get {return dexterity;}
		set {stamina = dexterity;}
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
