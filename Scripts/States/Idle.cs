// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/02/25 18:02
// @version: 1.0
// @description:
// *****************************************************************************

using LumiVerseFramework.Base.FSM;
using LumiVerseFramework.Common;

namespace LumiVerseFramework1.Scripts.States;

public partial class Idle : StateNode
{
    public override bool OnCheck(StateContext context = null)
    {
        return true;
    }

    public override void OnEnter(StateContext context = null)
    {
        YumihoshiDebug.Print<Idle>("测试FSM", "进入Idle状态");
    }

    public override void OnProcess()
    {
    }

    public override void OnPhysicsProcess()
    {
    }

    public override void OnExit(StateContext context = null)
    {
        YumihoshiDebug.Print<Idle>("测试FSM", "退出Idle状态");
    }
}
