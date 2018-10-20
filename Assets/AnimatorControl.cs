using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour {

	private Animator animator;//(1)
	private float f;//(2)
	void Start () {//(3)
		animator = GetComponent<Animator>();
		f = 0;
	}
	void Update () {
		if (Input.GetKey(KeyCode.D)) {
			f=2;//(4)
		}else if (Input.GetKey(KeyCode.W)) {
			f=4;
		}else if (Input.GetKey(KeyCode.A)) {
			f=6;
		}else if (Input.GetKey(KeyCode.S)) {
			f=8;
		}else if (Input.GetKey(KeyCode.Q)) {
			f=10;
		}

		animator.SetFloat("float", f);//(5)
	}
}