using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Vector2 enemySpawnRange;
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject point;
    [SerializeField]
    private bool enemyCheck;
    [SerializeField]
    private bool pointCheck;


    private void Start() {
        if(enemyCheck && !pointCheck){
            StartCoroutine(SpawnEnemy());
        }

        else if(!enemyCheck && pointCheck){
            StartCoroutine(SpawnPoint());
        }
    }

    private IEnumerator SpawnEnemy() {
        yield return new WaitForSeconds(2);
        Vector2 spawnPosition = transform.position + new Vector3(0, Random.Range(-enemySpawnRange.y,enemySpawnRange.y));
        Instantiate(enemy,spawnPosition,transform.rotation);
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnPoint() {
        yield return new WaitForSeconds(2);
        Vector3 randomPos = Random.insideUnitCircle.normalized * 1.5f;
        Instantiate(point,randomPos,Quaternion.identity);
        StartCoroutine(SpawnPoint());

    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(this.transform.position,1.6f);
    }


}
