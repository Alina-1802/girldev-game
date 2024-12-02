using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    public PlayerMovement PlayerMovementComponent
    {   get
        {
            return playerMovement;
        }
    }

    [SerializeField] EnemySpawner enemySpawnerComponent;
    public EnemySpawner EnemySpawnerComponent
    {
        get
        {
            return enemySpawnerComponent;
        }
    }

    [SerializeField] GameObject enemyPrefab;
    public GameObject EnemyPrefab
    {
        get
        {
            return enemyPrefab;
        }
    }

    [SerializeField] PlayerShooting playerShootingComponent;
    public PlayerShooting PlayerShootingComponent
    {
        get
        {
            return playerShootingComponent;
        }
    }

    [SerializeField] GameObject weaponPrefab;
    public GameObject WeaponPrefab
    {
        get
        {
            return weaponPrefab;
        }
    }

    [SerializeField] EnemyController enemyController;
    public EnemyController EnemyControllerComponent
    {
        get 
        { 
            return enemyController;
        }
    }

    [SerializeField] PlayerHealth playerHealth;
    public PlayerHealth PlayerHealthComponent
    {
        get
        {
            return playerHealth;
        }
    }

    [SerializeField] UIController UIcontroller;

    public UIController UIControllerComponent
    {
        get
        {
            return UIcontroller;
        }
    }

    public ScoreController scoreController = new ScoreController();

    public PlayState playState = new PlayState();
    public EndGameState endGameState = new EndGameState();
    BaseState currentState;

    void Start()
    {
        currentState = playState;
        playState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
        Debug.Log("State" + currentState.ToString());
    }

    public void SwitchState(BaseState newState)
    {
        currentState.ExitState(this);
        currentState = newState;
        currentState.EnterState(this);
    }
}
