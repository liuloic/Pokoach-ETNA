using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test_max : SystemeScene {
	
	MasterScriptMax	serieRunning;
	Text text;
	public GameObject BtnUp;
	public GameObject BtnDown;
	public GameObject Valider;


	// Use this for initialization
	void Start () {	
		TestMax = InstanciateWorkOutMax("Test Max" );
		serieRunning = TestMax.GetComponent<MasterScriptMax> ();
		nbRep = 8;
		poids = 0;
		poitest = 80;
		GameObject Poids = GameObject.Find ("poids");
		Poids.GetComponentInChildren<Text> ().text = poitest.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		TestMax = GameObject.Find ("TextMax");
		//LauchEnd ();
	}
	
	public void LauchEnd(){
		TestMax = new GameObject("TestMax");
		MasterScriptMax serieRunning = TestMax.GetComponent<MasterScriptMax> ();
			serieRunning.DestroyExercice ();
			TestMax = InstanciateWorkOut("TestMax");
	}
	
	public GameObject InstanciateWorkOut(string newName){
		GameObject clone = Instantiate(TestMax);
		//Instanciate GameObject
		clone = Instantiate(TestMax, new Vector3(0,0,0), Quaternion.identity) as GameObject;
		//Set name for find
		clone.name = newName;
		//Set parents 
		clone.transform.SetParent( this.transform, false);
		//Set info
		SetWorkOut (clone);
		return(clone);
	}
	
	public override  void SetWorkOut(GameObject exercice){
		MasterScriptMax workOut = exercice.GetComponent<MasterScriptMax>();
		workOut.SetNameEx ("Proto Max");
		workOut.nbserie = 1 ;
		workOut.position = (new Vector2(0, 140));
		workOut.info = (nbRep.ToString());
		workOut.rest = (120);
		workOut.LauchExercice (workOut.info, workOut.position);
	}
	
	public void SetNbRep()
	{
		nbRep += 1;
	}
	
	public void SetPoidUp()
	{
		poids += 1;
		GameObject u = BtnUp;
		Text text = BtnUp.GetComponentInChildren<Text> ();
		text.text = poids.ToString();
		GameObject newPoids = GameObject.Find ("newPoids");
		newPoids.GetComponentInChildren<Text> ().text = poids.ToString();
		poitest += 1;
		GameObject Poids = GameObject.Find ("poids");
		Poids.GetComponentInChildren<Text> ().text = poitest.ToString();
	}
	
	public void SetPoidDown()
	{
		poids -= 1;
		Text text = BtnDown.GetComponentInChildren<Text> ();
		text.text = poids.ToString();
		GameObject newPoids = GameObject.Find ("newPoids");
		newPoids.GetComponentInChildren<Text> ().text = poids.ToString();
		poitest -= 1;
		GameObject Poids = GameObject.Find ("poids");
		Poids.GetComponentInChildren<Text> ().text = poitest.ToString();
	}

	//calcule du coach
	public void SetNbrRep()
	{
		//bouchon
		nbRep = 7;
		nbRep -= 2;
		if (nbRep == 1 || nbRep == 3)
		{
			this.LauchEnd();
		}
	}

	public void submit()
	{
		//serieRunning.DestroyExercice ();
		SetNbrRep ();
	    // exRunning = InstanciateWorkOut("exercice" + nbEx);
		// nTestMax = InstanciateWorkOutMax("Test Max" );
		// serieRunning.SetNameEx ("Proto Max");
		// serieRunning.nbserie = 1 ;
	    //	serieRunning.position = (new Vector2(0, 140));
	    //	serieRunning.info = (nbRep.ToString());
	    //	serieRunning.rest = (120);
	    //	serieRunning.LauchExercice (workOut.info, workOut.position);
	}
}
