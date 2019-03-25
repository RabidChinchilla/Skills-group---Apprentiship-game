﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayButtonsOnClick : MonoBehaviour {

    public GameObject buttonOne;
    public GameObject buttonTwo;
    private bool active = false;

	public void displayButtons()
    {
        if (active == false)
        {
            buttonOne.SetActive(true);
            buttonTwo.SetActive(true);
            active = true;
        }
        else
        {
            buttonOne.SetActive(false);
            buttonTwo.SetActive(false);
            active = false;
        }
    }
}
