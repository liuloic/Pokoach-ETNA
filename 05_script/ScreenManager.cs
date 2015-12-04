using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScreenManager : MonoBehaviour {

	public enum State{
		Home,
		Programme,
		SelectionEx,
	}
	[SerializeField]
	private State _state;
	public State state{
		get{
			return _state;
		}
		set{
			ExitState(_state);
			_state = value;
			EnterState(_state);
		}
	}
	[SerializeField]
	private GameObject _currentScreen;
	public List<GameObject> screens = new List<GameObject>();

	void Start (){
		_currentScreen = screens[0];
        UserContainer users = UserContainer.Load();
        if (!users.Users.Exists(x => x.isConnected))
        {
            InstanScene callScene = GameObject.Find("système").GetComponent<InstanScene>();
            callScene.GoToLogin();
        }
            
    }

	void Update () {
		StayState (_state);
	}

	#region state machine
	public void EnterState(State stateEntered){
		switch(stateEntered)
		{
		case State.Home:
			Debug.Log ("state enter : Home");
			_currentScreen = screens[0];
			_currentScreen.SetActive (true);
			break;
		case State.Programme:
			Debug.Log ("state enter : Programme");
			_currentScreen = screens[2];
			_currentScreen.SetActive (true);
			break;
		case State.SelectionEx:
			Debug.Log ("state enter : SelectionEx");
			_currentScreen = screens[1];
			_currentScreen.SetActive (true);
			break;
		}
	}
	public void StayState(State stateStated){
		switch(stateStated)
		{
		case State.Home:
			break;
		case State.Programme:
			break;
		case State.SelectionEx:
			break;
		}
	}
	public void ExitState(State stateExited){
		switch(stateExited)
		{
		case State.Home:
			Debug.Log ("state Quit : Home");
			_currentScreen.SetActive (false);
			break;
		case State.Programme:
			Debug.Log ("state Quit : Programme");
			_currentScreen.SetActive (false);
			break;
		case State.SelectionEx:
			Debug.Log ("state Quit : SelectionEx");
			_currentScreen.SetActive (false);
			break;
		}
	}
	#endregion

	public void ChangeState(string newState){
		switch (newState) {
		case "Home":
			state = State.Home;
			break;
		case "Programme":
			state = State.Programme;
			break;
		case "SelectionEx":
			state = State.SelectionEx;
			break;
		}

		Debug.Log ("ChangeScreen");
	}
    
    public void LogOff()
    {
        UserContainer users = UserContainer.Load();
        users.GetCurrentUser().isConnected = false;

        users.Save();
    }
}
