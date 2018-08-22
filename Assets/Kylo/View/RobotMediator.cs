using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class RobotMediator : Mediator
{
    [Inject]
    public RobotView _view { get; set; }
    public override void OnRegister()
    {

    }
    public override void OnRemove()
    {
    }
}
