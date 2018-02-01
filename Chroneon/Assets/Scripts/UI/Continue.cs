using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour {
    public OpenMenu check;

	public void OnbuttonPress()
    {
        check.OnButtonPressExit();
    }
}
