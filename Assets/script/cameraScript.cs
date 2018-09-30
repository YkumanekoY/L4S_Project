using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	// 変数の定義
	public GameObject target;

	// シーン開始時に一度だけ呼ばれる関数
	void Start(){
	}

	// シーン中にフレーム毎に呼ばれる関数
	void Update () {
		// カメラのx座標をPlayerオブジェクトのx座標から取得y座標とz座標は現在の状態を維持
		if (target) {
			transform.position = new Vector3 (target.transform.position.x, transform.position.y, transform.position.z);
		}
	}
}