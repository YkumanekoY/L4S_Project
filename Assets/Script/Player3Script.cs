using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player3Script : MonoBehaviour
{
    private bool witchTrigger = false;
    public GameObject[] witch;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerMove.gameOverTrigger)
        {
#if UNITY_EDITOR
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }
#else
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)) {
                return;
            }
#endif
            if (Input.GetMouseButtonDown(0))
            {
                Ability();
            }
        }
    }

    private void Ability()
    {
        if (witchTrigger)
        {
            witch[0].SetActive(true);
            witch[1].SetActive(false);
            witchTrigger = false;
        }
        else
        {
            witch[1].SetActive(true);
            witch[0].SetActive(false);
            witchTrigger = true;
        }
    }

    private void OnEnable()
    {
        witch[0].SetActive(true);
        witch[1].SetActive(false);
    }
}
