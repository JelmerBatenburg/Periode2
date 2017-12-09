using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public float resultaatDamage;
    public float extraDmg;
    public RaycastHit enemy;
    public float damageX;
    public float startDamage;
    public float normalDamage1;
    public float normalDamage2;
    public float raycastRange;

	// Use this for initialization
	void Start () {
        extraDmg = startDamage;
	}
	
	// Update is called once per frame
	void Update () {
        if(Physics.Raycast(transform.position,transform.forward, out enemy, raycastRange))
        {
            if(enemy.transform.gameObject.tag == "Enemy")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    resultaatDamage = Damage(Random.Range(normalDamage1,normalDamage2));
                }
            }
        }
	}

    private void OnTriggerEnter(Collider o)
    {
        if (o.gameObject.tag == "DMG-Pickup")
        {
            extraDmg += damageX;
            Destroy(o.gameObject);
        }
    }

    public float Damage(float normalDamage)
    {
        return normalDamage * extraDmg;
    }
}
