using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1SpikeSpawner : MonoBehaviour {
    public Vector3 movement;
    public float counter;
    public GameObject crystal;
    public float spawnRate;
    public Vector3 size;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1.4f);
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        transform.Translate(movement*Time.deltaTime);

        if(counter >= spawnRate)
        {
            counter = 0;
            GameObject g = Instantiate(crystal, transform.position, transform.rotation);
            g.transform.localScale = size;
            size *= 1.2f;
        }
	}
}
