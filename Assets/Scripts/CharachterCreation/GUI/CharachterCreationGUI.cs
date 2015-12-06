/**
* GUI
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class CharachterCreationGUI : MonoBehaviour {

    public enum createCharacterStats {
        CLASSSELECTION,
        STATALLOCATION,
        FINALSETUP
    }

    public static createCharacterStats currentState;
    private CharachterCreationFunctions charCreateFunc = new CharachterCreationFunctions();

	// Use this for initialization
	void Start () {
        currentState = createCharacterStats.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState) {
            case (createCharacterStats.CLASSSELECTION):

                break;
            case (createCharacterStats.STATALLOCATION):

                break;
            case (createCharacterStats.FINALSETUP):

                break;
        }
  
	}

    void OnGUI() {
        charCreateFunc.displayMainItems();
        if (currentState == createCharacterStats.CLASSSELECTION) {
            charCreateFunc.displayClassSelections();
        }
        if (currentState == createCharacterStats.STATALLOCATION) {
            charCreateFunc.displayStatAllocation();
        }
        if (currentState == createCharacterStats.FINALSETUP) {
            charCreateFunc.displayFinalSetUp();
        }
    }
}
