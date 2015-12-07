/**
* This is the BaseHumanRace Class
* Just look what you edit here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseHumanRace : BaseRace {

	public BaseHumanRace () {

		RaceName = "Human";
		RaceDesc = "Human are just humans!";

		HasStaminaBonus = true;
		HasStrenghtBonus = true;
		HasTradingBonus = true;

	}

}
