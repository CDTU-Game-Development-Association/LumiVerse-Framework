// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/02/16 15:02
// @version: 1.0
// @description:
// *****************************************************************************

using LumiVerseFramework.Base.FSM;

namespace LumiVerseFramework1.Scripts;

public partial class TestFsm : FsmNode
{
    public override void _Ready()
    {
        base._Ready();
        Fsm.SwitchState("Walk");
        Fsm.SwitchState("Idle");
        Fsm.SwitchState("Attack");
        Fsm.SwitchState("Idle");
    }
}
