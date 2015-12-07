/**
* This is the BaseRace Class
* Just look what you edit here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class BaseRace {

	private string raceName = "No name";
	private string raceDesc = "No rache desc";

	//Bonus
	private bool hasStaminaBonus = false;
	private bool hasIntellectBonus = false;
	private bool hasStrengthBonus = false;
	private bool hasArmorBonus = false;
	private bool hasAgillityBonus = false;
	private bool hasDexterityBonus = false;
	private bool hasTradingBonus = false;
	private bool hasLuckBonus = false;
	private bool hasCritBonus = false;

	//Getters and setters
	public string RaceName {
		get{return raceName;}
		set{raceName = value;}
	}
	public string RaceDesc {
		get{return raceDesc;}
		set{raceDesc = value;}
	}

	public bool HasIntellectMain {get; set;}

	public bool HasStaminaBonus {get; set;}
	public bool HasIntellectBonus {get; set;}
	public bool HasStrenghtBonus {get; set;}
	public bool HasArmorBonus {get; set;}
	public bool HasAgillityBonus {get; set;}
	public bool HasDexterityBonus {get; set;}
	public bool HasTradingBonus {get; set;}
	public bool HasLuckBonus {get; set;}
	public bool HasCritBonus {get; set;}

}
