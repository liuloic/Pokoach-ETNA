using UnityEngine;
using System.Collections;

public class MainStates : MonoBehaviour {

	public Login log;
	public Instanciate setObject;

	public enum State{
		Init,
		Identification,
		Main_menu,
		Profil,
		Training,
		Res_Social
	}
	[SerializePrivateVariables]
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
	
	public bool quitState;

	void Start () {
		state = State.Init;
		quitState = false;
	}
	
	// Update is called once per frame
	void Update () {
		StayState (_state);
	}
	
	public void EnterState(State stateEntered){
		switch(stateEntered)
		{
		case State.Init:
			Debug.Log ("state enter : Init");
			break;
		case State.Identification:
			Debug.Log ("state enter : Identification");
			setObject.InstanceLoginForm(new Vector2(0, 0));
			break;
		case State.Main_menu:
			Debug.Log ("state enter : Main");
			break;
		case State.Profil:
			Debug.Log ("state enter : Profil");
			break;
		case State.Training:
			Debug.Log ("state enter : Training");
			break;
		case State.Res_Social:
			Debug.Log ("state enter : Social");
			break;
		}
	}
	
	public void StayState(State stateStated){
		switch(stateStated)
		{
		case State.Init:
			Debug.Log ("state : Init");
			state = State.Identification;
			break;
		case State.Identification:
			Debug.Log ("state : Identification");
			break;
		case State.Main_menu:
			Debug.Log ("state : Main ");
			break;
		case State.Profil:
			Debug.Log ("state : Profil");
			break;
		case State.Training:
			Debug.Log ("state : Training");
			break;
		case State.Res_Social:
			Debug.Log ("state : Social");
			break;
		}
	}
	
	public void ExitState(State stateExited){
		switch(stateExited)
		{
		case State.Init:
			Debug.Log ("state Quit : Init");
			break;
		case State.Identification:
			Debug.Log ("state Quit : Identification");
			break;
		case State.Main_menu:
			Debug.Log ("state Quit : Main_menu");
			break;
		case State.Profil:
			Debug.Log ("state Quit : Profil");
			break;
		case State.Training:
			Debug.Log ("state Quit : Training");
			break;
		case State.Res_Social:
			Debug.Log ("state Quit : Res_Social");
			break;
		}
		
	}



}
