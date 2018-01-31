using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoller : MonoBehaviour {
    public Transform sphere;
    public Vector3 r;
    public float speed;
    public Transform player;
    public Vector3 direction;
    public Vector3 newDirection;
    public Vector3 movement;
    public float rotationSpeed;
    public bool disable;
    public Rigidbody playerRig;
    public float force;
    public HealthManager health;
    public float hp;
    public Material off;
    public GameObject lights;
    public GameObject smoke;
    public float acceleration;

	// Use this for initialization
	void Start () {
        health = GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>();
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerRig = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (disable == false)
        {
            speed = movement.z;
            rotationSpeed = movement.z * 0.1f;
            sphere.Rotate(r * Time.deltaTime * -speed);
            direction.x = player.position.x - transform.position.x;
            direction.z = player.position.z - transform.position.z;
            direction.y = transform.position.y - transform.position.y;
            newDirection = Vector3.RotateTowards(transform.forward, direction, Time.deltaTime * rotationSpeed, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            if(movement.z <= 20)
            {
                movement.z += Time.deltaTime * acceleration;
            }
        }
        else
        {
            movement.z = 0;
        }
        transform.Translate(movement * Time.deltaTime);
        if (hp <= 0)
        {
            Instantiate(smoke, transform.position, transform.rotation, gameObject.transform);
            lights.GetComponent<Renderer>().material = off;
            disable = true;
            gameObject.tag = "Zone";
            Destroy(gameObject, 20);
            DestroyImmediate(gameObject.GetComponent<EnemyRoller>());
        }
    }

    private void OnCollisionStay(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            playerRig.AddForce(transform.forward * 10 * force);
        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            health.hp -= (Random.Range(10, 15));
        }
    }

    public void Damage(int dmg)
    {
        hp -= dmg;
    }
}
