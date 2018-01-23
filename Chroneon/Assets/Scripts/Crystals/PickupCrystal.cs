using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCrystal : MonoBehaviour
{
    public Vector3 rotation;
    public Rigidbody rig;
    public Vector3 startLaunch;
    public float timer;

    void Start()
    {
        startLaunch.x = Random.Range(-8, 8);
        startLaunch.z = Random.Range(-8, 8);
        rig.velocity = startLaunch;
        rotation.y = Random.Range(40, -40);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
        if(timer <= 1)
        {
            timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zone" || other.tag == "Drone" || other.tag == "Crystal" || other.tag == "ShotgunBullet" || other.tag == "PlayerBullet")
        {

        }
        else
        {
            if (other.tag == "Player")
            {
                Destroy(gameObject);
                GameObject.FindGameObjectWithTag("CrystalManager").GetComponent<CrystalManager>().AddCrystal(1);
            }
            else
            {
                if (timer <= 0.05)
                {

                }
                else
                {
                    rig.isKinematic = true;
                    rig.velocity = new Vector3(0,0,0);
                }
            }
        }
    }
}
