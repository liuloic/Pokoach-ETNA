
using UnityEngine;
using System.Collections;

public class countdown : uiTextManager {

	public float time;
	public bool activeCountDown;
	public string ctdSTR;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (activeCountDown) {
			countDownActive();
			checkTime();
			sendinfo();
		}
		SetTextUI (ctdSTR);
	}

	void sendinfo(){
		int bridge;
		bridge = (int)time;
		ctdSTR = bridge.ToString();
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
		//TextUI.enabled = true;
	}

	void countDownActive(){
		time -= Time.deltaTime;
	}

	void controlCountDown(bool ctrl){
		activeCountDown = ctrl;
	}

}
