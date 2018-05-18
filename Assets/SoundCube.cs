using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCube : MonoBehaviour {

	// AudioSorceを格納する変数の宣言
	private	AudioSource	audioSource;
	// 効果音を格納する変数の宣言
	public AudioClip sound;

	// Use this for initialization
	void Start () {
		// AudioSorceコンポーネントを追加し、変数に代入
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "UnityChan") {
		} else {
			// 音を鳴らす
			audioSource.PlayOneShot (sound);
		}
	}
}
