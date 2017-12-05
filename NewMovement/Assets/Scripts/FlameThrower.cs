using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour {
    public GameObject litFam;
    public float counter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Flame") == 1)
        {
            counter += Time.deltaTime;
            if(counter >= 0.03)
            {
                counter = 0;
                GameObject f = Instantiate(litFam, transform.position, transform.rotation);
                Destroy(f, 0.7f);
            }
        }

	}
}
