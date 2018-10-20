using UnityEngine;

public class Player : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		anim.SetFloat("speed", Input.GetAxis("player"));
	}
}
