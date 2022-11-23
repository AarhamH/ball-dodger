using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float enemySpeed;

    private void FixedUpdate() {
        transform.Translate(enemySpeed*Time.deltaTime,0,0);
    }
}
