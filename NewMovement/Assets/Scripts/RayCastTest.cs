using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject particle;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.green);
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1000f))
            {
                if (hit.transform.tag == "Sphere")
                {
                    GameObject G = Instantiate(particle, hit.point, Quaternion.identity);
                    Destroy(G, 0.5f);
                    hit.transform.gameObject.GetComponent<Turret>().LoseHP(1);
                }
                if (hit.transform.tag == "Door")
                {
                    hit.transform.gameObject.GetComponent<Door>().toggle += 1;
                }
            }
        }
        
	}
}
