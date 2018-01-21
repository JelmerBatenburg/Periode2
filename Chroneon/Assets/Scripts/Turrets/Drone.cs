using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour {
    public float speed;
    public bool active;
    public Transform player;
    public Vector3 hight;
    public float lookSpeed;
    public Vector3 direction;
    public Vector3 newDirection;
    public float shootTimer;
    public GameObject bullet;
    public GameObject barrel;
    public GameObject zone;
    public bool movement = true;
    public float hp = 100;
    public GameObject droneLight;
    public Material off;
    public GameObject particle;
    public GameObject smoke;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(active == true)
        {
            direction = player.position - transform.position;
            newDirection = Vector3.RotateTowards(transform.forward, direction, lookSpeed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            shootTimer +=Time.deltaTime;
            if (movement)
            {
                transform.position = Vector3.MoveTowards(gameObject.transform.position, player.position + hight, Time.deltaTime * speed);
            }
            if(shootTimer >= 0.8)
            {
                shootTimer = 0;
                GameObject g = Instantiate(bullet, barrel.transform.position, transform.rotation);
                Destroy(g, 2);
            }
        }
        if(hp <= 0)
        {
            gameObject.AddComponent<Rigidbody>();
            Instantiate(smoke, transform.position, transform.rotation, gameObject.transform);
            droneLight.GetComponent<Renderer>().material = off;
            active = false;
            Destroy(gameObject,20);
            DestroyImmediate(gameObject.GetComponent<Drone>());
            DestroyImmediate(particle);
        }
	}
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            movement = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            movement = true;
        }
    }

    public void Damage(int dmg)
    {
        hp -= dmg;
    }
}