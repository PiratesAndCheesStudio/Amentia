/**
* This machine will handle all the combat states!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

    public enum BattleStates {
        START,
        PLAYERTURN,
        ENEMYTURN,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	void Start () {
        currentState = BattleStates.START;
	}

	void Update () {
        Debug.Log(currentState);
        switch (currentState) {
            case (BattleStates.START):
                break;
            case (BattleStates.PLAYERTURN):
                break;
            case (BattleStates.ENEMYTURN):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                break;
        }	
	}

    void OnGUI() {
        if (GUILayout.Button("NEXT STATE")) {
            if (currentState == BattleStates.START) {
                currentState = BattleStates.PLAYERTURN;
            } else if (currentState == BattleStates.PLAYERTURN) {
                currentState = BattleStates.ENEMYTURN;
            } else if (currentState == BattleStates.ENEMYTURN) {
                currentState = BattleStates.LOSE;
            } else if (currentState == BattleStates.LOSE) {
                currentState = BattleStates.WIN;
            } else if (currentState == BattleStates.WIN) {
                currentState = BattleStates.START;
            }
        }
    }
}
