﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 v;
    private float hor;
    private float ver;
    public float speed;
    private Vector3 r;
    public GameObject cam;
    private Vector3 r2;
    public Rigidbody rig;
    public Vector3 hight;
    private bool allowJump;
    private Vector3 position;
    public RaycastHit jump;
    public RaycastHit wallFront;
    private bool wallJump;
    private bool wall;
    public Vector3 jumpWall;
    public float normalSpeed;
    public float sprintSpeed;
    public Vector3 wallClimb;
    public bool Jetpack;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        v.x = hor;
        v.z = ver;
        transform.Translate(v * Time.deltaTime * speed);
        r.y = Input.GetAxis("Mouse X");
        r2.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(r);
        cam.transform.Rotate(r2);
        if (allowJump == true)
        {
            if (Input.GetButtonDown("Jump") == true)
            {
                rig.velocity = hight;
            }
        }

        if (Input.GetAxisRaw("Sprint") == 1)
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = normalSpeed;
        }

        if (Physics.Raycast(transform.position, -transform.up, out jump, 1.5f))
        {
            allowJump = true;
        }
        else
        {
            allowJump = false;
        }
        Debug.DrawRay(transform.position, -transform.up * 1.5f, Color.green);

        if (Physics.Raycast(transform.position + wallClimb, transform.forward, out wallFront, 0.8f))
        {
            if (wallFront.transform.tag == "Wall")
            {
                wall = true;
                if(Input.GetAxisRaw("Climb") == 1)
                {
                    speed = 0;
                }
            }
        }
        else
        {
            wall = false;
        }
        Debug.DrawRay(transform.position, transform.forward * 1, Color.red);

        if (wall == true)
        {
            if (Input.GetAxisRaw("Climb") == 1)
            {
                rig.velocity = jumpWall;
            }
        }
        if(Jetpack && Input.GetButton("Jump"))
        {
            rig.velocity = jumpWall;
        }
    }
}