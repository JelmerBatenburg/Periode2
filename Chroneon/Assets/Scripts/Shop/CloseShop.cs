using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour {
    public GameObject shopPanel;
    public CharacterMovement player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
    }

    public void Close()
    {
        shopPanel.SetActive(false);
        player.allowMovement = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
