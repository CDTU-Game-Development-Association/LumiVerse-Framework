using Godot;
using LumiVerseFramework1.LumiVerseFrameWork;

namespace LumiVerseFramework1.Scripts;

public partial class TestDebug : Node
{
    public override void _Ready()
    {
        YumihoshiDebug.Print<TestDebug>("测试", "这是可爱的测试信息，嘻嘻~");
        YumihoshiDebug.Warn<TestDebug>("测试", "这是可爱的警告信息，嘻嘻~");
        YumihoshiDebug.Error<TestDebug>("测试", "这是可爱的错误信息，嘻嘻~");
    }
}
