using UnityEngine;
using System.Collections;

public class Dos_biceps : SystemeScene {

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

	public override void SetWorkOut(GameObject exercice){
		MasterScript workOut = exercice.GetComponent<MasterScript>();
		if (nbEx == 1) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Traction");
			workOut.SetInfo ("Max");
			workOut.SetInfo ("Max");
			workOut.SetInfo ("Max");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 2) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Tirage horizontal");
			workOut.SetInfo ("8");;
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 3) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Tirage nuque");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 4) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Pull over haltères");
			workOut.SetInfo ("15");
			workOut.SetInfo ("15");
			workOut.SetInfo ("15");
			workOut.SetRest (90);
			workOut.SetRest (90);
			workOut.SetRest (90);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 5) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Curl aux haltères");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		}
	}
}
