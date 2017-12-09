using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGBullet : MonoBehaviour {
    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 startRotation;

	// Use this for initialization
	void Start () {
        rotation.z = Random.Range(90, -90);
        startRotation.x = Random.Range(1, -1);
        startRotation.y = Random.Range(1, -1);
        transform.Rotate(startRotation);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(movement * Time.deltaTime);
        transform.Rotate(rotation * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Player")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
