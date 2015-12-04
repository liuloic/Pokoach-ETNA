using UnityEngine;
using System.Collections;

public class ExerciceManager : MonoBehaviour {

	public enum State{
		Init,
		WorkOut,
		Rest,
		End,
		notSet
	}

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


	// Use this for initialization
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
			break;
		case State.WorkOut:
			if (quitState){
				state = State.Rest;
			}
			break;
		case State.Rest:
			break;
		case State.End:
			break;
		}
	}

	public void StayState(State stateStated){
		switch(stateStated)
		{
		case State.Init:
			break;
		case State.WorkOut:
			break;
		case State.Rest:
			break;
		case State.End:
			break;
		}
	}

	public void ExitState(State stateExited){
		switch(stateExited)
		{
		case State.Init:
			break;
		case State.WorkOut:
			break;
		case State.Rest:
			break;
		case State.End:
			break;
		}

	}
}
