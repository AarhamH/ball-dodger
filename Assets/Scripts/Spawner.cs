using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Vector2 spawnRange;
    [SerializeField]
    private GameObject enemy;

    private void Start() {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy() {
        yield return new WaitForSeconds(1);
        Vector2 spawnPosition = transform.position + new Vector3(0, Random.Range(-spawnRange.y,spawnRange.y));
        Instantiate(enemy,spawnPosition,Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }
}
