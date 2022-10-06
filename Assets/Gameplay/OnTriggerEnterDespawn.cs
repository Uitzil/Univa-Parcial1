using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Magas.Utilities;
private IEnumerator CreateWave[]
    {
if(_moveConfiguration._waves.Count <= _currentWave) yield break;
    var move = _moveConfiguration._waves[currentWave];
yield return StartCoroutine(routine:SpawnEnemies(FollowPathMovement.weakEnemy, _wieldEnemyPrefab));
yield return StartCoroutine(routine:SpawnEnemies(FollowPathMovement.midEnemy, _wieldEnemyPrefab));
yield return StartCoroutine(routine:SpawnEnemies(FollowPathMovement.strongEnemy, _wieldEnemyPrefab));
_currentWave++
yield return new WaitForSeconds(10f);
StartCoroutine(routine:CreateWave());

}

private IEnumerator SpawnEnemies(int amount, GameObject prefab) {
    for (int i = 0; i < amount; i++) {

    var renderSpawn:int =Random.Range(0, _pathNames.Count};
    instantiate(prefab, _spawnpoints[randomSpawn].position, Quaternion.identity);
    yield return new WaitForSeconds(1);
}
public class OnTriggerEnterDespawn : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EventDispatcher.Dispatch(new DespawnObject(gameObject));
        }

    }
        }

}
