using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bridgeScriptToFSM : loadxmltest {

	public System.Collections.Generic.List<float> XmlFloat = new System.Collections.Generic.List<float>();

	private bool starting;

	public int setLigne;

	public float heur;
	public float lat;
	public float lon;
	public float speed;

	// Use this for initialization
	void Start () {

		starting = true;

		SetAllPart ();
		GetTheXml ();
		SetArray ();
		GetVariable ();

	}

	// Update is called once per frame
	void Update () {

		Setligne ();
	}

	void Setligne(){
		
		if (setLigne != xml.actualLevel ^ starting) {
			if(starting){
				starting = false;
			}
			xml.actualLevel = setLigne;
			GetTheXml ();
			LevelStartInfo ();
			GetVariable();
		}
		
	}

	void SetArray(){

		Debug.Log (xml.getter.Count);

		for (int i = 0; i < xml.getter.Count; i++) {
			
			XmlFloat.AddRange (new float[] {42.0f});
			
		}
	
	}

	void GetVariable (){

		for (int i = 1; i < xml.getter.Count; i++) {
				
			XmlFloat[i] = float.Parse (xml.reader[i]);
		
		}

		heur = XmlFloat[1];
		lat = XmlFloat[2];
		lon = XmlFloat[3];
		speed = XmlFloat[4];

	}
	
}
