using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public GameObject[] player;
    public GameObject gameOver_object;

    public static bool gameOverTrigger = false;
    //public GameObject[] main_object;

    private float speed = 4.0f;

    // Use this for initialization
    void Start()
    {
        gameOverTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Break"))
        {
            if (player[1].activeSelf)
            {
                Destroy(other.gameObject);
            }
            else
            {
                GameOver();
            }
        }
        if (other.CompareTag("Through"))
        {
            if (!player[2].activeSelf)
            {
                GameOver();
            }
        }
        if (other.CompareTag("needle"))
        {
            if (!player[2].activeSelf)
            {
                GameOver();
            }
        }
    }

//ゲームオーバー系
    public void GameOver()
    {
        gameOver_object.SetActive(true);
        gameOverTrigger = true;
        speed = 0f;
    }

    public void ReStart(){
        SceneManager.LoadScene("main");
    }

    public void BackToTitle(){
        SceneManager.LoadScene("title");
    }


}
