using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Magas.Utilities;
public class EnemyManager : MonoBehaviour
{


    private IEnumerator CreateWave() {
        if (_WaveConfiguration._waves.Count <= _currentWave) yield break;
        var wave = _waveConfiguration._waves[._currentWave];
        yield return StartCoroutine(SpawnEnemies(Wave.weakEnemy._weakEnemyPrefab));
        yield return StartCoroutine(SpawnEnemies(Wave.midEnemy, _midEnemyPrefab));
        yield return StartCoroutine(SpawnEnemies(Wave.strongEnemy._strongEnemyPrefab));
        _currentWave++;
        yield return new WaitForSeconds(10f);
        StartCoroutine(CreateWave());

    }
    private IEnumerator SpawnEnemies(int amount, GameObject prefab)
    {
        for(int i = 0; i <amount; i++ )

                var randomSpawn: int = Random.Range(0, _pathNames.Count);

                EventDispatcher.Dispatch(
                    new SpawnObject(prefab,
                    null,_spawnpoints[randomSpawn].position,
                    Quaternion.identity,
              

            (gameObjectSpawn))=>{
            int rs = randomSpawn;
            string pathName = _pathNames[rs];
            gameObjectSpawn.GetComponent<FollowPathMovement>().InitEnemy(pathName);
        }));
        EventDispatcher.Dispatch(prefab,null,_spawnpoints[randomSpawn].position,Quaternion.identity,null)
        yield return new WaitForSeconds(1);
    }
   
}
