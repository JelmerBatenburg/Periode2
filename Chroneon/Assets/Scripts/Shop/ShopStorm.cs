using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopStorm : MonoBehaviour
{
    public WeaponManager check;
    public CrystalManager cashCheck;
    public Text panelName;
    public Text price;
    public string nameInput;
    public int priceInput;

    // Use this for initialization
    void Start()
    {
        check = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
        cashCheck = GameObject.FindWithTag("CrystalManager").GetComponent<CrystalManager>();
        panelName.text = nameInput;
        price.text = priceInput.ToString() + " Crystals";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        if (cashCheck.crystal >= priceInput)
        {
            check.crystalStormSlot = check.weaponAmount + 1;
            check.weaponAmount += 1;
            cashCheck.crystal -= priceInput;
            cashCheck.AddCrystal(0);
            gameObject.SetActive(false);
        }
    }
}
