using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public Vector3 m;
    public float count;
    public bool down;
	
	// Update is called once per frame
	void Update ()
    {
        if (count >= 0.3f)
        {
            down = true;
        }
        if(count <= -0.31f)
        {
            down = false;
        }

        if (down == false)
        {
            count = count + 0.01f;
            transform.Translate(m);
            m.y = m.y + 0.001f;
        }
        else
        {
            count = count - 0.01f;
            transform.Translate(m);
            m.y = m.y - 0.001f;
        }
	}
}
