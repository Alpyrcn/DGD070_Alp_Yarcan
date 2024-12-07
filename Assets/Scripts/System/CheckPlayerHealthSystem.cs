using Entitas;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _players;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _players = contexts.game.GetGroup(GameMatcher.PlayerHealth);
    }

    public void Execute()
    {
        foreach (var player in _players.GetEntities())
        {
            if (player.isPlayerDamaged)
            {
                player.ReplacePlayerHealth(Mathf.Max(0, player.playerHealth.Value - 10));
                player.isPlayerDamaged = false;
            }

            if (player.isPlayerHealed)
            {
                player.ReplacePlayerHealth(Mathf.Min(100, player.playerHealth.Value + 10));
                player.isPlayerHealed = false;
            }
        }
    }
}
