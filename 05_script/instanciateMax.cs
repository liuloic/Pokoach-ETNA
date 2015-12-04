using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class instanciateMax : MonoBehaviour {

	public GameObject serieInfo;
	public GameObject countDown;
	public GameObject nameEx;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject InstanceAndSetMax (string newName, string info , Vector2 positionUI)
	{
		//Instanciate GameObject
		GameObject clone = Instantiate(nameEx, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		return clone;
	}
}
