using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	//初期化
	private int score = 0;
	//スコアを表示するテキスト
	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		//ScoreTextオブジェクトを取得？
		this.scoreText = GameObject.Find("ScoreText");
		//初期スコアを表示
		this.scoreText.GetComponent<Text> ().text = "0";

	}
	
	// Update is called once per frame
	void Update () {

		//スコアを表示
		this.scoreText.GetComponent<Text> ().text = score.ToString();

	}
	void OnCollisionEnter(Collision other){

		// タグによって得点を変える
		if(other.gameObject.tag == "SmallStarTag") {
			this.score += 10;
		}else if(other.gameObject.tag == "LargeStarTag") {
			this.score += 20;
		}else if(other.gameObject.tag == "SmallCloudTag") {
			this.score += 30;
		}else if(other.gameObject.tag == "LargeCloudTag") {
			this.score += 50;
		}

		//コンソールに表示
		Debug.Log(score);
	}

}
