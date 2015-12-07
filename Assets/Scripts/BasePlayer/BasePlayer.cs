/**
* This is the BasePlayer Class
* Just look what you edit here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class BasePlayer {

    //Class vars
    private string playerName;
    private int playerLevel;
    private BaseCharachterClass playerClass;

    //Char stuff
    private int gold;
    private int statPointsToAllocate;

    //Level stuff
    private int currentXP;
    private int requiredXP;

    //Getters and Setter!
    public int CurrentXP {get; set;}
    public int RequiredXP { get; set; }
    public int StatPointsToAllocate { get; set; }

    public string PlayerName {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseCharachterClass PlayerClass {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Gold { get; set; }

}
