using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    public HealthManager hp;
    public WeaponManager weapon;
    public CrystalManager crystal;
    public CharacterMovement movement;
    public Vector3 start;
    public Transform spawn;
    public GameObject frag;
    public GameObject missle;
    public GameObject storm;
    public GameObject shotgun;
    public GameObject smg;
    public GameObject menu;
    public int scene;

	// Use this for initialization
	void Start () {
        hp = GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>();
        weapon = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
        movement = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
        spawn = GameObject.FindWithTag("SpawnPoint").transform;
        start = spawn.position;
        crystal = GameObject.FindWithTag("CrystalManager").GetComponent<CrystalManager>();
	}
	
	public void OnButtonPress()
    {
        hp.hp = 100;
        hp.maxHp = 100;
        weapon.crystalStormSlot = 666;
        weapon.smgSlot = 666;
        weapon.shotgunSlot = 666;
        weapon.fragSlot = 666;
        weapon.weaponAmount = 0;
        weapon.missleSlot = 666;
        frag.SetActive(true);
        missle.SetActive(true);
        storm.SetActive(true);
        shotgun.SetActive(true);
        smg.SetActive(true);
        menu.SetActive(false);
        Time.timeScale = 1;
        movement.allowMovement = true;
        weapon.allowShooting = true;
        spawn.position = start;
        GameObject.FindWithTag("Player").transform.position = spawn.position;
        crystal.crystal = 0;
        crystal.AddCrystal(0);
        scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
