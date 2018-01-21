using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunShard : MonoBehaviour {
    private Vector3 startRotation;
    public Vector3 movement;

	// Use this for initialization
	void Start () {
        startRotation.z = Random.Range(180, -180);
        startRotation.x = Random.Range(0, 12);
        startRotation.y = Random.Range(0, 12);
        transform.Rotate(startRotation);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(movement * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Zone" || other.gameObject.tag == "ShotgunBullet")
        {

        }
        else
        {
            if (other.gameObject.tag == "BigCrystal")
            {
                other.gameObject.GetComponent<BigCrystal>().DMG(1);
            }
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Drone")
        {
            if (other.gameObject.GetComponent<Drone>() == true)
            {
                other.gameObject.GetComponent<Drone>().Damage(12);
            }
        }
        if (other.gameObject.tag == "Boss1")
        {
            other.gameObject.GetComponent<Boss1>().DMG(13);
        }
    }
}
