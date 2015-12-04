using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// a ne plus utiliser 

public class uiTextManager : MonoBehaviour {

	public Text TextUI;
	public string Text;
	public bool done;
	public bool running;

	// Use this for initialization
	void Start () {
		done = false;
		TextUI = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		SetTextUI (Text);
		SerieIsDone ();
	}

	public void SetText(string setter){
		Text = setter;
	}

	public void SetTextUI(string str = ""){
		TextUI.text = str;
	}

	public void SerieIsDone(){
		if (Input.GetMouseButtonDown(0) && running && !GameObject.Find ("Rest"))
			done = true;
	}
}
