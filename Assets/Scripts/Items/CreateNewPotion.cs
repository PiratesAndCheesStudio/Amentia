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
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType.ToString());
    }

    public void createPotion() {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "A new awsome potion!";
        newPotion.ItemID = Random.Range(1, 101);
        choosePotionType();
    }

    private void choosePotionType() {
        int randTemp = Random.Range(1, 4);

        switch (randTemp) {
            case 1:
                newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
                break;
            case 2:
                newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
                break;
            case 3:
                newPotion.PotionType = BasePotion.PotionTypes.MANA;
                break;
            case 4:
                newPotion.PotionType = BasePotion.PotionTypes.SPEED;
                break;
        }
    }
}
