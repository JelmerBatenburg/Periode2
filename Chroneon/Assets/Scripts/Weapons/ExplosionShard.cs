using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionShard : MonoBehaviour {
    public Vector3 startRotation;
    public Vector3 rotation;
    public float fallspeed;
    public float count;
    public Vector3 movement;
    public float speed;
    public float destroyCount;

	// Use this for initialization
	void Start () {
        startRotation.y = Random.Range(180, -180);
        transform.Rotate(startRotation);
        startRotation.z = Random.Range(35, -60);
	}
	
	// Update is called once per frame
	void Update () {
        rotation.z = fallspeed;
        transform.Rotate(rotation * Time.deltaTime);
        count += fallspeed * Time.deltaTime;
        if (count >= 180)
        {
            fallspeed = 0;
        }
        transform.Translate(movement * Time.deltaTime);
        destroyCount += Time.deltaTime;
	}

    private void OnCollisionEnter(Collision c)
    {
        if(destroyCount >= 0.4f)
        {
            Destroy(gameObject);
        }
        if (c.gameObject.tag == "BigCrystal")
        {
            c.gameObject.GetComponent<BigCrystal>().DMG(1);
        }
        if (c.gameObject.tag == "Drone")
        {
            if (c.gameObject.GetComponent<Drone>() == true)
            {
                c.gameObject.GetComponent<Drone>().Damage(8);
            }
        }
        if (c.gameObject.tag == "Roller")
        {
            if (c.gameObject.GetComponent<EnemyRoller>() == true)
            {
                c.gameObject.GetComponent<EnemyRoller>().Damage(6);
            }
        }

        if (c.gameObject.tag == "Boss1")
        {
            c.gameObject.GetComponent<Boss1>().DMG(12);
        }
    }
}
