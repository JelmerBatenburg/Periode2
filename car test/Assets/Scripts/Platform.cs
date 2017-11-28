using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    public Vector3 m;
    public Rigidbody rig;
    public bool col;
    public float tog;
    public GameObject special;
    public Vector3 minRange;
    public Vector3 maxRange;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        special.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (col == true)
        {
            tog = Input.GetAxisRaw("Use");
            if (tog >= 0.8)
            {
                GameObject.Find("Player").GetComponent<Movement>().speed = 2;
                rig.velocity = m;
                special.SetActive(true);
            }
            else
            {
                GameObject.Find("Player").GetComponent<Movement>().speed = 5;
                special.SetActive(false);
            }
        }
	}
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Player")
        {
            col = true;
        }
    }
    private void OnCollisionExit(Collision co)
    {
        if(co.gameObject.name == "Player")
        {
            col = false;
            GameObject.Find("Player").GetComponent<Movement>().speed = 5;
            special.SetActive(false);
        }
    }
}
