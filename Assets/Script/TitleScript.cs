using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startButton(){
		SceneManager.LoadScene("main");
	}

	public void collectionButton(){
		SceneManager.LoadScene("collection");
	}

	public void BackToTitle(){
		SceneManager.LoadScene("title");
	}
}
