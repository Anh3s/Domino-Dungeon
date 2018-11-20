﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{

	
	public Vector3 FPosAdjust = new Vector3(1, 3, 0);
	public int Force = 1000;
	public bool Setup = false;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	public void OnMouseDown()
	{
		if (Setup)
		{
			print("Got a click");
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().AddForceAtPosition(-transform.forward * Force, transform.position + FPosAdjust, ForceMode.Impulse);
		}			
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}