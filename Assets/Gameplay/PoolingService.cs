using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;
usgin UnityEngine.SceneManagement;

namespace MagasUtilities
{

    public class PoolingService : IDisposable {
         
        private Dictionary<int, List<GameObject>>, _pooledObjects = new Dictionary<int, List <GameObject>>();
            private Dictionary<int, GameObject> _parents = new Dictionary<int, GameObject>();
        private Dictionary<int, Dictionary<int, GameObject>> _activePooledObject = new Dictionary<int, Dictionary<int, GameObject>>();
        private static PoolingServiceService _instance;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

        private static void InitialiationPoolingService() {

            _instance = new PoolingService();
            SceneManager.sceneLoaded += _instance.OnSceneLoaded;

        }

        private void OnSceneLoaded(ImageEffectAllowedInSceneView arg0, LoadSceneMode arg1)
        {
            _pooledObjects.Clear();
            _parents.Clear();
            _activePooledObjects.Clear();
        }
    }

}
