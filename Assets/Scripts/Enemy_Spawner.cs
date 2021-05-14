using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 5f;
    [SerializeField] Enemy[] enemyPrefabArray;
    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttakers();
        }
    }

    private void SpawnAttakers()
    {
        int enemyIndex = Random.Range(0, enemyPrefabArray.Length);
        Spawn(enemyPrefabArray[enemyIndex]);
    }

    private void Spawn(Enemy enemy)
    {
        Enemy newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
    }
    public void StopSpawn()
    {
        spawn = false;
    }
}
