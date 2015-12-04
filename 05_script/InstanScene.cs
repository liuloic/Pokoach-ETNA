using UnityEngine;
using System.Collections;

public class InstanScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void GoToTestMax()
	{
		Application.LoadLevel("test_max");
	}

	public void GoToDosBiceps(){
	
		Application.LoadLevel("dos_biceps");
	
	}

	public void GoToPecTriceps(){
		
		Application.LoadLevel("pec_triceps");
		
	}

	public void GoToEpaule(){
		
		Application.LoadLevel("epaule");
		
	}

	public void GoToJambe(){
		
		Application.LoadLevel("jambe");
		
	}

	public void GoToMainMenu(){
		
		Application.LoadLevel("mainMenu");
		
	}

}
