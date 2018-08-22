using strange.extensions.command.impl;
using UnityEngine;

public class StartCommand : Command
{
    public override void Execute()
    {
        Debug.Log("开始命令");
    }
}