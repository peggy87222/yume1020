using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atk : MonoBehaviour {

    private Animator anim;
    

    private CapsuleCollider col;
    private Rigidbody rb;
    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col) {
        if (col.tag == "boy") {
            anim.SetTrigger("attack");
            
            print("hi");
        }
    }
}
