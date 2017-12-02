using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTrigger : MonoBehaviour {
    public GameObject turret;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            turret.GetComponent<Turret>().start = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            turret.GetComponent<Turret>().start = false;
        }
    }
}
