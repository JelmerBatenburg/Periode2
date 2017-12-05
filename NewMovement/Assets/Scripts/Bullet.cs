using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Vector3 m;
    public GameObject particle;
    public GameObject flash;
    public bool spawn;
    public Vector3 r;
    public int randomR1;
    public int randomR2;
    public Vector3 scale;

	// Use this for initialization
	void Start () {
        r.y = Random.Range(randomR1, randomR2);
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
            transform.Rotate(r);
        }
        gameObject.transform.localScale += scale * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
