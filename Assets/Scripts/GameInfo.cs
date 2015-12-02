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

    public static string PlayerName {get;set;}
    public static int PlayerLevel { get; set; }
    public static BaseCharachterClass PlayerClass { get; set; }
    public static int Initiative { get; set; }
    public static int Strength { get; set; }
    public static int Constitution { get; set; }
    public static int Intelligence { get; set; }
    public static int Ac { get; set; }
    public static int Speed { get; set; }
}
