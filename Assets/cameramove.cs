﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{

	public Transform Player;

	Vector3 offset;

	// Use this for initialization
	void Start()
	{

		offset = transform.position - Player.position;

	}

	// Update is called once per frame
	void Update()
	{

		transform.position = Player.position + offset;

	}
}
