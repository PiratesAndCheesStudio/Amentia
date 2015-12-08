/**
* This is the create weapon script
* this will do the follow stuff:
* -----------------------------
* generate a name
* generate a desc
* generate a id
* generate stats
* generate spell effect
* -----------------------------
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;
    private string[] weaponNames = new string[6] 
                                    {
                                        "Pony of Doom",
                                        "Bring the Lighter",
                                        "Find a path",
                                        "Swoard of the beast",
                                        "Homeboy",
                                        "Sample name"
                                    };


    //TESTING
    void Start() {
        createWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Strength.ToString());
        Debug.Log(newWeapon.Intelligence.ToString());
    }

    /**
    * This function will create a weapon
    * 
    * @retrurn void
    */
    public void createWeapon() {
        newWeapon = new BaseWeapon();
        newWeapon.ItemName = "W_" + weaponNames[Random.Range(0, 5)];
        newWeapon.ItemDescription = "A new awsome weapon!";
        newWeapon.ItemID = Random.Range(1, 101);
        newWeapon.Strength = Random.Range(1, 11);
        newWeapon.Intelligence = Random.Range(1, 11);
        chooseWeaponType();
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    /**
    * This will select the type of weapon
    * 
    * @retrurn void
    */
    private void chooseWeaponType() {
        int randTemp = Random.Range(1, 5);
		System.Array weapons = System.Enum.GetValues(typeof(BaseWeapon.WeaponTypes));
		newWeapon.WeaponType = (BaseWeapon.WeaponTypes)weapons.GetValue(Random.Range(0, weapons.Length));
    }

}
