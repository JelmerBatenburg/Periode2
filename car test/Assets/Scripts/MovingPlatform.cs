using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public Vector3 movement;
    public GameObject character;
    public bool coll;
    public float hor;
    public float ver;
    public float trig;
    public GameObject special;
    public Rigidbody platform;
    public GameObject platform2;
    public Vector3 r;
    public float rot;
    public Vector3 hight;
    public GameObject playerNormal;

	// Use this for initialization
	void Start () {
        special.SetActive(false);
        movement.y = 0.01f;
	}
	
	// Update is called once per frame
	void Update () {
		if(coll == true)
        {
            trig = Input.GetAxisRaw("Use");
            if (trig >= 0.4f)
            {
                character.transform.parent = platform2.transform;
                character.GetComponent<Movement>().disableMove = true;
                hor = Input.GetAxis("Horizontal");
                ver = Input.GetAxis("Vertical");
                movement.x = hor;
                movement.z = ver;
                rot = Input.GetAxis("Mouse X");
                r.y = rot;
                transform.Rotate(r);
                transform.Translate(movement);
                special.SetActive(true);
                platform.velocity = hight;
                character.transform.rotation = transform.rotation;
            }
            else
            {
                character.transform.parent = playerNormal.transform;
                character.GetComponent<Movement>().disableMove = false;
                hor = 0;
                ver = 0;
                rot = 0;
                special.SetActive(false);
            }
        }
	}

    private void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.name == "Player")
        {
            coll = true;
        }
    }

    private void OnCollisionExit(Collision co)
    {
        if(co.gameObject.name == "Player")
        {
            coll = false;
            character.transform.parent = playerNormal.transform;
            character.GetComponent<Movement>().disableMove = false;
            hor = 0;
            ver = 0;
            rot = 0;
            special.SetActive(false);
        }
    }
}
