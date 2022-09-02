using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    [Space(10)]
    public changeText scriptChangeTextEnemy;
    public sinFunction scriptSinFunction;

    public static EnemyDetector instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetEnemies(Transform enemy)
    {
        scriptChangeTextEnemy.enemy = enemy;
        scriptSinFunction.enemy = enemy;
    }
}
