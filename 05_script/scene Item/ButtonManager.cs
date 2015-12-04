using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour {
	
	public Text TextUI;
	public Image ButtonImg;
	public Button ButtonParam;
	public string Text;
	public bool done;
	public bool running;

	// Use this for initialization
	void Start () {
		done = false;
		TextUI = this.GetComponentInChildren<Text>();
		ButtonImg = this.GetComponent<Image>();
		ButtonParam = this.GetComponent<Button>();
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

	public void SetButtonImg(Sprite newImg){
		ButtonImg.sprite = newImg;
	}

	public void SetInteractable(bool interactable){
		ButtonParam.interactable = interactable;
	}

	public void SetNormalColor(Color newColor){
		ColorBlock cb = ButtonParam.colors;
		cb.normalColor = newColor;
		ButtonParam.colors = cb;
	}

	public void SetHighlightedColor(Color newColor){
		ColorBlock cb = ButtonParam.colors;
		cb.highlightedColor = newColor;
		ButtonParam.colors = cb;
	}

	public void SetPressedColor(Color newColor){
		ColorBlock cb = ButtonParam.colors;
		cb.pressedColor = newColor;
		ButtonParam.colors = cb;
	}

	public void SetDisabledColor(Color newColor){
		ColorBlock cb = ButtonParam.colors;
		cb.disabledColor = newColor;
		ButtonParam.colors = cb;
	}

	public void SetFadeDuration(float timer){
		ColorBlock cb = ButtonParam.colors;
		cb.fadeDuration = timer;
		ButtonParam.colors = cb;
	}

}
