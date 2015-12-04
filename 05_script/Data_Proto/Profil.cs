using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;


public class Profil : MonoBehaviour {

    public User CurrentUser;
    private UserContainer UserList;

    void Start() {
        UserList = UserContainer.Load();
        CurrentUser = UserList.GetCurrentUser();
        GameObject uiTextUserEmail = GameObject.Find("User_Email");
        GameObject goLastName = GameObject.Find("Input_LastName");
        GameObject goFirstName = GameObject.Find("Input_FirstName");

        goLastName.GetComponent<InputField>().text = CurrentUser.LastName;
        goFirstName.GetComponent<InputField>().text = CurrentUser.FirstName;
        uiTextUserEmail.GetComponent<Text>().text = CurrentUser.Email;
    }

	void Update(){

	}

	void OnGUI() {

	}

    public void OnChangeLastName()
    {
        GameObject goLastName = GameObject.Find("Input_LastName");
        InputField inputFieldLastName = goLastName.GetComponent<InputField>();

        CurrentUser.LastName = inputFieldLastName.text;

        UserList.Save();
    }

    public void OnChangeFirstName()
    {
        GameObject goFirstName = GameObject.Find("Input_FirstName");
        InputField inputFieldFirstName = goFirstName.GetComponent<InputField>();

        CurrentUser.FirstName = inputFieldFirstName.text;

        UserList.Save();
    }
}
