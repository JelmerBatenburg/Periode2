﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeCrystal : MonoBehaviour {
    public Vector3 movement;
    public GameObject shard;
    public Rigidbody hight;
    public Vector3 hightThrow;
    public Vector3 r;
    public Vector3 addedHight;

	// Use this for initialization
	void Start () {
        hight.velocity = hightThrow;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(movement * Time.deltaTime);
	}

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

        }
        else
        {
            GameObject s1 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s1, 4);
            GameObject s2 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s2, 4);
            GameObject s3 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s3, 4);
            GameObject s4 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s4, 4);
            GameObject s5 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s5, 4);
            GameObject s6 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s6, 4);
            GameObject s7 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s7, 4);
            GameObject s8 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s8, 4);
            GameObject s9 = Instantiate(shard, transform.position + addedHight, transform.rotation);
            Destroy(s9, 4);
            Destroy(gameObject);
        }
    }
}
