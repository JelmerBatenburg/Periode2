using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {
    public GameObject ball;
    public GameObject shopPanel;
    public CharacterMovement player;
    public GameObject use;
    public RaycastHit check;

	// Use this for initialization
	void Start () {
        shopPanel.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(ball.transform.position, ball.transform.forward, out check, 5))
        {
            if(check.transform.tag == "Player")
            {
                use.SetActive(true);
                
                if (Input.GetButtonDown("Use"))
                {
                    OpenShop();
                }
            }
        }
        else
        {
            use.SetActive(false);

        }
        Debug.DrawRay(ball.transform.position, ball.transform.forward * 5, Color.green);
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            ball.transform.LookAt(other.transform);
        }
    }
    public void OpenShop()
    {
        shopPanel.SetActive(true);
        player.allowMovement = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void CloseShop()
    {
        shopPanel.SetActive(false);
        player.allowMovement = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
