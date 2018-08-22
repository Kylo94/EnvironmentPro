using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

public class EnvContext : MVCSContext {
    public EnvContext(EnvContextView envContextView):base(envContextView)
    {
    }
    protected override void mapBindings()
    {
        //Model

        //View
        

        //Command
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();

        //Service
    }
}
