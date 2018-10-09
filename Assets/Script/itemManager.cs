using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i <= 5; i++)
        {
            if (this.gameObject.name == "item" + i.ToString())
            {
				CollectionManager.Instance.itemTrigger[i] = true;
				PlayerPrefsX.SetBoolArray(CollectionManager.Instance.key,CollectionManager.Instance.itemTrigger);
            }

           print(CollectionManager.Instance.itemTrigger[i]);
        }
        Destroy(this.gameObject);
    }
}
