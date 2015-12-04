using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MasterScriptMax : MonoBehaviour {


	public int nbserie = 0;
	public int nbSerieEnCour;

	public float res;
	public string inf;
	public Vector2 pos = new Vector2 ();
	GameObject ser;




	public instanciate call;
	
	public bool endEg;

	public int nbRep = 0;
	public float rest = new float();
	public string info ;
	public Vector2 position; 
	public GameObject serieObject;
	public GameObject serieEnCour;
	public GameObject nameEx;

	// Use this for initialization
	void Start () {

		serieObject  = new GameObject();
		position = new Vector2();
	}
	
	// Update is called onƒ◊ce per frame
	void Update () {

	}

	public void LauchExercice (string info, Vector2 position){

		serieObject = (call.InstanceAndSetMax ("Test Max" , info ,position));
			Debug.Log ("lauch");
	}

	public void DestroyExercice(){
		Destroy (nameEx);
		Destroy (serieObject);
		Destroy (gameObject);
	}

	public void SetNameEx(string exName){
		call.InstanceAndName(exName,new Vector2 (0, 220));
		nameEx = GameObject.Find (exName);
	}
}
