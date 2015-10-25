using UnityEngine;
using System.Collections;

public class Pec_tricep : SystemeScene {

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
			workOut.SetNameEx("Développé incliné");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 2) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Développé couché");
			workOut.SetInfo ("8");;
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 3) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Dips");
			workOut.SetInfo ("Max");
			workOut.SetInfo ("Max");
			workOut.SetInfo ("Max");
			workOut.SetRest (90);
			workOut.SetRest (90);
			workOut.SetRest (90);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 4) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Poulie vis à vis");
			workOut.SetInfo ("15");
			workOut.SetInfo ("15");
			workOut.SetInfo ("15");
			workOut.SetRest (60);
			workOut.SetRest (60);
			workOut.SetRest (60);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 5) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Triceps poulie");
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
