using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour {
    public Transform target;
    public float speed;
    public RaycastHit hit;
    public bool assigned;
    private Vector3 forward;

	// Use this for initialization
	void Start () {
        if (Physics.Raycast(transform.position, -transform.up, out hit, 20))
        {
            if (hit.transform.tag == "Enemy"|| hit.transform.tag == "Zone")
            {
                target = hit.transform;
                assigned = true;
            }
            else
            {
                forward.z = 1;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(assigned == true)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, Time.deltaTime * speed);
            transform.LookAt(target);
        }
        else
        {
            transform.Translate(forward * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
