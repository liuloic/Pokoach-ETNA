using UnityEngine;
using System.Collections;

public class SystemeScene : MonoBehaviour {

	public int nbEx;
	public int nbRep;
	public int poids;
	public int poitest;


	public GameObject exRunning;
	public GameObject Exercice;
	public GameObject TestMax;


	// Use this for initialization
	void Start () {
		nbEx = 0;
		SetNbEx ();
		InstanciateWorkOut("exercice" + nbEx);
	}
	
	// Update is called once per frame
	void Update () {
		exRunning = GameObject.Find ("exercice" + nbEx);
		LauchEnd ();
	}

	public void SetNbEx(){
		nbEx += 1;
	}

	public void LauchEnd(){
		MasterScript serieRunning = exRunning.GetComponent<MasterScript> ();
		if (serieRunning.endEg) {
			serieRunning.DestroyExercice ();
			SetNbEx();
			exRunning = InstanciateWorkOut("exercice" + nbEx);
		}
	}

	public GameObject InstanciateWorkOut(string newName){
		//Instanciate GameObject
		GameObject clone = Instantiate(Exercice, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Set parents 
		clone.transform.SetParent( this.transform, false);
		//Set info
		SetWorkOut (clone);
		return(clone);
	}

	public GameObject InstanciateWorkOutMax(string newName){
		//Instanciate GameObject
		GameObject clone = Instantiate(TestMax, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Set parents 
		clone.transform.SetParent( this.transform, false);
		//Set info
		SetWorkOut (clone);
		return(clone);
	}

	public virtual void SetWorkOut(GameObject exercice){
		MasterScript workOut = exercice.GetComponent<MasterScript>();
		workOut.SetNbSerie(3);
		workOut.SetInfo("8");
		workOut.SetInfo("8");
		workOut.SetInfo("8");
		workOut.SetRest(120);
		workOut.SetRest(120);
		workOut.SetRest(120);
		workOut.LauchExercice (3, workOut.info, workOut.position);
	}
}
