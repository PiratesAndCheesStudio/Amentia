/**
* This is the create potion script
* this will do the follow stuff:
* -----------------------------
* generate a name
* generate a desc
* generate a id
* -----------------------------
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/

using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

    private BasePotion newPotion;


    //TESTING
    void Start() {
        createPotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID);
        Debug.Log(newPotion.PotionType);
    }

    public void createPotion() {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "A new awsome potion!";
        newPotion.ItemID = Random.Range(1, 101);
        choosePotionType();
    }

    private void choosePotionType() {
		System.Array potions = System.Enum.GetValues(typeof(BasePotion.PotionTypes));
		newPotion.PotionType = (BasePotion.PotionTypes)potions.GetValue(Random.Range(0, potions.Length));
    }
}
