// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/02/22 20:02
// @version: 1.0
// @description:
// *****************************************************************************

using Godot;

namespace LumiVerseFramework.Base;

public partial class Singleton<T> : Node where T : Node
{
    public static T Instance => _instance;
    private static T _instance;

    public override void _EnterTree()
    {
        base._EnterTree();
        if (_instance != null)
        {
            QueueFree();
        }

        _instance = this as T;
    }
}
