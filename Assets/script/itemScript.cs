using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemScript : MonoBehaviour
{
    ScoreManager scoreManager;
    // Use this for initialization
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(2f, 2f, 2f));
    }

    void OnTriggerEnter()
    {
        scoreManager.ScorePlus();
        Destroy(this.gameObject);
    }
}
