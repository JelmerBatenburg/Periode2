using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalManager : MonoBehaviour {
    public int crystal;
    public Text text;

	// Use this for initialization
	void Start () {
        text.GetComponent<Text>().text = crystal.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddCrystal(int i)
    {
        crystal += i;
        ChangeText(crystal);
    }

    void ChangeText(int i)
    {
        text.GetComponent<Text>().text = i.ToString();
    }
}
