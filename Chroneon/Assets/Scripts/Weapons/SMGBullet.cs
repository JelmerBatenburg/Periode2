using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGBullet : MonoBehaviour {
    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 startRotation;

	// Use this for initialization
	void Start () {
        transform.Rotate(startRotation);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(movement * Time.deltaTime);
        transform.Rotate(rotation * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Player" || c.gameObject.tag == "Drone" || c.gameObject.tag == "Zone")
        {

        }
        else
        {
            if(c.gameObject.tag == "BigCrystal")
            {
                c.gameObject.GetComponent<BigCrystal>().DMG(1);
            }
            Destroy(gameObject);
        }
    }
}
