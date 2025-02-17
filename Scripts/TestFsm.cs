// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/02/16 15:02
// @version: 1.0
// @description:
// *****************************************************************************

using LumiVerseFramework.Base.FSM;
using LumiVerseFramework.Base.FSM.Types;
using LumiVerseFramework1.Scripts.States;

namespace LumiVerseFramework1.Scripts;

public partial class TestFsm : FsmNode<TestStateType>
{
    public override void _Ready()
    {
        Fsm.AddState(TestStateType.Test, new TestState());
        Fsm.AddState(TestStateType.Test2, new Test2State());
        Fsm.SwitchState(TestStateType.Test);
        Fsm.SwitchState(TestStateType.Test2);
    }
}
