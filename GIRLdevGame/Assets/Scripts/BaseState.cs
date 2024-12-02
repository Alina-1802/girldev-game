using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState(GameController gameController);
    public abstract void UpdateState(GameController gameController);
    public abstract void ExitState(GameController gameController);
}
