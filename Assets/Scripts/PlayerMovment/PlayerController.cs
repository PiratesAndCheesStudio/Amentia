﻿/**
* Handels the Player Movement
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float rotateSpeed;
    public float forwardSpeed;
    private CharacterController playerController;

	// Use this for initialization
	void Start () {
        playerController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && playerController.isGrounded) {
            playerController.Move(Vector3.up);
        }

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.back);
        float speed = forwardSpeed * Input.GetAxis("Vertical");
        playerController.SimpleMove(speed * forward);

        if (Input.GetAxis("Run") == 1 && playerController.isGrounded) {
            forwardSpeed = forwardSpeed * 1.5f;

        }

	}
}
