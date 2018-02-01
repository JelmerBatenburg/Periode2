using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{
    public Image bar;
    public float energy;
    public float maxEnergy;
    public float recharge;
    public Text text;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bar.GetComponent<Image>().fillAmount = 1 / maxEnergy * energy;

        if(energy <= maxEnergy)
        {
            energy += recharge * Time.deltaTime;
        }
        text.text = Mathf.RoundToInt(energy).ToString() + " / " + maxEnergy.ToString();
    }
}