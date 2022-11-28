using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        //spawnPoint();
    }

    private void spawnPoint() {
        bool pointSpawned = false;

        while(!pointSpawned) {
            Vector3 pointPos = new Vector3(Random.Range(-7f,7f),Random.Range(-3f,3f),0);

            if((pointPos - transform.position).magnitude < 3) {
                continue;
            }
            else {
                Instantiate(point,pointPos,Quaternion.identity);
                pointSpawned = true;
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
        spawnPoint();
    }
}
