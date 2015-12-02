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
    private int initiative;
    private int strength;
    private int constitution;
    private int intelligence;
    private int ac;
    private int speed;

    //Getters and Setter!
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

    public int Initiative {
        get { return initiative; }
        set { initiative = value; }
    }

    public int Strength {
        get { return strength; }
        set { strength = value; }
    }

    public int Constitution {
        get { return constitution; }
        set { constitution = value; }
    }

    public int Intelligence {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public int Ac {
        get { return ac; }
        set { ac = value; }
    }

    public int Speed {
        get { return speed; }
        set { speed = value; }
    }


}
