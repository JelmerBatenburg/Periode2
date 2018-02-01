using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public Transform head;
    public Transform player;
    private Vector3 direction;
    public Vector3 movement;
    public bool active;
    public float attack;
    public int currentAttack;
    public float dashSpeed;
    public GameObject crystalSpawner;
    public GameObject crystalSpike;
    public Vector3 ground;
    public float hp;
    public GameObject teleportPad;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            active = false;
            transform.localScale *= Time.deltaTime;
            Destroy(gameObject);
            teleportPad.SetActive(true);
        }

        if(movement.z >= 5)
        {
            movement.z -= Time.deltaTime * 15;
        }
        if (active)
        {
            head.LookAt(player);
            direction.x = player.position.x;
            direction.z = player.position.z;
            direction.y = transform.position.y;
            transform.LookAt(direction);
            transform.Translate(movement * Time.deltaTime);
            attack += Time.deltaTime;
            if(attack >= 2)
            {
                currentAttack = Random.Range(1,4);
                attack = 0;
            }

            //Dash
            if(currentAttack == 1)
            {
                movement.z = dashSpeed;
                currentAttack = 0;
            }

            //Spikes
            if(currentAttack == 2)
            {
                Instantiate(crystalSpawner, transform.position + ground, transform.rotation);
                currentAttack = 0;
            }

            //Random Spikes
            if(currentAttack == 3)
            {
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                Instantiate(crystalSpike, transform.position + new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20)) + ground, transform.rotation);
                currentAttack = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player = other.transform;
            active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            active = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>().hp -= 5 + movement.z - 5;
        }
    }

    public void DMG(int damage)
    {
        hp -= damage;
    }
}