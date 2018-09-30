using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

	private GameObject player;
	private PlayerScript player_s;
	// Use this for initialization
	void Start () {
		player=GameObject.Find("Player");
		player_s=player.GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player){
			player_s.SetWall();
		}
	}

}
