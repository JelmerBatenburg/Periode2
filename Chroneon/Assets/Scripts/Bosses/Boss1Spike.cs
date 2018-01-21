using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Spike : MonoBehaviour {
    private float dmg;
    private Vector3 rotation;
    
	void Start () {
        dmg = Random.Range(8, 12);
        Destroy(gameObject, 5);
        rotation.y = Random.Range(180, -180);
        transform.Rotate(rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>().hp -= dmg;
            Destroy(gameObject);
        }
    }
}
