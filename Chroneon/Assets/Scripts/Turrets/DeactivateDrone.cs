using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateDrone : MonoBehaviour {
    public Drone check;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            check.movement = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            check.movement = true;
        }
    }
}
