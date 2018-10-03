using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour
{

    private Rigidbody _rg;
    private bool gravityTrigger = false;
    
    // Use this for initialization
    void Start()
    {
        _rg = this.gameObject.transform.parent.GetComponent<Rigidbody>();
        _rg.velocity = new Vector3(0, -9.8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Avirity();
        }
    }

    private void Avirity()
    {
        if (!gravityTrigger)
        {
            _rg.velocity = new Vector3(0, 9.8f, 0);
            gravityTrigger = true;
        }
        else
        {
            _rg.velocity = new Vector3(0, -9.8f, 0);
            gravityTrigger = false;
        }
    }

}
