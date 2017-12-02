using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {
    public int hp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoseHP(int dmg)
    {
        hp -= dmg;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
