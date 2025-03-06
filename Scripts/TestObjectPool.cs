using Godot;
using LumiVerseFramework.Async;
using LumiVerseFramework.Base;

namespace LumiVerseFramework1.Scripts;

public partial class TestObjectPool : Node2D
{
    [Export] private PackedScene _bullet;
    private ObjectPool<Bullet> _pool;

    public override async void _Ready()
    {
        base._Ready();
        _pool = new ObjectPool<Bullet>(_bullet, this);
        Bullet a = _pool.GetObj();
        a.Position = new Vector2(-954, 546);
        await WaitTask.WaitForSeconds(this, 5f);
        _pool.ReleaseObj(a);
    }
}
