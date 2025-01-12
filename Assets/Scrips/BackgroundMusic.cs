﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

	public static BackgroundMusic instance;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(gameObject);
		}
	}
}