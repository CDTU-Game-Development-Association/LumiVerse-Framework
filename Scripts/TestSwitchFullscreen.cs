using Godot;
using LumiVerseFramework.Common;

namespace LumiVerseFramework1.Scripts;

public partial class TestSwitchFullscreen : Node
{
    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("SwitchFullscreen"))
            YumihoshiFullScreen.SwitchFullScreenAuto();
    }
}
