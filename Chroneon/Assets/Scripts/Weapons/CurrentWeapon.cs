using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour {
    public ArmWeapon weapon;
    public GameObject pistol;
    public GameObject smg;
    public GameObject shotgun;
    public GameObject burst;
    public GameObject missle;
    public GameObject storm;
    public WeaponManager check;

	// Use this for initialization
	void Start () {
        pistol.SetActive(true);
        smg.SetActive(false);
        shotgun.SetActive(false);
        burst.SetActive(false);
        missle.SetActive(false);
        storm.SetActive(false);
        weapon = GameObject.FindWithTag("Arm").GetComponent<ArmWeapon>();
        check = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
    }

    public void Check()
    {
        if(weapon.active == 0)
        {
            pistol.SetActive(true);
            smg.SetActive(false);
            shotgun.SetActive(false);
            burst.SetActive(false);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == check.smgSlot)
        {
            pistol.SetActive(false);
            smg.SetActive(true);
            shotgun.SetActive(false);
            burst.SetActive(false);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == check.shotgunSlot)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(true);
            burst.SetActive(false);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == check.fragSlot)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(false);
            burst.SetActive(true);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == check.missleSlot)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(false);
            burst.SetActive(false);
            missle.SetActive(true);
            storm.SetActive(false);
        }
        if (weapon.active == check.crystalStormSlot)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(false);
            burst.SetActive(false);
            missle.SetActive(false);
            storm.SetActive(true);
        }
    }
}
