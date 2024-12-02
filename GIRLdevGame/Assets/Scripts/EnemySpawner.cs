using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Coroutine spawnEnemy;

    public void Initialize(GameController gameController)
    {
        //subscribe enemy killed event
        gameController.EnemyControllerComponent.enemyKilled += gameController.scoreController.IncreaseScore;
    }

    public void Deinitialize(GameController gameController)
    {
        //unsubscribe enemy killed event
        gameController.EnemyControllerComponent.enemyKilled -= gameController.scoreController.IncreaseScore;
    }

    IEnumerator SpawnEnemy(GameObject enemyPrefab)
    {
        while (true)
        {
            float position_x = UnityEngine.Random.Range(-5.5f, 0.5f);
            Vector3 newPosition = enemyPrefab.transform.position;
            newPosition.x = position_x;

            Instantiate(enemyPrefab, newPosition, enemyPrefab.transform.rotation);
            yield return new WaitForSeconds(2f);
        }
    }

    public void StartSpawning(GameObject enemyPrefab)
    {
        spawnEnemy = StartCoroutine(SpawnEnemy(enemyPrefab));
    }

    public void StopSpawning()
    {
        StopCoroutine(spawnEnemy);
    }

}
