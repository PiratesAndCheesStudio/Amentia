/**
* Stats allocation stuff
* Skill the stuff that you want etc
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class StatAllocationModule {

    private string[] statNames = new string[7]{
												"Stamina", 
												"Intelligence",
												"Strenght",
												"Agillity",
												"Dexterity",
												"Trading",
												"Luck"
											   };
    private string[] statDesc = new string[7]{
												"Health mod", 
												"Spell dmg mod",
												"Physic dmg mod",
												"Doge mod",
												"Physic dmg mod(Bow)",
												"Lower the prices",
												"More loot!"
											 };

    private bool[] statsSelections 	= new bool[7];
    public int[] pointsToAllocate 	= new int[7];
    private int[] baseStatPoints 	= new int[7];
    private int availPoints 		= 5;
    public bool didRunOnce 			= false;

    public void displayStatAllocationModule() {

        if (!didRunOnce) {
            retrieveBaseStatPoints();
            didRunOnce = true;
        }
        displayStatToggleSwitches();
        displayStatIncreaseDecreaseButtons();
    }

    private void displayStatToggleSwitches() {

        for (int i = 0; i < statNames.Length; i++) {
            statsSelections[i] = GUI.Toggle(new Rect(10, 60*i + 10, 100, 50), statsSelections[i], statNames[i]);
            GUI.Label(new Rect(100, 60 * i + 10, 50, 50), pointsToAllocate[i].ToString());
            if (statsSelections[i]) {
                GUI.Label(new Rect(20, 60 * i + 30, 150, 100), statDesc[i]);
            }
        }

    }

    private void displayStatIncreaseDecreaseButtons() {
        for (int i = 0; i < pointsToAllocate.Length; i ++) {
            if(pointsToAllocate[i] >= baseStatPoints[i] && availPoints > 0) {
                if (GUI.Button(new Rect(200, 60 * i + 10, 50, 50), "+")) {
                    pointsToAllocate[i] += 1;
                    --availPoints;
                }
            }
            if (pointsToAllocate[i] > baseStatPoints[i]) {
                if (GUI.Button(new Rect(260, 60 * i + 10, 50, 50), "-")) {
                    pointsToAllocate[i] -= 1;
                    ++availPoints;
                }
            }
        }
    }

    private void retrieveBaseStatPoints() {

        BaseCharachterClass cclass = GameInfo.PlayerClass;

        pointsToAllocate[0] = cclass.Stamina;
		baseStatPoints[0]   = cclass.Stamina;

        pointsToAllocate[1] = cclass.Intellect;
		baseStatPoints[1]   = cclass.Intellect;

		pointsToAllocate[2] = cclass.Strength;
		baseStatPoints[2]   = cclass.Strength;

		pointsToAllocate[3] = cclass.Agillity;
		baseStatPoints[3]   = cclass.Agillity;

		pointsToAllocate[4] = cclass.Dexterity;
		baseStatPoints[4]   = cclass.Dexterity;

		pointsToAllocate[5] = cclass.Trading;
		baseStatPoints[5]   = cclass.Trading;

		pointsToAllocate[6] = cclass.Luck;
		baseStatPoints[6]   = cclass.Luck;

    }

}
