using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {
    public GameObject player;
    public bool start;
    public float counter;
    public GameObject bullet;
    public int hp;
    public GameObject smoke;
    public GameObject area;
    [Range(2,0.3f)]
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (start == true)
        {
            transform.LookAt(player.transform);
            counter += 1 * Time.deltaTime;
        }
        if(counter >= speed)
        {
            counter = 0;
            GameObject b = Instantiate(bullet, transform.position, transform.rotation);
            Destroy(b, 4);
        }
	}
    public void LoseHP(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Destroy(gameObject);
            Destroy(area);
            Instantiate(smoke, transform.position, transform.rotation);
        }
    }
}
