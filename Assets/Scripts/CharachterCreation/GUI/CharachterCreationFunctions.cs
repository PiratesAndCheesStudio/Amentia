/**
* Functions for the GUI
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class CharachterCreationFunctions {

    private StatAllocationModule statAllocationModule = new StatAllocationModule();
    private int classSelection;
    
    //If you created a new class don't forget to add the class here!
    private string[] classSelectionNames = new string[] {"Warrior", "Mage"};

    private string playerName = "Player Name";
    private string playerBio ="Player BIO"; //Bio of the char
    private int genderSelection;
    private string[] genderTypes = new string[2] { "Male", "Female" };

    public void displayClassSelections() {
        classSelection = GUI.SelectionGrid(new Rect(50, 50, 250, 200), classSelection, classSelectionNames, 2);
        GUI.Label(new Rect(450, 50, 300, 300), findClassDesc(classSelection));
        GUI.Label(new Rect(450, 100, 300, 300), findClassStats(classSelection));
    }

    public void displayStatAllocation() {
        statAllocationModule.displayStatAllocationModule();
    }

    public void displayFinalSetUp() {
        playerName = GUI.TextArea(new Rect(20, 10, 150, 25), playerName, 25);
        genderSelection = GUI.SelectionGrid(new Rect(290, 10, 100, 80), genderSelection, genderTypes, 1);
        playerBio = GUI.TextArea(new Rect(20, 55, 250, 200), playerBio, 250);
    }

    public void displayMainItems() {
        GUI.Label(new Rect(Screen.width / 2, 20, 250, 250), "CREATE NEW CHAR!");
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;

        //Turn left
        if (GUI.Button(new Rect(550, 300, 50, 50), "<<<")) {
            player.Rotate(Vector3.up * 10);
        }

        //Turn right
        if (GUI.Button(new Rect(750, 300, 50, 50), ">>>")) {
            player.Rotate(Vector3.down * 10);
        }

        //Show the next button only when we are NOT in the final setup
        if (CharachterCreationGUI.currentState != CharachterCreationGUI.createCharacterStats.FINALSETUP) {
            //Next button
            if (GUI.Button(new Rect(825, 300, 50, 50), "Next")) {
                if (CharachterCreationGUI.currentState == CharachterCreationGUI.createCharacterStats.CLASSSELECTION) {
                    chooseClass(classSelection);
                    CharachterCreationGUI.currentState = CharachterCreationGUI.createCharacterStats.STATALLOCATION;
                } else if (CharachterCreationGUI.currentState == CharachterCreationGUI.createCharacterStats.STATALLOCATION) {
                    GameInfo.PlayerClass.Stamina       	= statAllocationModule.pointsToAllocate[0];
					GameInfo.PlayerClass.Intellect   	= statAllocationModule.pointsToAllocate[1];
					GameInfo.PlayerClass.Strength		= statAllocationModule.pointsToAllocate[2];
					GameInfo.PlayerClass.Agillity		= statAllocationModule.pointsToAllocate[3];
					GameInfo.PlayerClass.Dexterity		= statAllocationModule.pointsToAllocate[4];
					GameInfo.PlayerClass.Trading		= statAllocationModule.pointsToAllocate[5];
					GameInfo.PlayerClass.Luck			= statAllocationModule.pointsToAllocate[6];
					GameInfo.PlayerClass.Crit			= statAllocationModule.pointsToAllocate[7];
                    CharachterCreationGUI.currentState 	= CharachterCreationGUI.createCharacterStats.FINALSETUP;
                }
            }
        } else {
            if (GUI.Button(new Rect(825, 300, 50, 50), "Finish")) {
                //AS_TODO: final save
                GameInfo.PlayerName = playerName;
                if (genderSelection == 0) {
                    GameInfo.isMale = true;
                } else {
                    GameInfo.isMale = false;
                }
                Save.saveAllInfos();
            }
        }

        //Show the next button only when we are NOT in the final setup
        if (CharachterCreationGUI.currentState != CharachterCreationGUI.createCharacterStats.CLASSSELECTION) {
            //Back button
            if (GUI.Button(new Rect(425, 300, 50, 50), "Back")) {
                if (CharachterCreationGUI.currentState == CharachterCreationGUI.createCharacterStats.STATALLOCATION) {
                    statAllocationModule.didRunOnce = false;
                    GameInfo.PlayerClass = null;
                    CharachterCreationGUI.currentState = CharachterCreationGUI.createCharacterStats.CLASSSELECTION;
                } else if (CharachterCreationGUI.currentState == CharachterCreationGUI.createCharacterStats.FINALSETUP) {
                    CharachterCreationGUI.currentState = CharachterCreationGUI.createCharacterStats.STATALLOCATION;
                }
           }
        }
    }

    //===============================
    //PRIVATE METHODES!
    //===============================

    private string findClassDesc(int classType) {
        string nothingFound = "Nothing found!";

        if (classSelection == 0) {
            BaseCharachterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        } else if (classSelection == 1) {
            BaseCharachterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }

        return nothingFound;
    }

    private string findClassStats(int classType) {
        string nothingFound = "No stats found!";

        if (classType == 0) {
            BaseCharachterClass tempClass = new BaseWarriorClass();
            string tempStats = "Strenght: " + tempClass.Stamina + "\n" + 
					"Intelligence: " + tempClass.Intellect + "\n" + 
					"Strength: " + tempClass.Strength  + "\n" + 
					"Agillity: " + tempClass.Agillity + "\n" +
					"Dexterity: " + tempClass.Dexterity + "\n" +
					"Trading: " + tempClass.Trading + "\n" +
					"Luck: " + tempClass.Luck + "\n" +
					"Crit: " + tempClass.Crit;
            return tempStats;
        } else if (classType == 1) {
            BaseCharachterClass tempClass = new BaseMageClass();
			string tempStats = "Strenght: " + tempClass.Stamina + "\n" + 
				"Intelligence: " + tempClass.Intellect + "\n" + 
					"Strength: " + tempClass.Strength  + "\n" + 
					"Agillity: " + tempClass.Agillity + "\n" +
					"Dexterity: " + tempClass.Dexterity + "\n" +
					"Trading: " + tempClass.Trading + "\n" +
					"Luck: " + tempClass.Luck + "\n" +
					"Crit: " + tempClass.Crit;
            return tempStats;
        }

        return nothingFound;
    }

    private void chooseClass(int classType) {
        if (classType == 0) {
            GameInfo.PlayerClass = new BaseWarriorClass();
        } else if (classType == 1) {
            GameInfo.PlayerClass = new BaseMageClass();
        }
    }
}
