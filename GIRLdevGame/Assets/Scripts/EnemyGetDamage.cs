using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyGetDamage : MonoBehaviour
{
    EnemyController enemyController;

    public void Initialize(EnemyController enemyController)
    {
        this.enemyController = enemyController;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            //enemy killed event invoke
            enemyController.enemyKilled?.Invoke();

            Destroy(gameObject);
        }
    }
}
