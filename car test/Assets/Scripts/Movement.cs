using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 v;
    public float hor;
    public float ver;
    public float speed;
    public Vector3 r;
    public GameObject cam;
    public Vector3 r2;
    public Rigidbody rig;
    public Vector3 hight;
    public bool allowJump;
    public bool disableMove;

    // Update is called once per frame
    void Update()
    {
        if(disableMove == false)
        {
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");
            v.x = hor;
            v.z = ver;
            transform.Translate(v * Time.deltaTime * speed);
            r.y = Input.GetAxis("Mouse X");
            r2.x = -Input.GetAxis("Mouse Y");
            transform.Rotate(r);
            cam.transform.Rotate(r2);
            if (allowJump == true)
            {
                if (Input.GetButtonDown("Jump") == true)
                {
                    rig.velocity = hight;
                    allowJump = false;
                }
            }
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        allowJump = true;
    }
}