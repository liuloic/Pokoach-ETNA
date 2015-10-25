using UnityEngine;
using System.Collections;

public class InstanScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Menu

	public void GoToMainMenu(){
		Application.LoadLevel("interface");
	}

	public void GoToProgramme()
	{
		Application.LoadLevel("programme");
	}
	public void GoToSelectExercice()
	{
		Application.LoadLevel("selectEx");
	}

// Programmes

	public void GoToTestMax(){
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
	

    #region Exercices

    public void GoToExCurlBarre()
    {
        Application.LoadLevel("Curl_barre");
    }

    public void GoToExDevBarre()
    {
        Application.LoadLevel("Dev_barre");
    }

    public void GoToExDevCouche()
    {
        Application.LoadLevel("Dev_couche");
    }

    public void GoToExDevIncline()
    {
        Application.LoadLevel("Dev_incline");
    }

    public void GoToExExtensionVerticale()
    {
        Application.LoadLevel("Extension_verticale");
    }

    public void GoToExRowing()
    {
        Application.LoadLevel("Rowing");
    }

    public void GoToExSouleveTerre()
    {
        Application.LoadLevel("Souleve_terre");
    }

    public void GoToExSquat()
    {
        Application.LoadLevel("Squat");
    }

    public void GoToExSquatSumo()
    {
        Application.LoadLevel("Squat_sumo");
    }

    public void GoToExTalonsDebout()
    {
        Application.LoadLevel("Talons_debout");
    }

    public void GoToExTirageMenton()
    {
        Application.LoadLevel("Tirage_menton");
    }

    public void GoToExTractionBarre()
    {
        Application.LoadLevel("Traction_barre");
    }


    #endregion


}
