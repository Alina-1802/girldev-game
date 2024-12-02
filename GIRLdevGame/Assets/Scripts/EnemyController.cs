using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    List<GameObject> enemies;
    public UnityAction enemyKilled;

    public List<GameObject> Enemies
    {
        get 
        { 
            return enemies; 
        }
        set 
        {
            enemies = value; 
        }
    }

    private void UpdateEnemiesList()
    {
        enemies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
        InitializeEnemies();
    }

    private void InitializeEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            enemy.GetComponent<EnemyGetDamage>().Initialize(this);
        }
    }

    public void MoveEnemies()
    {
        UpdateEnemiesList();

        if(enemies != null)
        {
            foreach (GameObject enemy in enemies)
            {
                enemy.GetComponent<EnemyMovement>().MoveEnemy();
            }
        }
    }
}
