using Entitas;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _players;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _players = contexts.game.GetGroup(GameMatcher.PlayerHealth);
    }

    public void Execute()
    {
        foreach (var player in _players.GetEntities())
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                player.isPlayerDamaged = true;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                player.isPlayerHealed = true;
            }
        }
    }
}