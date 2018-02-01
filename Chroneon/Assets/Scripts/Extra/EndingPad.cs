using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingPad : MonoBehaviour {
    public GameObject endScreen;
    public CharacterMovement movement;
    public WeaponManager weapon;

    private void Start()
    {
        movement = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
        weapon = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            movement.allowMovement = false;
            weapon.allowShooting = false;
            endScreen.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
