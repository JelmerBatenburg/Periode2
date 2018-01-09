using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalStormBullet : MonoBehaviour {
    public Vector3 size;
    public Vector3 move;
    public Vector3 rot;

	// Use this for initialization
	void Start () {
        rot.z = Random.Range(90, -90);
        transform.Rotate(rot);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(move);
        transform.localScale += size * Time.deltaTime;
    }
}
