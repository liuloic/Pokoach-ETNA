using UnityEngine;
using System.Collections;

public class cuisses : SystemeScene {

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
			workOut.SetNbSerie (4);
			workOut.SetNameEx("Squat");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetInfo ("8");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (4, workOut.info, workOut.position);
		} else if (nbEx == 2) {
			workOut.SetNbSerie (4);
			workOut.SetNameEx("Svt");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (4, workOut.info, workOut.position);
		} else if (nbEx == 3) {
			workOut.SetNbSerie (4);
			workOut.SetNameEx("Press");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetInfo ("10");
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.SetRest (120);
			workOut.LauchExercice (4, workOut.info, workOut.position);
		} else if (nbEx == 4) {
			workOut.SetNbSerie (3);
			workOut.SetNameEx("Fentes");
			workOut.SetInfo ("20");
			workOut.SetInfo ("20");
			workOut.SetInfo ("20");
			workOut.SetRest (90);
			workOut.SetRest (90);
			workOut.SetRest (90);
			workOut.LauchExercice (3, workOut.info, workOut.position);
		} else if (nbEx == 5) {
			workOut.SetNbSerie (4);
			workOut.SetNameEx("Mollet Press à Cuisse");
			workOut.SetInfo ("20");
			workOut.SetInfo ("20");
			workOut.SetInfo ("20");
			workOut.SetInfo ("20");
			workOut.SetRest (60);
			workOut.SetRest (60);
			workOut.SetRest (60);
			workOut.SetRest (60);
			workOut.LauchExercice (4, workOut.info, workOut.position);
		}
	}
}
