using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class TextManager : MonoBehaviour {

	public Text TextUI;
	public string Text;

	// Use this for initialization
	void Start () {
		TextUI = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		SetTextUI (Text);
	}

	public void SetTextUI(string str = ""){
		TextUI.text = str;
	}

	public void SetTextColor(Color newColor){
		TextUI.color = newColor;
	}
}
