using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {

	public enum typeScreen{
		portrait,
		paysage,
		notSet
	}
	
	public float ratio;
	public Vector2 screen;
	public typeScreen typeIs;
	public Vector3 initScale;

	public bool debug;
	public float posXdebug;
	public float posYdebug;
	public float multiplicateur;

	// Use this for initialization
	void Start () {
		Init();
	}
	
	// Update is called once per frame
	void Update () {
		if (debug) {
			debug = false;
			SetPosition(posXdebug, posYdebug);
			SetScale();
		}
	}

	public void Init(){
		multiplicateur = 1;
		typeIs = typeScreen.notSet;
		SetScreen ();
		SetRatio ();
		GetInitScale ();
	}

	void SetScreen(){
		screen.x = Screen.width;
		screen.y = Screen.height;
		Debug.Log (screen);
	}

	void SetRatio(){
		if (screen.x > screen.y) {
			typeIs = typeScreen.paysage;
			ratio = screen.x / screen.y;
		} else {
			typeIs = typeScreen.portrait;
			ratio = screen.y / screen.x;
		}
	}

	public void SetPosition (float posX, float posY){
		SetScreen ();
		SetRatio ();
		Vector2 newPos = new Vector2 (0,0);
		newPos.x = posX * screen.x / 10;
		newPos.y = posY * screen.y / 10;
		Debug.Log (newPos);

		RectTransform setPos = this.GetComponent<RectTransform> ();
		setPos.anchoredPosition = newPos;
	}

	public void SetMultiplicateur(float setter){
		multiplicateur = setter;
	}

	public void SetScale(){
		Transform setPos = this.GetComponent<Transform> ();
		setPos.localScale = initScale * multiplicateur;
	}

	public void GetInitScale(){
		Transform setPos = this.GetComponent<Transform> ();
		initScale = setPos.localScale;
	}

}
