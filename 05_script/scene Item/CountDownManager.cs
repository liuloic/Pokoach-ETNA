using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

// a ne plus utiliser 

public class CountDownManager : TextManager {

	public float time;
	public bool activeCountDown;

	// Use this for initialization
	void Start () {
		TextUI = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (activeCountDown) {
			countDownActive();
			checkTime();
			sendinfo();
		}
		SetTextUI (Text);
	}

	void sendinfo(){
		int bridge;
		bridge = (int)time;
		Text = bridge.ToString();
	}
	
	void checkTime(){
		if (time < 0.0f) {
			controlCountDown (false);
			Destroy(gameObject);
		}
	}
	
	public void setCountDown(float restTime){
		time = restTime;
		controlCountDown (true);
	}
	
	void countDownActive(){
		time -= Time.deltaTime;
	}
	
	void controlCountDown(bool ctrl){
		activeCountDown = ctrl;
	}

}
