using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public UnityAction playerKilled;
/*    private bool isKilled = false;

    public bool IsKilled
    {
        get
        {
            return isKilled;
        }
    }*/


    public void GetDamage(GameController gameController)
    {
        List<GameObject> enemies = gameController.EnemyControllerComponent.Enemies;

        foreach (GameObject enemy in enemies) 
        { 
            if(enemy.transform.position.z < -10.5f)
            {
                //isKilled = true;
                playerKilled?.Invoke();
                Destroy(enemy);

                gameController.SwitchState(gameController.endGameState);
            }
        }
    }
}