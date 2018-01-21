using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
    public Image bar;
    public float hp;
    public float maxHp;
    public Text text;
    
    
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        bar.GetComponent<Image>().fillAmount = 1 / maxHp * hp;
        text.text = Mathf.RoundToInt(hp).ToString() + " / " + maxHp.ToString();

        if(hp <= 0)
        {
            GameObject.FindWithTag("Player").transform.position = GameObject.FindWithTag("SpawnPoint").transform.position;
            hp = maxHp;
        }
    }
}
