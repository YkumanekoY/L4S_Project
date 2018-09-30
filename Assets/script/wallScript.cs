using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour
{
    public GameObject wall_c;
    public bool reset = false;

    // Use this for initialization
    void Start()
    {
        if (this.gameObject.transform.position.y <= 0)
            {
                wall_c = GameObject.Find("U-WallCreater");
            }
            else
            {
                wall_c = GameObject.Find("B-WallCreater");
            }
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreManager.Instance.gameOver == true){
            reset = true;
        }
    }

    private static bool isQuitting = false;
    void OnApplicationQuit()

    {

        isQuitting = true;

    }
    private void OnDestroy()
    {
        if (!isQuitting && !reset)
        {
            if (this.gameObject.transform.position.y <= 0)
            {
                wallCreat temp = wall_c.GetComponent<wallCreat>();
                temp.Creat();
            }
            else
            {
                wallCreat temp = wall_c.GetComponent<wallCreat>();
                temp.Creat();
            }
        }
    }
}
