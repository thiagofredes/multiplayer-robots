using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameObjectWithStates {

	public CharacterController characterController;

	public float movementSpeed;

	public Animator playerAnimator;
	
	void Start () {
		SetState(new Running(this));
	}
	
	
	void Update () {
		_currentState.Update();
	}
}
