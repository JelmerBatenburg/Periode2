using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour {
    public GameObject shopPanel;
    public CharacterMovement player;
    public WeaponManager shoot;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
        shoot = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
    }

    public void Close()
    {
        shopPanel.SetActive(false);
        player.allowMovement = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        shoot.allowShooting = true;
    }
}
