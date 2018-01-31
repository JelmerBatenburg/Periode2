using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerActivate : MonoBehaviour {
    public EnemyRoller e;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            e.disable = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            e.disable = true;
        }
    }
}
