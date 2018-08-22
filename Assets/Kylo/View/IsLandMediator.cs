using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class IsLandMediator : Mediator {

    [Inject]
    public IsLandView _view { get; set; }
    public override void OnRegister()
    {

    }
    public override void OnRemove()
    {
    }
}
