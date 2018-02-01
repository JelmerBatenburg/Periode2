using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour {
    public GameObject menu;
    public WeaponManager weapon;
    public CharacterMovement movement;
    public bool active;

    void Start()
    {
        weapon = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
        movement = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
    }

    void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if(active == true)
            {
                OnButtonPressExit();
            }
            else
            {
                OnButtonPress();
            }
        }
	}

    public void OnButtonPress()
    {
        weapon.allowShooting = false;
        movement.allowMovement = false;
        menu.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        active = true;
        Time.timeScale = 0;
    }

    public void OnButtonPressExit()
    {
        weapon.allowShooting = true;
        movement.allowMovement = true;
        menu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        active = false;
        Time.timeScale = 1;
    }
}
