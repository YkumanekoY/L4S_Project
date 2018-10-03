using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvirityButtonScript : MonoBehaviour
{
    // ゲームシーンでの
    // 能力発動の為のスクリプト

    //ボタンのimage
    public Image mainImage;
    public Image av1Image;
    public Image av2Image;
    public Image av3Image;

    //キャラチェンジ用エフェクト
    public GameObject player;
    public GameObject[] player_look;
    public GameObject dron;

    private void Start()
    {
        mainImage = mainImage.GetComponent<Image>();
        av1Image = av1Image.GetComponent<Image>();
        av2Image = av2Image.GetComponent<Image>();
        av3Image = av3Image.GetComponent<Image>();
    }

    public void MainButtonDown()
    {
        Time.timeScale = 0;
        mainImage.color = new Color(0.8f, 0f, 0f, 1f);
    }

    public void MainButtonUp()
    {
        Time.timeScale = 1;
        mainImage.color = new Color(1f, 1f, 1f, 1f);
    }

    public void Avirity1Enter(int av)
    {
        if (av == 1)
        {
            av1Image.color = new Color(0.8f, 0f, 0f, 1f);
        }
        else if (av == 2)
        {
            av2Image.color = new Color(0.8f, 0f, 0f, 1f);
        }
        else if (av == 3)
        {
            av3Image.color = new Color(0.8f, 0f, 0f, 1f);
        }
    }
    public void Avirity1Exit(int av)
    {
        if (av == 1)
        {
            av1Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (av == 2)
        {
            av2Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (av == 3)
        {
            av3Image.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    public void Avirity1Drop(int av)
    {
        if (av == 1)
        {
            av1Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (av == 2)
        {
            av2Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (av == 3)
        {
            av3Image.color = new Color(1f, 1f, 1f, 1f);
        }

        Instantiate(dron, player.transform.position + new Vector3(0, -1f, -1), Quaternion.identity);

        //プレイヤーの見た目を変更
        for (int i = 0; i <= 2; i++)
        {

            player_look[i].SetActive(false);
            if (av == 1)
            {
                player_look[0].SetActive(true);
            }
            else if (av == 2)
            {
                Rigidbody rg = player.gameObject.transform.GetComponent<Rigidbody>();
                rg.velocity = new Vector3(0, -9.8f, 0);
                player_look[1].SetActive(true);
            }
            else if (av == 3)
            {
                Rigidbody rg = player.gameObject.transform.GetComponent<Rigidbody>();
                rg.velocity = new Vector3(0, -9.8f, 0);
                player_look[2].SetActive(true);
            }
        }


    }
}