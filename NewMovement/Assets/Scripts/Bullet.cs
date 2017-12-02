using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Vector3 m;
    public GameObject particle;
    public GameObject flash;
    public bool spawn;

	// Use this for initialization
	void Start () {
        m.z = 0.5f;
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(m);
        if(spawn == false)
        {
            spawn = true;
            GameObject p = Instantiate(particle, transform.position, transform.rotation);
            GameObject f = Instantiate(flash, transform.position, transform.rotation);
            Destroy(p, 0.3f);
            Destroy(f, 0.1f);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
