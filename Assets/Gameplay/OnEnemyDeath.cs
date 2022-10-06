using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagasUtilities;

public class OnEnemyDeath : MonoBehaviour
{
    public void Die()
    {
        EventDispatcher.Dispatch(new DespawnObject(gameObject));

    }
    }

