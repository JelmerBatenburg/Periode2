using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool allowMove;
    public int toggle;
    public Vector3 r;
    public float count;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (toggle >= 2)
        {
            toggle = 0;
        }
        if (toggle == 1)
        {
            r.y = 5;
            if(count >= 90)
            {
                allowMove = false;
            }
            else
            {
                allowMove = true;
            }
        }

        if (toggle == 0)
        {
            r.y = -5;
            if(count <= 0)
            {
                allowMove = false;
            }
            else
            {
                allowMove = true;
            }
        }

        if (allowMove == true)
        {
            transform.Rotate(r);
            if(toggle == 1)
            {
                count += 5;
            }
            if(toggle == 0)
            {
                count += -5;
            }
        }
	}
}
