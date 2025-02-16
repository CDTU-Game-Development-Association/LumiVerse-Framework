// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/02/16 15:02
// @version: 1.0
// @description:
// *****************************************************************************

using LumiVerseFramework.Base.FSM;
using LumiVerseFramework.Base.FSM.States;
using LumiVerseFramework.Base.FSM.Types;

namespace LumiVerseFramework1.Scripts;

public partial class TestFsm : FsmNode
{
    public override void _Ready()
    {
        Fsm.AddState(StateType.Test, new TestState());
        Fsm.AddState(StateType.Test2, new Test2State());
        Fsm.SwitchState(StateType.Test);
        Fsm.SwitchState(StateType.Test2);
    }
}
