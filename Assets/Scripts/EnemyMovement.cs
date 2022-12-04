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

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Enemy") || collision.CompareTag("Point")) {
            Destroy(gameObject);
        }
    }
}
