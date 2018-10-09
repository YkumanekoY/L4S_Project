using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : SingletonMonoBehaviour<CollectionManager>
{
    public string key = "item";

    public GameObject[] itemArray = new GameObject[6];
    public bool[] itemTrigger = { false, false, false, false, false, false };


    // Use this for initialization

    void Start()
    {

        DontDestroyOnLoad(this.gameObject);
        itemTrigger = PlayerPrefsX.GetBoolArray(key, false, 6);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
