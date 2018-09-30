using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    float target = 0;
    private bool _gra = false;
    private Rigidbody _rig;
    private float _speed = 6.0f;

    public GameObject score;
    public GameObject highScore;

    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        target = transform.position.x;
        _rig = gameObject.GetComponent<Rigidbody>();
        _rig.velocity = new Vector3(0, -9.8f, 0);
        //		goScript = this.GetComponentInChildren<GameOverScript> ();
    }

    // Update is called once per frame
    void Update()
    {
        //常に右へ
        transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;

        //重力反転
        if (Input.GetMouseButtonUp(0))
        {
            _gra = !_gra;
        }
        float distance = transform.position.x;
        distance = distance - target;
        if (distance > 20f)
        {
            ScoreManager.Instance.ScorePlus();
            target = transform.position.x;
        }
    }

    void FixedUpdate()
    {
        //重力反転２
        if (_gra == true)
        {
            _rig.velocity = new Vector3(0, 9.8f, 0);
        }
        else
        {
            _rig.velocity = new Vector3(0, -9.8f, 0);
        }
    }

    //	void GameOver(){
    //		_speed = 0;
    //	}
    private static bool isQuitting = false;
    void OnApplicationQuit()

    {

        isQuitting = true;

    }

    private void OnDestroy()
    {
        if (!isQuitting)
        {
            score.SetActive(false);
            highScore.SetActive(true);

            //ハイスコアを表示
            Text temp = highScore.GetComponent<Text>();
            temp.text = "HighScore: " + ScoreManager.Instance.highScore.ToString() + "\nクリックで再スタート";
        }
    }

    public void SetWall()
    {
        audioSource.Play();
    }
}