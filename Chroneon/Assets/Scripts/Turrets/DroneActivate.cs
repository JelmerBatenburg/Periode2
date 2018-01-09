using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneActivate : MonoBehaviour {
    public GameObject drone;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            drone.GetComponent<Drone>().active = true;
            drone.GetComponent<Drone>().player = other.gameObject.transform;
        }
    }

    public void OnTriggerExit(Collider oth)
    {
        if (oth.gameObject.tag == "Player")
        {
            drone.GetComponent<Drone>().active = false;
        }
    }
}
