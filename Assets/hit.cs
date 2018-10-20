using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour {
    public Animator anim;
    private Collider col;
    // Use this for initialization
    
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "robot")
        {
            anim.SetBool("hit",true);
            anim.Play("die");
        }
    }
}
