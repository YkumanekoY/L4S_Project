using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButtonScript : MonoBehaviour
{
    // ゲームシーンでの
    // 能力発動の為のスクリプト

    //ボタンのimage
    public Image mainImage;
    public Image ab1Image;
    public Image ab2Image;
    public Image ab3Image;

    //キャラチェンジ用エフェクト
    public GameObject player;
    public GameObject[] player_look;
    public GameObject dron;


    public Color color1;
    public Color color2;
    public Color color3;

    private void Start()
    {
        mainImage = mainImage.GetComponent<Image>();
        ab1Image = ab1Image.GetComponent<Image>();
        ab2Image = ab2Image.GetComponent<Image>();
        ab3Image = ab3Image.GetComponent<Image>();
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

    public void Ability1Enter(int ab)
    {
        if (ab == 1)
        {
            ab1Image.color = color1;
        }
        else if (ab == 2)
        {
            ab2Image.color = color2;
        }
        else if (ab == 3)
        {
            ab3Image.color = color3;
        }
    }
    public void Ability1Exit(int ab)
    {
        if (ab == 1)
        {
            ab1Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (ab == 2)
        {
            ab2Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (ab == 3)
        {
            ab3Image.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    public void Ability1Drop(int ab)
    {
        if (ab == 1)
        {
            ab1Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (ab == 2)
        {
            ab2Image.color = new Color(1f, 1f, 1f, 1f);
        }
        else if (ab == 3)
        {
            ab3Image.color = new Color(1f, 1f, 1f, 1f);
        }

        Instantiate(dron, player.transform.position + new Vector3(0, -1f, -1), Quaternion.identity);

        //プレイヤーの見た目を変更
        for (int i = 0; i <= 2; i++)
        {

            player_look[i].SetActive(false);
            if (ab == 1)
            {
                player_look[0].SetActive(true);
            }
            else if (ab == 2)
            {
                Rigidbody rg = player.gameObject.transform.GetComponent<Rigidbody>();
                rg.velocity = new Vector3(0, -9.8f, 0);
                player_look[1].SetActive(true);
            }
            else if (ab == 3)
            {
                Rigidbody rg = player.gameObject.transform.GetComponent<Rigidbody>();
                rg.velocity = new Vector3(0, -9.8f, 0);
                player_look[2].SetActive(true);
            }
        }


    }
}