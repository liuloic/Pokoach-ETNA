using UnityEngine;
using System.Collections;

public class ExName : uiTextManager {

	public string ctdSTR;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SetTextUI (ctdSTR);
	}

	public void SetText(string txt){
		ctdSTR = txt;
	}

}
