/**
* This is the BaseElfRace Class
* Just look what you edit here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class BaseElfRace : BaseRace {

	public BaseElfRace() {

		RaceName = "Elf";
		RaceDesc = "Elf are veary good with the bow";

		//Bonus
		HasIntellectBonus = true;
		HasAgillityBonus = true;
		HasDexterityBonus = true;

	}

}
