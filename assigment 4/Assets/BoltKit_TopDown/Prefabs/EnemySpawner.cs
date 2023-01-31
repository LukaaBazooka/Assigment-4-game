using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject EnemyPrefab;

    [SerializeField]
    private float EnemyInterval = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyInterval, EnemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-25f, 25), Random.Range(-25f, 26f), 0), Quaternion.identity);
        if ( interval > 1)
        {
         interval = interval - .05f;
         Debug.Log(interval);
        }

        StartCoroutine(spawnEnemy(interval, enemy));
    }
}