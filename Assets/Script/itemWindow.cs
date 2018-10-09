using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemWindow : MonoBehaviour
{
	public Sprite[] snack = new Sprite[6];
	public Image[] item_s =  new Image[6];
    // Use this for initialization
    void Start()
    {
       for(int i = 0; i<=5; i++){
           print(CollectionManager.Instance.itemTrigger[i]);
		   if(CollectionManager.Instance.itemTrigger[i]){
               item_s[i] = item_s[i].GetComponent<Image>();
			   item_s[i].sprite = snack[i];
		   }
	   }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
