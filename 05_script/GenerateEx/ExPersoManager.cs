using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExPersoManager : MonoBehaviour {

	public void AddDevCouch(string type){
		if (type == "force")
			Debug.Log ("lol");
		else if (type == "endurance")
			Debug.Log ("mdr");
		else if (type == "volume")
			Debug.Log ("lolilol");
		else 
			Debug.Log ("hooo you are in trouble");

		List<string> data = new List<string> ();
		List<int> rest = new List<int> ();

		data.Add ("8");
		data.Add ("10");
		data.Add ("12");

		rest.Add (90);
		rest.Add (90);
		rest.Add (120);

		AddExToXml ("développer coucher", data, rest);
		print ("xml create");
	}

	public void AddExToXml(string name, List<string> data, List<int> rest){
		ExerciceContainer exerciceContainer = ExerciceContainer.Load ();

		Exercice exercice = new Exercice ();
		exercice.Name = name;

		for (int i = 0; i < data.Count && i < rest.Count; i++) {
			exercice.Series.Add(new Serie(rest[i], data[i], i));
		}

		exerciceContainer.Exercices.Add(exercice);

		exerciceContainer.Save();

	}

}
