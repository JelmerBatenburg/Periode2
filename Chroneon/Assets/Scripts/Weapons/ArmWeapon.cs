﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmWeapon : MonoBehaviour {
    private float count;
    public int active;
    private float stormFireSpeed;
    public GameObject stormCrystal;
    public GameObject explodeCrystal;
    private float explosionSpeed;
    public GameObject shotgunShard;
    private float shotgunFireSpeed;
    public GameObject smgBullet;
    private float smgSpeed;
    private float pistolSpeed;
    private bool pistolShoot;
    private bool shotgunAllowShoot;
    public GameObject missle;
    private float missleSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        count += Input.GetAxisRaw("Mouse ScrollWheel")*10;
        if (count >= 0.5f)
        {
            active += 1;
            count = 0;
        }
        if(count<= -0.5f)
        {
            active -= 1;
            count = 0;
        }
        if(active == -1)
        {
            active = 5;
        }
        if (active == 6)
        {
            active = 0;
        }
        //Flamethrower
        if(active == 5)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                stormFireSpeed += Time.deltaTime;
                if(stormFireSpeed >= 0.1)
                {
                    GameObject g = Instantiate(stormCrystal, transform.position, transform.rotation);
                    Destroy(g, 0.7f);
                    stormFireSpeed = 0;
                }
            }
        }
        //FragGrenade
        if (active == 3)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                 explosionSpeed += Time.deltaTime;
                if (explosionSpeed >= 0.8f)
                {
                    GameObject g = Instantiate(explodeCrystal, transform.position, transform.rotation);
                    Destroy(g, 8);
                    explosionSpeed = 0;
                }
            }
        }
        //Shotgun
        if (active == 2)
        {
            if(shotgunAllowShoot == false)
            {
                shotgunFireSpeed += Time.deltaTime;
            }
            if (Input.GetAxisRaw("Fire") == 1)
            {
                if(shotgunAllowShoot == true)
                {
                    shotgunAllowShoot = false;
                    if (shotgunFireSpeed <= 0.02f)
                    {
                        GameObject s1 = Instantiate(shotgunShard, transform.position, transform.rotation);
                        Destroy(s1, 1);
                        GameObject s2 = Instantiate(shotgunShard, transform.position, transform.rotation);
                        Destroy(s2, 1);
                        GameObject s3 = Instantiate(shotgunShard, transform.position, transform.rotation);
                        Destroy(s3, 1);
                        GameObject s4 = Instantiate(shotgunShard, transform.position, transform.rotation);
                        Destroy(s4, 1);
                        GameObject s5 = Instantiate(shotgunShard, transform.position, transform.rotation);
                        Destroy(s5, 1);
                        GameObject s6 = Instantiate(shotgunShard, transform.position, transform.rotation);
                    }
                }
                if(shotgunFireSpeed >= 0.8f)
                {

                    shotgunFireSpeed = 0;
                    shotgunAllowShoot = true;
                }
            }
        }
        //SMG
        if (active == 1)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                smgSpeed += Time.deltaTime;
                if (smgSpeed >= 0.05f)
                {
                    GameObject g = Instantiate(smgBullet, transform.position, transform.rotation);
                    Destroy(g, 3);
                    smgSpeed = 0;
                }
            }
        }
        //Pistol
        if (active == 0)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                pistolSpeed += Time.deltaTime;
                if (pistolSpeed >= 0.3f)
                {
                    GameObject g = Instantiate(smgBullet, transform.position, transform.rotation);
                    Destroy(g, 3);
                    pistolSpeed = 0;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                pistolShoot = true;
                GameObject g = Instantiate(smgBullet, transform.position, transform.rotation);
                Destroy(g, 3);
            }
            if (Input.GetButtonUp("Fire1"))
            {
                pistolShoot = false;
                pistolSpeed = 0;
            }
        }
        //Missle
        if(active == 4)
        {
            if(Input.GetAxisRaw("Fire") == 1)
            {
                missleSpeed += Time.deltaTime;
                if(missleSpeed >= 0.8f)
                {
                    missleSpeed = 0;
                    GameObject g = Instantiate(missle, transform.position, transform.rotation);
                    Destroy(g, 8);
                }
            }
        }
    }
}
