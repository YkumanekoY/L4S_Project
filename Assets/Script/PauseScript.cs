using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{

    public GameObject player;

    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
			
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			int layerMask = ~(1 << 5);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                //Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
                Debug.Log(hit.collider.gameObject.name);

                player.transform.localScale = new Vector3(2, 2, 2);
            }
        }
    }
}