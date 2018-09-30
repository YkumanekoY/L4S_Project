using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreat : MonoBehaviour
{
    public GameObject[] wall;
    private float _interval = 0;
    private int wallPos = 1;
    private int WALL_POS_MAX = 2;
    private int WALL_POS_MIN = 0;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i >= -22; i -= 2)
        {
            wallPos = Mathf.Clamp(wallPos + Random.Range(-1, 2), WALL_POS_MIN, WALL_POS_MAX);
            Instantiate(wall[Random.Range(0, 9)], transform.position + new Vector3(i, wallPos, 0), transform.rotation);
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     _interval += Time.deltaTime;
    //     if (_interval >= 0.4)
    //     {
    //         transform.position += new Vector3(2, 0, 0);
    //         wallPos = Mathf.Clamp(wallPos + Random.Range(-1, 2), WALL_POS_MIN, WALL_POS_MAX);
    //         Instantiate(wall[Random.Range(0, 9)], transform.position + new Vector3(0, wallPos, 0), transform.rotation);
    //         _interval = 0;
    //     }
    // }

    public void Creat()
    {
        transform.position += new Vector3(2, 0, 0);
        wallPos = Mathf.Clamp(wallPos + Random.Range(-1, 2), WALL_POS_MIN, WALL_POS_MAX);
        Instantiate(wall[Random.Range(0, 10)], transform.position + new Vector3(0, wallPos, 0), transform.rotation);
    }
}