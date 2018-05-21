﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveButton : MonoBehaviour {

    public GameObject fire;

	// Use this for initialization
	void Start () {
	}
	
    private void OnHand

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name == "Stove")
                {
                     fire.SetActive(!fire.activeSelf);          
                }
            }
        }  
	}
}