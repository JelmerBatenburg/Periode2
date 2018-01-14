using System.Collections;
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
    public EnergyManager energyScript;
    public float stormEnergy;
    public float explodeEnergy;
    public float shotgunEnergy;
    public float smgEnergy;
    public float pistolEnergy;
    public float missleEnergy;
    public GameObject pistolBullet;
    public CurrentWeapon ui;

	// Use this for initialization
	void Start () {
        energyScript = GameObject.FindWithTag("EnergyManager").GetComponent<EnergyManager>();
        ui = GameObject.FindWithTag("CurrentWeapon").GetComponent<CurrentWeapon>();
	}
	
	// Update is called once per frame
	void Update () {
        count += Input.GetAxisRaw("Mouse ScrollWheel")*10;
        if (count >= 0.5f)
        {
            active += 1;
            count = 0;
            ui.Check();
        }
        if(count<= -0.5f)
        {
            active -= 1;
            count = 0;
            ui.Check();
        }
        if(active == -1)
        {
            active = 5;
            ui.Check();
        }
        if (active == 6)
        {
            active = 0;
            ui.Check();
        }
        //CrystalStorm
        if(active == 5)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                if(energyScript.energy >= stormEnergy)
                {
                    stormFireSpeed += Time.deltaTime;
                    if (stormFireSpeed >= 0.1)
                    {
                        GameObject g = Instantiate(stormCrystal, transform.position, transform.rotation);
                        Destroy(g, 0.7f);
                        stormFireSpeed = 0;
                        energyScript.energy -= stormEnergy;
                    }
                }
            }
        }
        //FragGrenade
        if (active == 3)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                if(energyScript.energy >= explodeEnergy)
                {
                    explosionSpeed += Time.deltaTime;
                    if (explosionSpeed >= 0.8f)
                    {
                        GameObject g = Instantiate(explodeCrystal, transform.position, transform.rotation);
                        Destroy(g, 8);
                        explosionSpeed = 0;
                        energyScript.energy -= explodeEnergy;
                    }
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
                if(energyScript.energy >= shotgunEnergy)
                {
                    if (shotgunAllowShoot == true)
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
                            Destroy(s6, 1);
                            energyScript.energy -= shotgunEnergy;
                        }
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
                if(energyScript.energy >= smgEnergy)
                {
                    smgSpeed += Time.deltaTime;
                    if (smgSpeed >= 0.05f)
                    {
                        GameObject g = Instantiate(smgBullet, transform.position, transform.rotation);
                        Destroy(g, 3);
                        smgSpeed = 0;
                        energyScript.energy -= smgEnergy;
                    }
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
                    if(energyScript.energy >= pistolEnergy)
                    {
                        GameObject g = Instantiate(pistolBullet, transform.position, transform.rotation);
                        Destroy(g, 3);
                        pistolSpeed = 0;
                        energyScript.energy -= pistolEnergy;
                    }
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if(energyScript.energy >= pistolEnergy)
                {
                    pistolShoot = true;
                    GameObject g = Instantiate(smgBullet, transform.position, transform.rotation);
                    Destroy(g, 3);
                    energyScript.energy -= pistolEnergy;
                }
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
                if(energyScript.energy >= missleEnergy)
                {
                    missleSpeed += Time.deltaTime;
                    if (missleSpeed >= 0.8f)
                    {
                        missleSpeed = 0;
                        GameObject g = Instantiate(missle, transform.position, transform.rotation);
                        Destroy(g, 8);
                        energyScript.energy -= missleEnergy;
                    }
                }
            }
        }
    }
}
