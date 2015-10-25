using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwipeTexture : MonoBehaviour {
	public Sprite Up;
	public Sprite Down;

	public float countDown;

	public bool swipeSprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RunCountDown ();
		if (countDown < 0) {
			master();
		}
	}

	void master(){
		if (swipeSprite){
			ChangeToUp();
		} else {
			ChangeToDown();
		}
	}

	void ChangeTexture(Sprite textNew){
		Image spriteImage = this.gameObject.GetComponent<Image>();
		spriteImage.sprite = textNew;
	}

	public void SetUp (Sprite source){
		Up = source;
	}

	public void SetDown (Sprite source){
		Down = source;
	}

	public void SetCountDown (float Setter = 1.0f){
		countDown = Setter;
	}

	void RunCountDown (){
		countDown -= Time.deltaTime;
	}

	void ChangeToUp(){
		ChangeTexture(Up);
		swipeSprite = false;
		SetCountDown (1.0f);
	}

	void ChangeToDown(){
		ChangeTexture(Down);
		swipeSprite = true;
		SetCountDown (1.0f);
	}

}
