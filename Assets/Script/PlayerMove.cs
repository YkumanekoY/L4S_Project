using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject[] player;
    public GameObject gameOver_object;
    public GameObject[] main_object;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * 5.0f * Time.deltaTime;

        }
        else
        {

        }
    }

    public void GameOver()
    {
        gameOver_object.SetActive(true);
        PlayerMove pm =  this.GetComponent<PlayerMove>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Break"))
        {
            if (player[1].activeSelf)
            {
                Break();
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
    }

    private void Break()
    {
    }
}
