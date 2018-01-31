using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour {
    public GameObject menu;
    public WeaponManager weapon;
    public CharacterMovement movement;

    void Start()
    {
        weapon = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
        movement = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
    }

    void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            OnButtonPress();
        }
	}

    public void OnButtonPress()
    {
        gameObject.SetActive(false);
        weapon.allowShooting = false;
        movement.allowMovement = false;
        menu.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
