using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCrystal : MonoBehaviour {
    public GameObject crystal;
    public float hp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hp <= 0)
        {
            Instantiate(crystal, transform.position, Quaternion.identity);
            Instantiate(crystal, transform.position, Quaternion.identity);
            Instantiate(crystal, transform.position, Quaternion.identity);
            Instantiate(crystal, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
	}
    public void DMG(int damage)
    {
        hp -= damage;
    }
}
