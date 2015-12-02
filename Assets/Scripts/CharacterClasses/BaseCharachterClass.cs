/**
* This is the basic class for all classes
* so look what you change here!
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class BaseCharachterClass {

    //Define the name and the desc of the class
    private string charachterClassName;
    private string charachterClassDescription;

    //Stats
    private int initiative;
    private int strength;
    private int constitution;
    private int intelligence;
    private int ac;
    private int speed;

    //Getter and setters for the stuff in c# style bitch!
    public string CharacterClassName {
        get {return charachterClassName;}
        set {charachterClassName = value;}
    }

    public string CharacterClassDescription {
        get {return charachterClassDescription;}
        set {charachterClassDescription = value;}
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
