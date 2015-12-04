using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MasterScript : MonoBehaviour {

	public Instanciate call;

	public bool endEg;

	public int nbserie = 0;
	public int nbSerieEnCour;

	public List<float> rest = new List<float>();
	public List<string> info = new List<string>();
	public List<Vector2> position = new List<Vector2>();

	public float res;
	public string inf;
	public Vector2 pos = new Vector2 ();
	GameObject ser;
	public List<GameObject> serieObject = new List<GameObject>();
	public GameObject serieEnCour;
	public GameObject nameEx;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		GetRest ();
	}

	public void LauchExercice (int nbSerie, List<string> getInfo, List<Vector2> getPosition){
		nbSerieEnCour = 1;
		for (int i = 0; i < nbserie; i++){
			serieObject.Add (call.InstanceAndSet ("serie" + (i+1).ToString() , getInfo[i], getPosition[i]));
			Debug.Log ("lauch");
		}
	}

	public void SetNameEx(string exName){
		call.InstanceAndName(exName,new Vector2 (0, 220));
		nameEx = GameObject.Find (exName);
	}

	public void SetNbSerie(int nb){
		// ici on set 
		nbserie = nb;
		SetPosition (nb);
	}

	public void SetInfo(string infoSTR){
		//  ici on set se qu'il y a d'écris dans les cercles
		info.Add (infoSTR);
	}

	public void SetRest(float time){
		// ici on set le temps de repos
		rest.Add (time);
	}

	void SetPosition(int nb){
		// ici on va set la position des cercles en fonction du nombre de série
		if (nb == 1) {
			position.Add (new Vector2(0, 140));
		} else if (nb == 2) {
			position.Add (new Vector2(-60, 140));
			position.Add (new Vector2(60, 140));
		} else if (nb == 3) {
			position.Add (new Vector2(-120, 140));
			position.Add (new Vector2(0, 140));
			position.Add (new Vector2(120, 140));
		} else if (nb == 4) {
			position.Add (new Vector2(-60, 140));
			position.Add (new Vector2(60, 140));
			position.Add (new Vector2(-60, 30));
			position.Add (new Vector2(60, 30));
		} else if (nb == 5) {
			position.Add (new Vector2(-120, 140));
			position.Add (new Vector2(0, 140));
			position.Add (new Vector2(120, 140));
			position.Add (new Vector2(-60, 30));
			position.Add (new Vector2(60, 30));
		}
	}

	void GetRest (){
		uiTextManager serieRunning;
		if (nbSerieEnCour <= nbserie) {
			serieEnCour = GameObject.Find ("serie" + nbSerieEnCour);
			if (serieEnCour != null) {
				if (serieRunning = serieEnCour.GetComponentInChildren<uiTextManager> ()) {
					if (serieRunning.done) {
						serieRunning.running = false;
						serieEnCour.SetActive(false);
						call.InstanceAndRest ("Rest", rest [nbSerieEnCour - 1], new Vector2 (0, -250));
						nbSerieEnCour += 1;
					} else {
						serieRunning.running = true;
					}
				}
			} 
		}
		else
		{
			serieEnCour = GameObject.Find("endExe");
			GameObject[] sprites = GameObject.FindGameObjectsWithTag("sprite");
			
			foreach (GameObject sprite in sprites)
			{
				sprite.SetActive(false);
			}
			endEg = true;
		}
	}


	public void DestroyExercice(){
		Destroy (nameEx);
		for (int i = 0; i < nbserie; i++){
			Destroy (serieObject[i]);
		}
		Destroy (gameObject);
	}

	public void LauchExerciceMax (string info, Vector2 position){
		
		ser = (call.InstanceAndSetMax ("Test Max" , inf ,pos));
		Debug.Log ("lauch");
	}
	
	public void DestroyExerciceMax(){
		Destroy (nameEx);
		Destroy (ser);
		Destroy (gameObject);
	}

}
