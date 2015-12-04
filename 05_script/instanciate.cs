using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class instanciate : MonoBehaviour {

	//ajouter les gameobjet pour completer le scenario
	public GameObject serieInfo;
	public GameObject countDown;
	public GameObject nameEx;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Instancez info d'une série
	public GameObject InstanceAndSet (string newName, string info, Vector2 positionUI){
		//Instanciate GameObject
		GameObject clone = Instantiate(serieInfo, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Put the GameObject in the Canvas
		clone.transform.SetParent( GameObject.Find("Canvas").transform, false);
		//Set position
		RectTransform TransUI = clone.GetComponent<RectTransform> ();
		TransUI.anchoredPosition = positionUI;
		//Set info
		uiTextManager infoUI = clone.GetComponentInChildren<uiTextManager>();
		//la variable info sert à set les données
		infoUI.SetText(info);
		return (clone);
	}

	//Instancez le temps de repos
	public void InstanceAndRest (string newName, float info, Vector2 positionUI){
		//Instanciate GameObject
		GameObject clone = Instantiate(countDown, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Put the GameObject in the Canvas
		clone.transform.SetParent( GameObject.Find("Canvas").transform, false);
		//Set position
		RectTransform TransUI = clone.GetComponent<RectTransform> ();
		TransUI.anchoredPosition = positionUI;
		//Set info
		countdown infoUI = clone.GetComponentInChildren<countdown>();
		infoUI.setCountDown(info);
	}

	public void InstanceAndName (string newName, Vector2 positionUI){
		//Instanciate GameObject
		GameObject clone = Instantiate(nameEx, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Put the GameObject in the Canvas
		clone.transform.SetParent( GameObject.Find("Canvas").transform, false);
		//Set position
		RectTransform TransUI = clone.GetComponent<RectTransform> ();
		TransUI.anchoredPosition = positionUI;
		//Set info
		ExName infoUI = clone.GetComponentInChildren<ExName>();
		infoUI.SetText(clone.name);
	}

	
	public GameObject InstanceAndSetMax (string newName, string info , Vector2 positionUI)
	{
		//Instanciate GameObject
		GameObject clone = Instantiate(serieInfo, new Vector3(0,0,0), Quaternion.identity) as GameObject;

		clone.name = newName;
		//Put the GameObject in the Canvas
		clone.transform.SetParent( GameObject.Find("Canvas").transform, false);
		//Set position
		RectTransform TransUI = clone.GetComponent<RectTransform> ();
		TransUI.anchoredPosition = positionUI;
		//Set info
		uiTextManager infoUI = clone.GetComponentInChildren<uiTextManager>();
		//la variable info sert à set les données
		infoUI.SetText(info);
		return clone;
	}

	//Instancez le temps de repos
	public void InstanceAndRestMax (string newName, float info, Vector2 positionUI){
		//Instanciate GameObject
		GameObject clone = Instantiate(countDown, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Put the GameObject in the Canvas
		clone.transform.SetParent( GameObject.Find("Canvas").transform, false);
		//Set position
		RectTransform TransUI = clone.GetComponent<RectTransform> ();
		TransUI.anchoredPosition = positionUI;
		//Set info
		countdown infoUI = clone.GetComponentInChildren<countdown>();
		infoUI.setCountDown(info);
	}
}
