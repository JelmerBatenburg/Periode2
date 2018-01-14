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

	// Use this for initialization
	void Start () {
        pistol.SetActive(true);
        smg.SetActive(false);
        shotgun.SetActive(false);
        burst.SetActive(false);
        missle.SetActive(false);
        storm.SetActive(false);
        weapon = GameObject.FindWithTag("Arm").GetComponent<ArmWeapon>();
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
        if (weapon.active == 1)
        {
            pistol.SetActive(false);
            smg.SetActive(true);
            shotgun.SetActive(false);
            burst.SetActive(false);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == 2)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(true);
            burst.SetActive(false);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == 3)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(false);
            burst.SetActive(true);
            missle.SetActive(false);
            storm.SetActive(false);
        }
        if (weapon.active == 4)
        {
            pistol.SetActive(false);
            smg.SetActive(false);
            shotgun.SetActive(false);
            burst.SetActive(false);
            missle.SetActive(true);
            storm.SetActive(false);
        }
        if (weapon.active == 5)
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
