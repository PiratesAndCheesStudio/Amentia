/**
* Handels the Player Movement
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    //Some public stuff
    public float moveSpeed = 100f;
    public float rotateSpeed = 5.0f;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift)){
            moveSpeed = 20f;
        }
        if (!Input.GetKey(KeyCode.LeftShift)) {
            moveSpeed = 10f;
        }
        if (Input.GetKey("w")) {
            transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s")) {
            transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a")) {
            transform.Rotate((Vector3.down) * rotateSpeed);
        }
        if (Input.GetKey("d")) {
            transform.Rotate((Vector3.up) * rotateSpeed);
        }

    }
}
