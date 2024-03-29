﻿/*
 * Devun Schneider
 * Prototype 1
 * Adds player object movement based on key input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move Forward w forward input
        transform.Translate(Vector3.forward * Time.deltaTime *speed*forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
}
