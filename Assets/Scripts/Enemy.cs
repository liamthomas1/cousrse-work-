using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
[System.Serializable]
public class EnemySpawnedEvent : UnityEvent<Transform> { }
public class Enemy : MonoBehaviour
{
    public EnemySpawnedEvent onSpawn;
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        GetComponent<MoveTowardsObject>().target = player.transform;
        GetComponent<SmoothLookAtTarget2D>().target = player.transform;

        //print(player);
        //onSpawn.Invoke(player.transform);
    }
}

