using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameObjectWithStates : BaseGameObject
{

    private GameObjectState _currentState;

    protected void SetState(GameObjectState state)
    {
        if (_currentState != null)
        {
            _currentState.OnExit();
        }
        _currentState = state;
        _currentState.OnEnter();
    }

    protected void ResetState()
    {
        _currentState.Reset();
    }
}
