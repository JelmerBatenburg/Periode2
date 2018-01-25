using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetect : MonoBehaviour {
    public CharacterMovement check;

	// Use this for initialization
	void Start () {
        check = GameObject.FindWithTag("Player").GetComponent<CharacterMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionStay(Collision collision)
    {
        check.allowJump = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        check.allowJump = false;
    }
}
