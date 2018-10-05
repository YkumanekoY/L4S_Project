using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player1Script : MonoBehaviour
{

    private SpriteRenderer sp_r;

    private Rigidbody _rg;
    private bool gravityTrigger = false;

    // Use this for initialization
    void Start()
    {
        sp_r = this.GetComponent<SpriteRenderer>();
        _rg = this.gameObject.transform.parent.GetComponent<Rigidbody>();
        _rg.velocity = new Vector3(0, -9.8f, 0);
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
        if (!gravityTrigger)
        {
            _rg.velocity = new Vector3(0, 9.8f, 0);
            gravityTrigger = true;
            sp_r.flipY = true;
        }
        else
        {
            _rg.velocity = new Vector3(0, -9.8f, 0);
            gravityTrigger = false;
            sp_r.flipY = false;
        }
    }

}
