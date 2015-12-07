/**
* This is the basic class for all classes
* so look what you change here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseCharachterClass {

    //Define the name and the desc of the class
    private string charachterClassName;
    private string charachterClassDescription;

    //Stats
	private int stamina; // Healthmod
	private int intellect; // Spell dmg mod
	private int strength;
	private int armor; // Damage reduce mod
	private int agillity; // Doge mod
	private int dexterity; // Physic dmg mod (Bow)
	private int trading; // Lower prices
	private int luck; // More loot, yeah!
	private int crit; // Crit mod

    //Getter and setters for the stuff in c# style bitch!
    public string CharacterClassName {
        get {return charachterClassName;}
        set {charachterClassName = value;}
    }

    public string CharacterClassDescription {
        get {return charachterClassDescription;}
        set {charachterClassDescription = value;}
    }

	public int Stamina {get; set;}
	public int Intellect {get; set;}
	public int Strength {get; set;}
	public int Armor {get; set;}
	public int Agillity {get; set;}
	public int Dexterity {get; set;}
	public int Trading {get; set;}
	public int Luck {get; set;}
	public int Crit {get; set;}

}
