using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalStormBullet : MonoBehaviour {
    public Vector3 size;
    public Vector3 move;
    public Vector3 rot;

	// Use this for initialization
	void Start () {
        rot.z = Random.Range(90, -90);
        transform.Rotate(rot);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(move);
        transform.localScale += size * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BigCrystal")
        {
            other.gameObject.GetComponent<BigCrystal>().DMG(1);
        }
        if(other.gameObject.tag == "Drone")
        {
            if(other.gameObject.GetComponent<Drone>() == true)
            {
                other.gameObject.GetComponent<Drone>().Damage(3);
            }
        }
        if (other.gameObject.tag == "Roller")
        {
            if (other.gameObject.GetComponent<EnemyRoller>() == true)
            {
                other.gameObject.GetComponent<EnemyRoller>().Damage(3);
            }
        }

        if (other.gameObject.tag == "Boss1")
        {
            other.gameObject.GetComponent<Boss1>().DMG(5);
        }
    }
}
