using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public GameObject col_player2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerMove.gameOverTrigger)
        {
            if (Input.GetMouseButtonDown(0))
            {
                col_player2.SetActive(true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                col_player2.SetActive(false);
            }
        }
    }
}
