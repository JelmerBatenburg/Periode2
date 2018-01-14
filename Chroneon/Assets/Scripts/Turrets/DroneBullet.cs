using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 startRotation;
    public float dmg;

    // Use this for initialization
    void Start()
    {
        transform.Rotate(startRotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
        transform.Rotate(rotation * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Drone" || c.gameObject.tag == "Zone")
        {

        }
        else
        {
            if (c.gameObject.tag == "Player")
            {
                GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>().hp -= dmg;
            }
            Destroy(gameObject);
        }
    }
}
