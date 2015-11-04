using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;


public class Login : MonoBehaviour {

	public string Email = "";
	public string Password = "";
	public string ConfirmPassword = "";
	public GameObject panelLogin;
	public GameObject panelRegister;
	public bool isLogged = false;

	void Start() {

	}

	void Update(){
		if (isLogged){
			InstanScene callScene = GameObject.Find("Camera").GetComponent<InstanScene> ();
			callScene.GoToMainMenu();
		}
	}

	void OnGUI() {

	}

	public void ActivePanelLogin(){
		panelLogin.SetActive (true);
	}

	public void ActivePanelRegister(){
		panelRegister.SetActive (true);
	}

	public void DesactivePanelRegister(){
		panelRegister.SetActive (false);
	}

	public void DesactivePanelLogin(){
		panelLogin.SetActive (false);
	}

	public void LoginSubmit() {
		GameObject goLoginEmail = GameObject.Find("LoginEmailInputField");
		InputField inputFieldEmail = goLoginEmail.GetComponent<InputField>();
		Email = inputFieldEmail.text;

		GameObject goLoginPassword = GameObject.Find("LoginPasswordInputField");
		InputField inputFieldPassword = goLoginPassword.GetComponent<InputField>();
		Password = inputFieldPassword.text;

		if (Helper.IsEmail (Email)) {
			UserContainer users = UserContainer.Load();
			if (users.Users.Exists(x => x.Email == Email && x.Password == Password && x.isActive)) {
				Debug.Log("Connected");

                foreach(User userToReset in users.Users)
                {
                    userToReset.isConnected = false;
                }

                User crtUser = users.GetUser(Email);
                crtUser.isConnected = true;

                users.Save();

                isLogged = true;
            }
		    else {
				isLogged = false;
				Debug.Log("Error");
			}
		}
	}

	public void RegisterSubmit() {
		GameObject goRegisterEmail = GameObject.Find("RegisterEmailInputField");
		InputField inputFieldEmail = goRegisterEmail.GetComponent<InputField>();
		Email = inputFieldEmail.text;
		
		GameObject goRegisterPassword = GameObject.Find("RegisterPasswordInputField");
		InputField inputFieldPassword = goRegisterPassword.GetComponent<InputField>();
		Password = inputFieldPassword.text;

		GameObject goRegisterRePassword = GameObject.Find("RegisterRePasswordInputField");
		InputField inputFieldRePassword = goRegisterRePassword.GetComponent<InputField>();
		ConfirmPassword = inputFieldRePassword.text;


		if (Helper.IsEmail (Email) && (Password == ConfirmPassword) && !String.IsNullOrEmpty(Password)) {
			UserContainer users = UserContainer.Load();

			User newUser = new User();
			newUser.Email = Email;
			newUser.Password = Password;

			users.Users.Add(newUser);
			users.Save();
		}
	}
}
