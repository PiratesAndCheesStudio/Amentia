/**
* Little but usefull, it will store our data
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static bool isMale { get; set; }
    public static BaseEquipement EquipmentOne { get; set; }
    public static string PlayerName {get;set;}
    public static int PlayerLevel { get; set; }
    public static BaseCharachterClass PlayerClass { get; set; }
    public static int Initiative { get; set; }
    public static int Strength { get; set; }
    public static int Constitution { get; set; }
    public static int Intelligence { get; set; }
    public static int Ac { get; set; }
    public static int Speed { get; set; }
    public static int Gold { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }
}
