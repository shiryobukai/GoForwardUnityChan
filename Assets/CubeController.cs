using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
 // キューブの移動速度
        private float speed = -0.2f;

        // 消滅位置
        private float deadLine = -10;

    private AudioSource sound;

	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource> ();	
	}
	
	// Update is called once per frame
	void Update () {
		 // キューブを移動させる
                transform.Translate (this.speed, 0, 0);
                
                // 画面外に出たら破棄する
                if (transform.position.x < this.deadLine){
                        Destroy (gameObject);
                }
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag != "UnityChanTag")
			sound.PlayOneShot(sound.clip);
	}
}
