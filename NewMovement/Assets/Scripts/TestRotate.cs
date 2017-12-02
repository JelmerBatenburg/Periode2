using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour
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
    public Vector3 position;
    public RaycastHit jump;
    public RaycastHit wallFront;
    public bool wallJump;
    public bool wall;
    public Vector3 jumpWall;

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
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
        if(allowJump == true)
        {
            if (Input.GetButtonDown("Jump") == true)
            {
                rig.velocity = hight;
            }
        }

        if(Physics.Raycast(transform.position, -transform.up, out jump, 0.6f))
        {
            allowJump = true;
        }
        else
        {
            allowJump = false;
        }
        Debug.DrawRay(transform.position, -transform.up * 0.6f, Color.green);

        if(Physics.Raycast(transform.position, transform.forward, out wallFront, 0.8f))
        {
            if(wallFront.transform.tag == "Wall")
            {
                wall = true;
            }
        }
        else
        {
            wall = false;
        }
        Debug.DrawRay(transform.position, transform.forward * 1, Color.red);

        if (wall == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rig.velocity = jumpWall;
            }
        }
    }
}