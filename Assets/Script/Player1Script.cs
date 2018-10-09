using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player1Script : MonoBehaviour
{

    private SpriteRenderer sp_r;

    private Rigidbody _rg;
    private bool gravityTrigger = true;

    // Use this for initialization

    private void Awake()
    {
        sp_r = this.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        _rg = this.gameObject.transform.parent.GetComponent<Rigidbody>();
        _rg.velocity = new Vector3(0, -9.8f, 0);
    }

    private void OnEnable()
    {
        sp_r.flipY = false;
        gravityTrigger = true;
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

            if (!gravityTrigger)
            {
                _rg.velocity = new Vector3(0, 9.8f, 0);
            }
            else
            {
                _rg.velocity = new Vector3(0, -9.8f, 0);
            }
        }
    }

    private void Ability()
    {
        gravityTrigger = !gravityTrigger;
        sp_r.flipY = !sp_r.flipY;
        
    }

}
