using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class move : MonoBehaviour
{

	Rigidbody rb;



	int count;
	DateTime curr;
	public float speed;
	// Use this for initialization
	void Start()
	{

		rb = GetComponent<Rigidbody>();



	}

	// Update is called once per frame
	void Update()
	{

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		//transform.Translate(x, 0, z);

		rb.AddForce(new Vector3(x, 0, z) * speed);

		TimeSpan ts = DateTime.Now - curr;




	}


}