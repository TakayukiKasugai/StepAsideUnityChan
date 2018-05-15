using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

	//シーンないのユニティちゃんオブジェクトを格納
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		
		//シーン内のユニティちゃんオブジェクトを取得
		unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		//ユニティちゃんより後ろ５mにコイン、コーン、車がある場合
		if (unitychan.transform.position.z - this.transform.position.z > 5) {
			//オブジェクトを破棄
			Destroy (this.gameObject);
		}
	}
}
