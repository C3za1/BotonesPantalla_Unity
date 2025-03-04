﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    protected Joystick joystick;
    protected Joystick joybutton;

    protected bool jump;


    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joystick = FindObjectOfType<Joystick>();

    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f + Input.GetAxis("Horizontal")*100f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 100f + Input.GetAxis("Vertical")*100f);

        if(!jump && joybutton.Pressed || Input.GetButton("Fire2"))
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 100f;
        }

        if (jump && !joybutton.Pressed || Input.GetButton("Fire2"))
        {
            jump = false;
        }

    }
}
