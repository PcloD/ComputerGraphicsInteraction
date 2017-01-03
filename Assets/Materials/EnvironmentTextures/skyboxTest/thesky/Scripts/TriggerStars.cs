using UnityEngine;
using System.Collections;


public class TriggerStars : MonoBehaviour {

	private ParticleSystem stars;
	int number = 0;

	// Use this for initialization
	void Awake () { 
		stars = GetComponent<ParticleSystem> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButton (0)) 
		{ 
			stars.Play ();

		}   
	}
}
