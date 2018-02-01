using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
    public GameObject from;
    public GameObject to;

	public void OnbuttonClick()
    {
        from.SetActive(false);
        to.SetActive(true);
    }
}
