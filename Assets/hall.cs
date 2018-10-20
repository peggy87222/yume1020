using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hall : MonoBehaviour
{
       
    private CharacterController Cc;
    private float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	
    void Awake() {
        Cc = gameObject.GetComponent<CharacterController>();
        speed = 3.0f;
    }
    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            Cc.Move(Vector3.forward * Time.deltaTime * speed);
        }
    }
}