/**
* This is the create scroll script
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

public class CreateNewScroll : MonoBehaviour {

    private BaseScroll newScroll;


    //TESTING
    void Start() {
        createScroll();
        Debug.Log(newScroll.ItemName);
        Debug.Log(newScroll.ItemDescription);
        Debug.Log(newScroll.ItemID.ToString());
        Debug.Log(newScroll.SpellEffectID.ToString());
    }

    public void createScroll() {
        newScroll = new BaseScroll();
        newScroll.ItemName = "Scroll";
        newScroll.ItemDescription = "A new awsome scroll!";
        newScroll.ItemID = Random.Range(1, 101);
        newScroll.SpellEffectID = Random.Range(500, 1001);
    }
}
