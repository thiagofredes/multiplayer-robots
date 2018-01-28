using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameObjectState
{

    protected GameObjectWithStates _controlledBehaviour;

    public virtual void Reset() { }

    public virtual void OnEnter() { }

    public virtual void OnExit() { }

    public virtual void Update() { }

    public virtual void LateUpdate() { }

    public virtual void OnTriggerEnter(Collider col) { }

    public virtual void OnTriggerStay(Collider col) { }

    public virtual void OnTriggerExit(Collider col) { }

    public virtual void OnCollisionEnter(Collision col) { }

    public virtual void OnCollisionStay(Collision col) { }

    public virtual void OnCollisionExit(Collision col) { }

    public virtual void OnControllerColliderHit(ControllerColliderHit hit) { }
}
