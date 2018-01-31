using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 startRotation;

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
        if (c.gameObject.tag == "Player"|| c.gameObject.tag == "Zone")
        {

        }
        else
        {
            if (c.gameObject.tag == "BigCrystal")
            {
                c.gameObject.GetComponent<BigCrystal>().DMG(1);
            }
            if (c.gameObject.tag == "Drone")
            {
                if (c.gameObject.GetComponent<Drone>() == true)
                {
                    c.gameObject.GetComponent<Drone>().Damage(10);
                }
            }
            if (c.gameObject.tag == "Roller")
            {
                if (c.gameObject.GetComponent<EnemyRoller>() == true)
                {
                    c.gameObject.GetComponent<EnemyRoller>().Damage(10);
                }
            }
            if (c.gameObject.tag == "Boss1")
            {
                c.gameObject.GetComponent<Boss1>().DMG(12);
            }
            Destroy(gameObject);
        }
    }
}
