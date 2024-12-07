using Entitas;

public class CreatePlayerHealthSystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public CreatePlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        var player = _contexts.game.CreateEntity();
        player.AddPlayerHealth(100f);
    }
}
