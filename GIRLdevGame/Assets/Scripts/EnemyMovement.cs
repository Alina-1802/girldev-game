using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public void MoveEnemy()
    {
        float speed = Random.Range(4f, 10f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
