using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfigSO> waveConfigs;
    [SerializeField] float timeBetweenWaves = 0f;
    [SerializeField] bool isLooping;
    WaveConfigSO currentWave;

    void Start()
    {
        StartCoroutine(SpawnEnemyWaves());
    }

    public WaveConfigSO GetCurrentWave()
    {
        return currentWave;
    }


    IEnumerator SpawnEnemyWaves()
    {

        do
        {
            foreach (WaveConfigSO wave in waveConfigs)
            {
                currentWave = wave;
                for (int i = 0; i < currentWave.GetEnemyCount(); i++)
                {
                    GameObject enemyPrefab = currentWave.GetEnemyPrefab(i);
                    if (enemyPrefab.tag == "bigenemy")
                    {

                        Vector3 rot = enemyPrefab.transform.rotation.eulerAngles;
                        rot = new Vector2(rot.x, rot.y + 180);

                        Instantiate(currentWave.GetEnemyPrefab(i),
                        currentWave.GetStartingWaypoint().position,
                        Quaternion.Euler(rot),
                        transform);
                    }
                    else
                    {
                        Instantiate(enemyPrefab,
                        currentWave.GetStartingWaypoint().position,
                        Quaternion.identity,
                        transform);


                    }
                    yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());

                }
                yield return new WaitForSeconds(timeBetweenWaves);
            }
        } while (isLooping);



    }
}
