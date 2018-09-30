using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

	public int score = 0;
	public int highScore = 0;
	public string key = "HighScore";


    ScoreManager s_mana;
    public Text scoreText;

	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		score = 0;
		highScore = PlayerPrefs.GetInt(key, 0);
		s_mana = ScoreManager.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver){
			if(Input.GetKey(KeyCode.Mouse0)){
				Scene loadScene = SceneManager.GetActiveScene();
				SceneManager.LoadScene(loadScene.name);
				gameOver = false;
			}
		}
	}

	public void ScorePlus(){
		s_mana.score++;
        scoreText.text = s_mana.score.ToString();

        if (s_mana.score > s_mana.highScore)
        {
            //ハイスコア更新
            s_mana.highScore = s_mana.score;

            //ハイスコアを保存
            PlayerPrefs.SetInt(s_mana.key, s_mana.highScore);

        }
	}
}
