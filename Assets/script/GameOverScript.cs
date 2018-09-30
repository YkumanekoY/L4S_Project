using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

	public GameObject explosion;
	public GameObject[] wall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.transform.CompareTag ("wall")) {
			
			Instantiate(explosion,transform.parent.position,Quaternion.identity);
			ScoreManager.Instance.gameOver = true;
			Destroy (transform.parent.gameObject);
			for (int i = 0; i < 2; i++) {
				Destroy (wall [i]);
			}
			//gameOver = true;
		}
	}
}
