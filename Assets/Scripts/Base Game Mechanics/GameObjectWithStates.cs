using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameObjectWithStates : BaseGameObject
{

    protected GameObjectState _currentState;

    public void SetState(GameObjectState state)
    {
        if (_currentState != null)
        {
            _currentState.OnExit();
        }
        _currentState = state;
        _currentState.OnEnter();
    }

    public void ResetState()
    {
        _currentState.Reset();
    }
}
