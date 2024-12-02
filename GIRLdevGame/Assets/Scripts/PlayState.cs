using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayState : BaseState
{
    public override void EnterState(GameController gameController)
    {
        //start enemy spawning
        gameController.EnemySpawnerComponent.StartSpawning(gameController.EnemyPrefab);

        gameController.EnemySpawnerComponent.Initialize(gameController);
        gameController.UIControllerComponent.InitializeUI();

        gameController.PlayerHealthComponent.playerKilled += gameController.UIControllerComponent.ShowEndText;
        
    }
    public override void UpdateState(GameController gameController)
    {
        //player movement
        gameController.PlayerMovementComponent.MovePlayer();

        //shooting enemies
        gameController.PlayerShootingComponent.Shoot(gameController.WeaponPrefab);

        //enemy movement
        gameController.EnemyControllerComponent.MoveEnemies();

        //player get damage
        gameController.PlayerHealthComponent.GetDamage(gameController);

        //update score
        gameController.UIControllerComponent.UpdateScore(gameController.scoreController.Score);

        //if player was damaged, switch state, done in event now
 /*       if (gameController.PlayerHealthComponent.IsKilled)
        {
            Debug.Log("killed");
            gameController.SwitchState(gameController.endGameState);
        }*/
    }
    public override void ExitState(GameController gameController)
    {
        gameController.EnemySpawnerComponent.StopSpawning();

        gameController.EnemySpawnerComponent.Deinitialize(gameController);
        gameController.PlayerHealthComponent.playerKilled -= gameController.UIControllerComponent.ShowEndText;

    }
}