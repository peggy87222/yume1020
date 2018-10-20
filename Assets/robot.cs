using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class robot : MonoBehaviour {
	public int hp;
	[Range(0,100)]
	public int hpMax = 100;

	public ParticleSystem bloodEFX;
	//public Text hpText;
	public Slider hpSlider;

	// Use this for initialization
	void Start () {
		hp =  hpMax;
		
	}
	
	// Update is called once per frame
	void Update () {
		hp = Mathf.Clamp (hp, 0, 100);
		hpSlider.value = (float)hp / (float)hpMax;

		if (hp <= 0) {
			//Die ();
		}
		
	}

	public void PlayBloodEFX(){
		bloodEFX.Play ();

	}
	/*void OnTriggerEnter(Collider col){
		Vector3 lookDir= Camera.main.transform.position - transform.position;
		bloodEFX.transform.rotation = Quaternion.LookRotation (lookDir);
		PlayBloodEFX ();
		hp = hp - 10;
}
	void Die(){
		Destroy (gameObject);
	}*/
}