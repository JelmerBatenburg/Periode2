using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopHP : MonoBehaviour {
    public HealthManager health;
    public CrystalManager check;
    public Text namePanel;
    public Text pricePanel;
    public int nameInput;
    public int priceInput;

	// Use this for initialization
	void Start () {
        health = GameObject.FindWithTag("HealthManager").GetComponent<HealthManager>();
        check = GameObject.FindWithTag("CrystalManager").GetComponent<CrystalManager>();
        namePanel.text = "+ " + nameInput.ToString() + " HP";
        pricePanel.text = priceInput.ToString() + " Crystals";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Onclick()
    {
        if(check.crystal >= priceInput)
        {
            check.crystal -= priceInput;
            health.maxHp += nameInput;
            health.hp += nameInput;
            check.AddCrystal(0);
        }
    }
}
