using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmWeapon : MonoBehaviour {
    private float count;
    public int active;
    public float stormFireSpeed;
    public GameObject stormCrystal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        count += Input.GetAxisRaw("Mouse ScrollWheel")*10;
        if (count >= 0.5f)
        {
            active += 1;
            count = 0;
        }
        if(count<= -0.5f)
        {
            active -= 1;
            count = 0;
        }
        if(active == -1)
        {
            active = 3;
        }
        if (active == 4)
        {
            active = 0;
        }
        if(active == 3)
        {
            if (Input.GetAxisRaw("Fire") == 1)
            {
                stormFireSpeed += Time.deltaTime;
                if(stormFireSpeed >= 0.1)
                {
                    GameObject g = Instantiate(stormCrystal, transform.position, transform.rotation);
                    Destroy(g, 0.7f);
                    stormFireSpeed = 0;
                }
            }
        }
	}
}
