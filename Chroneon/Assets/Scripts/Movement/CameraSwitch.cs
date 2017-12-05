using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam;
    public GameObject camPos1;
    public GameObject camPos2;
    public int count;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            count += 1;
        }
        
        if (count == 0)
        {
            cam.transform.position = camPos1.transform.position;
        }
        if (count == 1)
        {
            cam.transform.position = camPos2.transform.position;
        }
        if (count == 2)
        {
            count = 0;
        }
    }
}
