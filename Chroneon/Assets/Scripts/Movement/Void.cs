using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>().hp -= GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>().maxHp;
        }
    }
}
