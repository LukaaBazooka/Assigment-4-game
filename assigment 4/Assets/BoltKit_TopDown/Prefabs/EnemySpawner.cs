using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject EnemyPrefab;

    [SerializeField]
    private float interval = 3.5f;
    int spawned = 0;
    float wave1max = 10;
    float wave2max = 20;
    float wave3max = 30;
    float wave4mac = 40;
    float wave5mac = 50;

    int wave = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(interval, EnemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        
        yield return new WaitForSeconds(interval);

        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-25f, 25), Random.Range(-25f, 26f), 0), Quaternion.identity);
        spawned++;



        if (wave == 1)
        {
            interval = 3.5f;
        }
        else if (wave == 2)
        {
            interval = 3f;
        }
        else if (wave == 3)
        {
            interval = 2.5f;
        }
        else if (wave == 4)
        {
            interval = 2f;
        }
        else if (wave == 5)
        {
            interval = 1f;
        }

        if (spawned == 10 && wave == 1)
        {
            spawned = 0;
            yield return new WaitForSeconds(60);
            wave = 2;
        }
        else if (spawned == 20 && wave == 2)
        {
            spawned = 0;
            yield return new WaitForSeconds(70);
            wave = 3;
        }
        else if (spawned == 30 && wave == 3)
        {
            spawned = 0;
            yield return new WaitForSeconds(70);
            wave = 4;
        }
        else if (spawned == 40 && wave == 4)
        {
            spawned = 0;
            yield return new WaitForSeconds(70);
            wave = 5;
        }
        else if (spawned == 50 && wave == 5)
        {
            spawned = 0;
            yield return new WaitForSeconds(70);
            wave = 4;
        }


        StartCoroutine(spawnEnemy(interval, enemy));
    }
}