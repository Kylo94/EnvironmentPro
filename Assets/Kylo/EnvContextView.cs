using strange.extensions.context.impl;

public class EnvContextView : ContextView
{
    private void Awake()
    {
        context = new EnvContext(this);
    }
}