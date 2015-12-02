/**
* This is the create gear script
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

public class CreateNewEquipment : MonoBehaviour {

    private BaseEquipement newEquipment;
    private string[] equipmentNames = new string[6]
                                    {
                                        "Armor of Hell",
                                        "Simple created armor",
                                        "Simple a path",
                                        "Armor of Knight",
                                        "Pice of Picey",
                                        "Sample Armor"
                                    };

    //TESTING
    void Start() {
        createEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log(newEquipment.EquipementType.ToString());
        Debug.Log(newEquipment.Strength.ToString());
        Debug.Log(newEquipment.Intelligence.ToString());
    }

    /**
    * This function will create a gear part
    * 
    * @retrurn void
    */
    public void createEquipment() {
        newEquipment = new BaseEquipement();
        newEquipment.ItemName = "I_" + equipmentNames[Random.Range(0, 5)];
        newEquipment.ItemDescription = "A new awsome gear!";
        newEquipment.ItemID = Random.Range(1, 101);
        chooseEquipmentType();
        newEquipment.Strength = Random.Range(1, 11);
        newEquipment.Intelligence = Random.Range(1, 11);
        newEquipment.SpellEffectID = Random.Range(1, 101);
    }

    /**
    * This will select the type of gear
    * 
    * @retrurn void
    */
    private void chooseEquipmentType() {
        int randTemp = Random.Range(1, 8);

        switch (randTemp) {

            case 1:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.HEAD;
                break;
            case 2:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.SHOULDERS;
                break;
            case 3:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.CHEAST;
                break;
            case 4:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.LEGS;
                break;
            case 5:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.FEET;
                break;
            case 6:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.RING;
                break;
            case 7:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.NECK;
                break;
            case 8:
                newEquipment.EquipementType = BaseEquipement.EquipementTypes.EARRING;
                break;
        }
    }

}
