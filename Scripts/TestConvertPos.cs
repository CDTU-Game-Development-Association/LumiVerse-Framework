// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/02/25 19:02
// @version: 1.0
// @description:
// *****************************************************************************

using Godot;
using LumiVerseFramework.Common;

namespace LumiVerseFramework1.Scripts;

public partial class TestConvertPos : Node
{
    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event is InputEventMouseButton mouseEvent &&
            mouseEvent.Pressed &&
            mouseEvent.ButtonIndex == MouseButton.Left)
        {
            // 获取屏幕坐标
            Vector2 screenPos = mouseEvent.Position;

            // 转换为世界坐标
            Vector2 worldPos =
                YumihoshiConvert.ConvertScreenToWorld(screenPos, this);

            YumihoshiDebug.Print<TestConvertPos>("测试屏幕坐标转换为世界坐标",
                $"点击位置 - 屏幕: {screenPos} 世界: {worldPos}");
        }
    }
}
